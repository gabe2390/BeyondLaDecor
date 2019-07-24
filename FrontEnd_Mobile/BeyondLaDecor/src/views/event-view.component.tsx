import React from "react";
import { Container, Content, Form, Picker, Icon, DatePicker, Item } from "native-base";
import { EventCard } from "../components/event-card/event-card.component";
import { Location } from "../models/location.model";
import { User } from "../models/user.model";
import { Package } from "../models/package.model";
import { Task } from "../models/task.model";
import { Event } from "../models/event.model";
import { SortingMethods, SortingMethod } from "../utilities/sorting-methods";
import { FilteringMethods, FilteringMethod } from "../utilities/filtering-methods";
import { AppLoading } from "expo";
import Axios from "axios";
import { connect } from "react-redux";

export interface EventViewState {
    filteringMethod: FilteringMethod,
    sortingMethod: SortingMethod,
    startDateRange?: Date,
    endDateRange?: Date,
    events: Event[],
    loading: boolean
}
export class EventView extends React.Component<any, EventViewState> {
    sortingMethodMap: { [method: string]: SortingMethod };
    filteringMethodMap: { [method: string]: FilteringMethod };
    events: Event[];

    constructor(props: any) {
        super(props);
        console.log(this.state && this.state.filteringMethod);
        console.log(this.state && this.state.sortingMethod);
        this.state = {
            filteringMethod: this.state && this.state.filteringMethod || FilteringMethods.empty,
            sortingMethod: this.state && this.state.sortingMethod || SortingMethods.empty,
            startDateRange: this.state && this.state.startDateRange || undefined,
            endDateRange: this.state && this.state.endDateRange || undefined,
            events: [],
            loading: true
        };

        this.events = this.getEvents();
        this.sortingMethodMap = this.createSortingMethodMap();
        this.filteringMethodMap = this.createFilteringMethodMap();
    }

    async componentWillMount() {
        await Axios.get()
        .then(()=>{})
        .catch(()=>{});
        this.setState({ ...this.state, loading: false });
    }

    createSortingMethodMap(): { [method: string]: SortingMethod } {
        let map: { [method: string]: SortingMethod } = {};
        map["Event Date"] = SortingMethods.eventDate;
        map["Event Type"] = SortingMethods.eventType;
        map["Cost"] = SortingMethods.cost;
        return map;
    }

    createFilteringMethodMap(): { [method: string]: FilteringMethod } {
        let map: { [method: string]: FilteringMethod } = {};
        map["Event Type"] = FilteringMethods.eventTypeFilter;
        map["Package"] = FilteringMethods.packageFilter;
        return map;
    }

    render() {
        return this.state.loading ?
            <AppLoading /> : (
                <Container>
                    <Content >
                        <Container style={{ flexDirection: "row", justifyContent: "space-evenly", height: 50 }}>
                            {this.getSortMenu()}
                            {this.getFilterMenu()}
                            {this.getDateRangeMenu()}
                        </Container>
                        <Container style={{ flex: 1, flexDirection: "column" }}>
                            {this.getEventCards()}
                        </Container>
                    </Content>
                </Container>
            );
    }

    createMenu(methodMap: { [method: string]: Function }): Element[] {
        let items: Element[] = [];
        let index = 1;
        for (var method in methodMap) {
            items.push(<Picker.Item key={index} label={method} value={method} />)
            index++;
        }
        return items;
    }

    getSortMenu(): React.ReactNode {
        return <Form style={{ flex: 2 }}>
            <Picker
                mode="dropdown"
                iosHeader="Sort"
                style={{ flex: 1 }}
                selectedValue={this.state.sortingMethod}
                onValueChange={this.changeSortingMethod.bind(this)}>
                {this.getSortingMenuItems()}
            </Picker>
        </Form>
    }
    getSortingMenuItems(): Element[] {
        return this.createMenu(this.sortingMethodMap);
    }

    changeSortingMethod(method: string, position: number) {
        this.setState({ ...this.state, sortingMethod: this.sortingMethodMap[method] });
    }

    getFilterMenu(): React.ReactNode {
        return <Form style={{ flex: 2 }}>
            <Picker
                mode="dropdown"
                iosHeader="Filter"
                style={{ flex: 1 }}
                selectedValue={this.state.filteringMethod}
                onValueChange={this.changeFilteringMethod.bind(this)}>
                {this.getFilterMenuItems()}
            </Picker>
        </Form>
    }

    getFilterMenuItems(): any[] {
        return this.createMenu(this.filteringMethodMap);
    }

    changeFilteringMethod(method: string, position: number) {
        console.log("setting state");
        this.setState({ ...this.state, filteringMethod: this.filteringMethodMap[method] });
        console.log("state set");
    }

    setStartDateRange() { }
    setEndDateRange() { }
    getDateRangeMenu(): any {
        let startDatePicker = <DatePicker
            defaultDate={new Date(2018, 4, 4)}
            minimumDate={new Date(2018, 1, 1)}
            maximumDate={new Date(2018, 12, 31)}
            locale={"en"}
            timeZoneOffsetInMinutes={undefined}
            modalTransparent={false}
            animationType={"fade"}
            androidMode={"default"}
            placeHolderText="From:"
            textStyle={{ color: "green" }}
            placeHolderTextStyle={{ color: "#d3d3d3" }}
            onDateChange={this.setEndDateRange.bind(this)}
            disabled={false}
        />;
        let endDatePicker = <DatePicker
            defaultDate={new Date(2018, 4, 4)}
            minimumDate={new Date(2018, 1, 1)}
            maximumDate={new Date(2018, 12, 31)}
            locale={"en"}
            timeZoneOffsetInMinutes={undefined}
            modalTransparent={false}
            animationType={"fade"}
            androidMode={"default"}
            placeHolderText="To"
            textStyle={{ color: "green" }}
            placeHolderTextStyle={{ color: "#d3d3d3" }}
            onDateChange={this.setEndDateRange.bind(this)}
            disabled={false}
        />;

        return <Container style={{ flex: 3, flexDirection: "row" }}>
            {startDatePicker}
            {endDatePicker}
        </Container>;
    }
    getEventCards(): Element[] {
        return this.events.map((event: Event, index: number): Element =>
            <EventCard style={{ height: 40 }} key={index} event={event} tasks={this.getTasks()}></EventCard>)
    }
    getEvents(): Event[] {
        var events: Event[] = [];
        for (var i: number = 0; i < 6; i++) {
            events.push(this.getEvent())
        }
        return events.filter(this.state.filteringMethod).sort(this.state.sortingMethod);
    }
    getEvent(): Event {
        let client: User = {
            firstName: "Abe",
            lastName: "Lincoln",
            isAdministrator: false,
            email: "abc@gmail.com",
            userName: "abeLinc09"
        };
        let weddingPackage: Package = {
            packageId: 1,
            capacity: 200,
            isCustom: false,
            name: "Platinum",
            services: [
                {
                    name: "DJ",
                    description: "Disc Jockey",
                    thirdParty: false,
                    serviceId: 1,
                    serviceType: { name: "Media", serviceTypeId: 4 }
                },
                {
                    name: "Photographer",
                    description: "Take pics",
                    thirdParty: true,
                    serviceId: 1,
                    serviceType: { name: "Media", serviceTypeId: 4 }
                }],
            products: [
                {
                    name: "Golden Arches",
                    description: "Golden Son!",
                    productId: 1,
                    thirdParty: false,
                    productType: { name: "CenterPiece", productTypeId: 1 }
                },
                {
                    name: "Purple Arches",
                    description: "Purple Son!",
                    productId: 2,
                    thirdParty: false,
                    productType: { name: "CenterPiece", productTypeId: 1 }
                }
            ]
        };
        let locations: Location[] = [
            {
                name: "Bistro Romanos", locationId: 1, startTime: new Date(251513512351),
                address: "123 Fake Street", city: "Philadelphia", state: "PA", zipCode: "19124"
            }
        ];
        var event: Event = {
            eventId: 1,
            eventType: { name: "Wedding", eventTypeId: 1 },
            client: client,
            package: weddingPackage,
            date: new Date(),
            locations: locations,
            cost: 0
        }
        return event;
    }
    getTasks(): Task[] {
        return [
            { taskId: 1, name: "Eat cake", complete: false },
            { taskId: 2, name: "Eat dinner", complete: true }
        ];
    }
}

var EventsViews = connect(mapStateToProps, mapDispatchToProps)(EventView);
export default EventsViews;
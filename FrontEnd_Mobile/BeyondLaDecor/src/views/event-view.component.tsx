import React from "react";
import { Container, Content, Form, Picker, Icon, DatePicker } from "native-base";
import { EventCard } from "../components/event-card/event-card.component";
import { Location } from "../models/location.model";
import { User } from "../models/user.model";
import { Package } from "../models/package.model";
import { Task } from "../models/task.model";
import { Event } from "../models/event.model";

export interface EventViewState {

}
export class EventView extends React.Component<{}, EventViewState> {
    constructor() {
        super({});
    }
    render() {

        return (
            <Container>
                <Content>
                    <Container>
                        {this.getSortMenu()}
                        {this.getFilterMenu()}
                        {this.getDateRangeMenu()}
                    </Container>
                </Content>
                {this.getEvents()}
            </Container>
        );
    }
    getSortMenu(): React.ReactNode {
        return <Form>
            <Picker
                mode="dropdown"
                iosHeader="Sort"
                iosIcon={<Icon name="arrow-down" />}
                style={{ width: "30px" }}
                selectedValue={this.state.selected}
                onValueChange={this.changeSortingMethod.bind(this)}>
                <Picker.Item label="Wallet" value="key0" />
                <Picker.Item label="ATM Card" value="key1" />
                <Picker.Item label="Debit Card" value="key2" />
                <Picker.Item label="Credit Card" value="key3" />
                <Picker.Item label="Net Banking" value="key4" />
            </Picker>
        </Form>
    }
    getFilterMenu(): React.ReactNode {
        return <Form>
            <Picker
                mode="dropdown"
                iosHeader="Filter"
                iosIcon={<Icon name="arrow-down" />}
                style={{ width: undefined }}
                selectedValue={this.state.selected}
                onValueChange={this.changeFilteringMethod.bind(this)}>
                <Picker.Item label="Wallet" value="key0" />
                <Picker.Item label="ATM Card" value="key1" />
                <Picker.Item label="Debit Card" value="key2" />
                <Picker.Item label="Credit Card" value="key3" />
                <Picker.Item label="Net Banking" value="key4" />
            </Picker>
        </Form>
    }
    getDateRangeMenu(): React.ReactNode {
        let startDatePicker = <DatePicker
            defaultDate={new Date(2018, 4, 4)}
            minimumDate={new Date(2018, 1, 1)}
            maximumDate={new Date(2018, 12, 31)}
            locale={"en"}
            timeZoneOffsetInMinutes={undefined}
            modalTransparent={false}
            animationType={"fade"}
            androidMode={"default"}
            placeHolderText="Select date"
            textStyle={{ color: "green" }}
            placeHolderTextStyle={{ color: "#d3d3d3" }}
            onDateChange={this.setDate}
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
            placeHolderText="Select date"
            textStyle={{ color: "green" }}
            placeHolderTextStyle={{ color: "#d3d3d3" }}
            onDateChange={this.setDate}
            disabled={false}
        />;

        return <Container>
            {startDatePicker}
            {endDatePicker}
        </Container>;
    }

    getEvents() {
        var events: Event[] = [];
        for (var i: number = 0; i < 6; i++) {
            events.push(this.getEvent())
        }
        return events.map((event: Event) => <EventCard event={event} tasks={this.getTasks()}></EventCard>)
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
            locations: locations
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
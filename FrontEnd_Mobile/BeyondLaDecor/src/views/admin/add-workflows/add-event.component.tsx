import React, { Props } from 'react';
import { StyleSheet, Text, View } from 'react-native';
import { Container, Form, Picker, Content, DatePicker } from 'native-base';
import { HttpService } from '../../../services/httpservice.service';
import { Service } from '../../../models/service.model';
import { User } from '../../../models/user.model';
import axios from 'axios';
import { Package } from '../../../models/package.model';
import { Product } from '../../../models/product.model';
import { EventType } from '../../../models/event-type.model';
import {DateRange}from '../../../utilities/filtering-methods';
export interface AddEventState {
    eventType: EventType,
    services: Service[],
    date: Date,
    client: User
}

export class AddEvent extends React.Component<{}, {}> {
    eventTypes : EventType[];
    constructor(props: {}) {
        super(props);
        this.eventTypes = [];
    }
    render() {
        return (
            <Container>
                <Content>
                    {this.getEventDatePicker()}
                    {this.getEventTypePicker()}
                </Content>
            </Container>
        );
    }
    componentDidMount(): void {
        HttpService.getEventCreationDetails().
            then(axios.spread(function (a, b, c, d) {

            }));
    }
    getEventDatePicker(): Element {
        return <DatePicker
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
            onDateChange={this.setEventDate.bind(this)}
            disabled={false}
        />;
    }

    setEventDate(){}
    getEventTypePicker(): Element {
        return <Form style={{ flex: 2 }}>
            <Picker
                mode="dropdown"
                iosHeader="Sort"
                style={{ flex: 1 }}
                selectedValue={this.props.selectedEventType}
                onValueChange={this.selectEventType.bind(this)}>
                {this.getEventTypeSelections()}
            </Picker>
        </Form>
    }

    getEventTypeSelections(): Element[] {
        let items: Element[] = [];
        let index = 1;
        for (let method in methodMap) {
            items.push(<Picker.Item key={index} label={method} value={method} />)
            index++;
        }
        return items;
    }

    selectEventType(eventType: string) {
        this.props.changeFilteringMethod(this.filteringMethodMap[method]);
    }
}
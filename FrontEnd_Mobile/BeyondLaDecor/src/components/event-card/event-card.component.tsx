import React from "react";
import { Card, Container, Content, CardItem } from 'native-base';
import { Text } from "react-native";
import { Event } from "../../models/event.model";
import { Task } from "../../models/task.model";

export interface EventCardProps{
    event : Event,
    tasks : Task[]
}

export class EventCard extends React.Component<EventCardProps, any> {
    constructor(props: EventCardProps) {
        super(props);
    }

    render() {
        return (
            <Container>
                <Content>
                    <Card>
                        <CardItem>
                            <Text>{this.generateEventNickName()}</Text>
                        </CardItem>
                    </Card>
                </Content>
            </Container>
        );
    }
    generateEventNickName(): string {
        const clientName = this.props.event.client.firstName + " " + this.props.event.client.lastName;
        const eventType = this.props.event.eventType.name;
        const packageName = this.props.event.package.isCustom ? "Custom" : this.props.event.package.name;
        return eventType + " " + clientName + " " + packageName;
    }
}
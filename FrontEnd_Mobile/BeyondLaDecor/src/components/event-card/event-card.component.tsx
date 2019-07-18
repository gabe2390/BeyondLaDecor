import React from "react";
import { Card, Container, Content, CardItem, Badge } from 'native-base';
import { Text } from "react-native";
import { Event } from "../../models/event.model";
import { Task } from "../../models/task.model";
import moment from 'moment';
import { User } from "../../models/user.model";
import { Package } from "../../models/package.model";
import { Location } from "../../models/location.model";
export interface EventCardProps {
    event: Event,
    tasks: Task[]
}

export class EventCard extends React.Component<any, any> {
    constructor(props: EventCardProps) {
        super(props);
    }

    render() {
        return (
            <Container style={{width:"90%"}}>
                <Content>
                    <Card>
                        <CardItem header>
                            <Text>{this.generateEventNickName()}</Text>
                        </CardItem>
                        <CardItem>
                            <Text>
                                When : {this.formattedEventTime()}
                            </Text>
                        </CardItem>
                        <CardItem>
                            <Text>
                                Where : {this.getEventLocationDetail()}
                            </Text>
                        </CardItem>
                        <CardItem>
                            <Text>
                                Cost : $12,000
                            </Text>
                        </CardItem>
                        <CardItem>
                            <Text>Services :</Text>
                            <Badge>
                                <Text>{this.props.event.package.services.length}</Text>
                            </Badge>
                            <Text>Products :</Text>
                            <Badge>
                                <Text>{this.props.event.package.products.length}</Text>
                            </Badge>
                            <Text>Tasks: </Text>
                            {this.getTaskStats()}
                        </CardItem>
                    </Card>
                </Content>
            </Container>
        );
    }
    getEventLocationDetail(): string {
        let eventLocation = this.props.event.locations[0];
        return `${eventLocation.name}\n
                  ${eventLocation.address}\n
                  ${eventLocation.city}, ${eventLocation.state} ${eventLocation.zipCode}\n
                  ${this.props.event.locations.length > 1 ? '...and more' : ''}`;
    }
    formattedEventTime(): string {
        let eventDate = this.props.event.date
        return moment(eventDate).format('MMMM Do YYYY');
    }
    getTaskStats() {
        let completedTasks = this.props.tasks.filter((task: any) => { task.complete });
        return (
            <Badge>
                <Text>{completedTasks.length}/{this.props.tasks.length}</Text>
            </Badge>);
    }
    generateEventNickName(): string {
        const clientName = this.props.event.client.firstName + " " + this.props.event.client.lastName;
        const eventType = this.props.event.eventType.name;
        const packageName = this.props.event.package.isCustom ? "Custom" : this.props.event.package.name;
        return `${clientName} - ${eventType} - ${packageName}`;
    }
}

import React from "react";
import {Text, Container } from "native-base";
import { EventCard } from "../components/event-card/event-card.component";

export interface PackageServiceViewState {
    
}
export class PackageServiceView extends React.Component<{}, PackageServiceViewState> {
    constructor() {
        super({});
    }
    render() {
        return (
            <Container>
                <Text>I don't know yet!</Text>
            </Container>
        );
    }
}
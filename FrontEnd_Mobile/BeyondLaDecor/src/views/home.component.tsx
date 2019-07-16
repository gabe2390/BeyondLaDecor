import React from 'react';
import { StyleSheet, Text, View } from 'react-native';
import { ClientHome } from './client/home.client.component';
import { AdminHome } from './admin/home.admin.component';
import { Container } from 'native-base';
export interface HomeState {
    isAdmin: boolean
}
export class Home extends React.Component<{}, HomeState> {
    constructor() {
        super({});
    }
    render() {
        return (
            <Container>
                {this.getCurrentView()}
            </Container>
        );
    }

    getCurrentView() {
        console.log(this.state);
        return this.state.isAdmin ? <AdminHome></AdminHome> : <ClientHome></ClientHome>;
    }
}
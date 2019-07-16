import React, { Props } from 'react';
import { StyleSheet, Text, View } from 'react-native';
import AdminLogin from './admin/login.admin.component';
import { ClientLogin } from './client/login.client.component';
import { Container } from 'native-base';

export interface LoginState {
    viewingAdmin: boolean,
    attemptingToLogin: boolean
}
export class Login extends React.Component<{}, LoginState> {
    constructor(props: {}) {
        super(props);
        this.state = {
            viewingAdmin: true,
            attemptingToLogin: false
        };
        console.log(this.state);
        console.log(this.props);
    }
    render() {
        return (
            <Container>
                {this.getCurrentView()}
            </Container>
        );
    }
    getCurrentView() {
        return this.state.viewingAdmin ? <AdminLogin></AdminLogin> : <ClientLogin></ClientLogin>;
    }
}
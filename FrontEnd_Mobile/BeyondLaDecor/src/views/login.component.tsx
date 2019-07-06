import React, { Props } from 'react';
import { StyleSheet, Text, View } from 'react-native';
import AdminLogin from './admin/login.admin.component';
import { ClientLogin } from './client/login.client.component';

export interface LoginState{
    viewingAdmin : boolean,
    attemptingToLogin : boolean
}
export class Login extends React.Component<{}, LoginState> {
    constructor(props: {}) {
        super(props);
        this.state = {
            viewingAdmin : true,
            attemptingToLogin : false
        };
    }
    render() {
        return (
            <View>
                {this.getCurrentView()}
            </View>
        );
    }

    getCurrentView() {
        return this.state.viewingAdmin ? <AdminLogin></AdminLogin> : <ClientLogin></ClientLogin>;
    }
}
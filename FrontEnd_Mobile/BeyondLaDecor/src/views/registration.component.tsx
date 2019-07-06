import React from 'react';
import { StyleSheet, Text, View, CheckBox } from 'react-native';
import { User } from '../models/user.model';
export interface RegistrationState {
    attemptingToRegister: boolean
}
export class Registration extends React.Component<{}, RegistrationState> {
     user : User;
    constructor(props: {}) {
        super(props);
        this.user = {};
    }
    render() {
        return (
            <View>
                <Text>Register Here</Text>
                <Text>Are You a Wedding/Event Panner?</Text>
                <CheckBox></CheckBox>
                <View>
                    <Text>First Name</Text>
                    <Text>Last Name</Text>
                    <Text>Email</Text>
                    <Text>User Name</Text>
                    <Text>City</Text>
                    <Text>State</Text>
                    <Text>Zip Code</Text>
                </View>
            </View>
        );
    }
}
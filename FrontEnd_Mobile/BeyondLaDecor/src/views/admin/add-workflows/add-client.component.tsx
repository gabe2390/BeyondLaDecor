import React, { Props } from 'react';
import { StyleSheet, Text, View } from 'react-native';
import { Container } from 'native-base';

export class AddClient extends React.Component<{}, {}> {
    constructor(props: {}) {
        super(props);
    }
    render() {
        return (
            <Container>
                <Text>First Name</Text>
                <Text>Last Name</Text>
                <Text>Email</Text>
            </Container>
        );
    }
}
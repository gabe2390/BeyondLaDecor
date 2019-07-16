import React from 'react';
import { Text } from 'react-native';
import { User } from '../models/user.model';
import { Container, Content, Form, Item, Input, ListItem, Body, CheckBox } from 'native-base';
export interface RegistrationState {
    attemptingToRegister: boolean,
    user: User
}
export class Registration extends React.Component<{}, RegistrationState> {

    constructor(props: {}) {
        super(props);
        this.state = {
            attemptingToRegister: false,
            user: { isAdministrator: false } as User
        };
    }
    render() {
        return (
            <Container>
                <Content>
                    <Form>
                        <Item>
                            <Input placeholder="First Name" textContentType="name"
                                onChangeText={(text) => this.updateProperty(text, "firstName")} />
                        </Item>
                        <Item >
                            <Input placeholder="Last Name" textContentType="name"
                                onChangeText={(text) => this.updateProperty(text, "lastName")} />
                        </Item>
                        <Item >
                            <Input placeholder="Email" textContentType="emailAddress"
                                onChangeText={(text) => this.updateProperty(text, "email")} />
                        </Item>
                        <Item >
                            <Input placeholder="User Name" textContentType="username"
                                onChangeText={(text) => this.updateProperty(text, "userName")} />
                        </Item>
                        <Item >
                            <Input placeholder="City" textContentType="addressCity"
                                onChangeText={(text) => this.updateProperty(text, "city")} />
                        </Item>
                        <Item >
                            <Input placeholder="State" textContentType="addressState"
                                onChangeText={(text) => this.updateProperty(text, "state")} />
                        </Item>
                        <Item >
                            <Input placeholder="ZipCode"
                                onChangeText={(text) => this.updateProperty(text, "zipcode")} />
                        </Item>
                        <ListItem>
                            <Body>
                                <Text>Wedding/Event Planner</Text>
                            </Body>
                            <CheckBox checked={this.state.user.isAdministrator}
                                onPress={this.updateAdminProperty} />
                        </ListItem>
                    </Form>
                </Content>
            </Container>
        );
    }
    updateProperty = (text: string, property: string): void => {
        let user = { ...this.state.user, [property]: text };
        this.setState({ ...this.state, user });
        console.log(user);
    }
    updateAdminProperty = () => {
        let user = { ...this.state.user, isAdministrator: !this.state.user.isAdministrator };
        this.setState({ ...this.state, user });
        console.log(user); 
    }
}
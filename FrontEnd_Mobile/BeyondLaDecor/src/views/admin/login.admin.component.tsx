import React from 'react';
import { StyleSheet, Text, View, TextInput } from 'react-native';
import { Container, Header, Content, Form, Item, Input } from 'native-base';


export interface Props { }
export interface State { }
export default class AdminLogin extends React.Component<{}, State> {
  constructor(props: {}) {
    super(props);
  }
  render() {
    return (
      <Container>
        <Content>
          <Form>
            <Item>
              <Input placeholder="Username" />
            </Item>
            <Item last>
              <Input placeholder="Password" />
            </Item>
          </Form>
        </Content>
      </Container>
    )
  }
}

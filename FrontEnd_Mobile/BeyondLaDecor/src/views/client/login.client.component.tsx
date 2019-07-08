import React from 'react';
import { StyleSheet, Text, View } from 'react-native';
import { Container } from 'native-base';

export class ClientLogin extends React.Component<{}, {}> {
  constructor(props: {}) {
    super(props);
  }
  render() {
    return (
      <Container>
        <Text>This shit cray Admin</Text>
        <Text>Open up App.tsx to start working on your app!</Text>
      </Container>
    );
  }
}
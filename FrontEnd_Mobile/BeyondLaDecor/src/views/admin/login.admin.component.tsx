import React from 'react';
import { StyleSheet, Text, View, TextInput } from 'react-native';

export interface Props { }
export interface State { }
export default class AdminLogin extends React.Component<{}, State> {
  constructor(props: {}) {
    super(props);
  }
  render() {
    return (
    <View>
      <Text>Email</Text>
      <TextInput/>
      <Text>Password</Text>
      <TextInput/>
    </View>)
  }
}

import React from 'react';
import { StyleSheet, Text, View } from 'react-native';
import { Home } from './src/views/home.component';
import { Login } from './src/views/login.component';
import { Registration } from './src/views/registration.component';
import { ButtonGroup } from 'react-native-elements';
import { createStore } from 'redux';
export interface AppState {
  loggedIn?: boolean,
  loginIndex: number
}
export default class App extends React.Component<{}, AppState> {

  private buttons: string[] = ["Log In", "Register"];
  constructor(props: {}) {
    super(props);
    this.state = {
      loginIndex: 0 
    };
  }
  render() {
    let selectedIndex: number = this.state.loginIndex;
    return (
      <View style={this.styles.container}>
        {this.getFirstView()}
        <ButtonGroup
          onPress={this.updateIndex}
          selectedIndex={selectedIndex}
          buttons={this.buttons}
          containerStyle={{ height: 100 }} />
      </View>
    );
  }
  updateIndex = (selectedIndex: number) => {
    this.setState({ loginIndex: selectedIndex });
  }
  getFirstView() {
    var component = this.buttons[this.state.loginIndex] === "Register" ?
      <Registration></Registration> : <Login></Login>
    return this.state.loggedIn ? <Home></Home> : component;
  }

  styles = StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: '#fff',
      alignItems: 'center',
      justifyContent: 'center',
    },
  });
}

import React from 'react';
import { StyleSheet, Text, View } from 'react-native';
import { Home } from './src/views/home.component';
import { Login } from './src/views/login.component';
import { Registration } from './src/views/registration.component';
import { ButtonGroup } from 'react-native-elements';
import { Provider, connect } from 'react-redux';
import laDecorStore from './src/state-management/store';
import FirstScreen, { IntialScreen } from './IntialScreen';
import Header from './src/components/header/header.component';

export default class App extends React.Component {
  render() {
    return (
      <Provider store={laDecorStore}>
        <Header></Header>
        <FirstScreen />
      </Provider>
    );
  }
}
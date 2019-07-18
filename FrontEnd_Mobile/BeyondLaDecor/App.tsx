import React from 'react';
import { StyleSheet, Text, View } from 'react-native';
import { Home } from './src/views/home.component';
import { Login } from './src/views/login.component';
import { Registration } from './src/views/registration.component';
import { Provider, connect } from 'react-redux';
import laDecorStore from './src/state-management/store';
import * as Font from 'expo-font'
import { LaDecorHeader } from './src/components/header/header.component';
import FirstScreen from './src/views/IntialScreen';
import { AppLoading } from 'expo';
import RootNavigator from './src/navigation/root-navigator';
import Navigation from './src/navigation/root-navigator';
import { Dashboard } from './src/views/dashboard.component';

export default class App extends React.Component<any, any> {
  constructor(props: any) {
    super(props);
    this.state = { loading: true }
  }
  render() {
    return this.state.loading ?
      <AppLoading /> :
      (
        <Provider store={laDecorStore}>
          <Dashboard/>
        </Provider>
      );
  }

  async componentWillMount() {
    await Font.loadAsync({
      Roboto: require("native-base/Fonts/Roboto.ttf"),
      Roboto_medium: require("native-base/Fonts/Roboto_medium.ttf")
    });
    this.setState({...this.state, loading: false});
  }
}
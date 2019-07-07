import React, { Dispatch } from 'react';
import { StyleSheet, Text, View } from 'react-native';
import { Home } from './src/views/home.component';
import { Login } from './src/views/login.component';
import { Registration } from './src/views/registration.component';
import { ButtonGroup } from 'react-native-elements';
import { connect } from 'react-redux';
import { toggleLoginView } from './src/state-management/actions/root-actions.action';

export class IntialScreen extends React.Component<any, AppState> {
  private buttons: string[] = ["Log In", "Register"];

  constructor(props: any) {
    super(props);
    this.getFirstView = this.getFirstView.bind(this);
  }

  render() {
    return (
      <View style={this.styles.container}>
        {this.getFirstView()}
        <ButtonGroup
          onPress={this.toggleLoginView}
          selectedIndex={this.props.loginIndex}
          buttons={this.buttons}
          containerStyle={{ height: 100 }} />
      </View>
    );
  }
  toggleLoginView = (selectedIndex: number) => {
    this.props.toggleLoginView(selectedIndex);
  }
  getFirstView() {
    var component = this.buttons[this.props.loginIndex] === "Register" ?
      <Registration></Registration> : <Login></Login>
    return this.props.loggedIn ? <Home></Home> : component;
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

let mapStateToProps = (state: AppState) => {
  return { loginIndex: state.loginIndex };
}
let mapDispatchToProps = (dispatch: any) => {
  return { toggleLoginView: (loginIndex: number) => dispatch(toggleLoginView(loginIndex)) };
}
export interface AppState {
  loggedIn: boolean,
  loginIndex: number
}

var FirstScreen = connect(mapStateToProps, mapDispatchToProps)(IntialScreen);
export default FirstScreen;
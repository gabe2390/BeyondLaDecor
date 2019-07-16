import React, { Dispatch } from 'react';
import { StyleSheet, Text, View } from 'react-native';
import { Home } from './home.component';
import { Login } from './login.component';
import { Registration } from './registration.component';
import { connect } from 'react-redux';
import { toggleLoginView } from '../state-management/actions/root-actions.action';
import { Container, Content, Button } from 'native-base';
import Navigation from '../navigation/root-navigator';

export class IntialScreen extends React.Component<any, AppState> {
  private buttons: string[] = ["Log In", "Register"];

  constructor(props: any) {
    super(props);
    this.getFirstView = this.getFirstView.bind(this);
  }

  render() {
    return (
      <Container style={this.styles.container}>
        {this.getFirstView()}
      </Container>
    );
  }

  toggleLoginView = () => {
    this.props.toggleLoginView(this.props.loginIndex == 0 ? 1 : 0);
  }

  getFirstView() {
    var text = this.buttons[this.props.loginIndex];
    var component = text === "Register" ?
      <Login></Login> :
      <Registration></Registration>
    return this.props.loggedIn ? <Navigation /> :
      <Content>
        {component}
        <Button onPress={this.toggleLoginView} hasText transparent>
          <Text>Or {text}</Text>
        </Button>
      </Content>;
  }

  styles = StyleSheet.create({
    container: {
      backgroundColor: '#ff1',
    }
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
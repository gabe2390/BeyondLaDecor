import React from 'react';
import { Container, Left, Button, Icon, Title, Body, Right, Header } from 'native-base'

export class LaDecorHeader extends React.Component<any, any> {
  constructor(props: any) {
    super(props);
    this.openDrawer = this.openDrawer.bind(this);
  }
  
  render() {
    return (
      <Header>
        <Left>
          <Button
            transparent 
            onPress={this.openDrawer}>
            <Icon name="menu" />
          </Button>
        </Left>
        <Body>
          <Title>HomeScreen</Title>
        </Body>
        <Right />
      </Header>
    );
  }

  openDrawer() {
    console.log(this.props);
    this.props.navigation.navigate("DrawerOpen")
  }
}
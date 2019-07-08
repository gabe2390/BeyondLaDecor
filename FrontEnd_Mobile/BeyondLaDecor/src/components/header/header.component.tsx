import React from 'react';
import { Container, Left, Button, Icon, Title, Body, Right, Header } from 'native-base'
export class LaDecorHeader extends React.Component {
  constructor(props: any) {
    super(props);
  }
  render() {
    return (
      <Container>
        <Header>
          <Left>
            <Button transparent>
              <Icon name='menu' />
            </Button>
          </Left>
          <Body>
            <Title>Header</Title>
          </Body>
          <Right />
        </Header>
      </Container >
    );
  }
}
import React, { Props } from 'react';
import { StyleSheet, Text, View } from 'react-native';
import { AddType } from '../../constants/constants';
import { Container } from 'native-base';
import { AddClient } from './add-workflows/add-client.component';
import { AddEvent } from './add-workflows/add-event.component';
import { AddPackage } from './add-workflows/add-package.component';
import { AddProduct } from './add-workflows/add-product.component';
import { AddService } from './add-workflows/add-service.component';
export interface AddWorkflowProps {
  addType: AddType
}
export class AddWorkflow extends React.Component<AddWorkflowProps, {}> {
  constructor(props: AddWorkflowProps) {
    super(props);
  }
  render() {
    return (
      <Container>
        {this.getWorkFlow()}
      </Container>
    );
  }

  getWorkFlow () {
    switch (this.props.addType) {
      case 'CLIENT': return <AddClient></AddClient>
      case 'EVENT': return <AddEvent></AddEvent>
      case 'PACKAGE': return <AddPackage></AddPackage>
      case 'PRODUCT': return <AddProduct></AddProduct>
      case 'SERVICE': return <AddService></AddService>
    }
  }
}
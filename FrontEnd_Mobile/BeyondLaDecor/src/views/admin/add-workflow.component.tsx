import React, { Props } from 'react';
import { StyleSheet, Text, View } from 'react-native';
import { AddType } from '../../constants/constants';
export interface AddWorkflowProps {
  addType: AddType
}
export class AddWorkflow extends React.Component<AddWorkflowProps, {}> {
  constructor(props: AddWorkflowProps) {
    super(props);
  }
  render() {
    return (
      <View>
        {this.getWorkFlow()}
      </View>
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
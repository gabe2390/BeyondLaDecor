import React, { Props } from 'react';
import { StyleSheet, Text, View, Picker, TextInput, PickerItem } from 'react-native';
import { Package } from '../../../models/package.model';
import { EventType } from '../../../models/event-type.model';
import { Service } from '../../../models/service.model';
import { Product } from '../../../models/product.model';
import { Icon, Input } from 'react-native-elements';

export interface AddPackageState {
    attemptingAddPackage: boolean,
    selectedEventTypeId: number,
    packages: Package[],
    services: Service[]
}

export class AddPackage extends React.Component<{}, {}> {
    private eventTypes: EventType[];
    private services: Service[];
    private products: Product[];
    private selectedEventTypeId: number;

    constructor(props: {}) {
        super(props);
        this.eventTypes = [], this.services = [], this.products = [];
        this.selectedEventTypeId = 0;
    }

    render() {
        return (
            <View>
                <Input placeholder='Package Name' leftIcon={<Icon name='user' size={24} color='black' />} />
                <Text>Select Included Event Types</Text>
                <Picker
                    selectedValue={this.selectedEventTypeId}
                    style={{ height: 50, width: 100 }}
                    onValueChange={(itemValue, itemIndex) =>
                        this.setState({ language: itemValue })
                    }>
                    {this.getPickerItems()}
                </Picker>
                <Text>Select Included Services</Text>
                <Text>Select Included Products</Text>
            </View >
        );
    }

    getPickerItems(): JSX.Element[] {
        return this.eventTypes.map(function (eventType) {
            return <PickerItem label={eventType.Name} value={eventType.EventTypeId} />;
        });
    }
    selectEventType() {

    }
}
import React, { Dispatch } from 'react';
import { Container, Text, Header, Tabs, TabHeading, Tab, Icon } from 'native-base';
import { PackageServiceView } from './package-service-view.component';
import { InventorySearchView } from './inventory-search-view';
import EventsView from './event-view.component';

export class Dashboard extends React.Component<any, any>{
    constructor(props: any) {
        super(props);
    }

    render() {
        return (
            <Container>
                <Header hasTabs />
                <Tabs>
                    <Tab heading={<TabHeading><Text>Events</Text></TabHeading>}>
                        <EventsView />
                    </Tab>
                    <Tab heading={<TabHeading><Text>Packages and Services</Text></TabHeading>}>
                        <PackageServiceView/>
                    </Tab>
                    <Tab heading={<TabHeading><Text>Inventory Search</Text></TabHeading>}>
                        <InventorySearchView />
                    </Tab>
                </Tabs>
            </Container>
        )
    };
}
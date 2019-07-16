import React from "react";
import { AppRegistry, StatusBar } from "react-native";
import { Container, Content, Text, List, ListItem, Image } from "native-base";


const routes = ["Home", "Login", "AddWorkflow"];

export default class SideBar extends React.Component<any, any> {
    constructor(props: any) {
        super(props);
    }
    render() {
        return (
            <Container>
                <Content>
                    <List
                        dataArray={routes}
                        renderRow={data => {
                            return (
                                <ListItem
                                    button
                                    onPress={() => this.props.navigation.navigate(data)}>
                                    <Text>{data}</Text>
                                </ListItem>
                            );
                        }}
                    />
                </Content>
            </Container>
        );
    }
}

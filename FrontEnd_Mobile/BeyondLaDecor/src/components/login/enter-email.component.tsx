import { View, Text, TextInput } from "react-native";
import { Props } from "react";
import { Container } from "native-base";

export default function EnterPassword(props : Props<string>) {
    return (
        <Container>
            <Text>Password</Text>
            <TextInput secureTextEntry={true}/>
        </Container>
    )
}
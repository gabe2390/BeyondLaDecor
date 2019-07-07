import { View, Text, TextInput } from "react-native";
import { Props } from "react";

export default function EnterPassword(props : Props<string>) {
    return (
        <View>
            <Text>Password</Text>
            <TextInput secureTextEntry={true}/>
        </View>
    )
}
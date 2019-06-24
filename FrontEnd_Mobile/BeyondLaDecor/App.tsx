import React from 'react';
import { StyleSheet, Text, View } from 'react-native';
import Home from './src/views/home.component'
export default function App() {
  return (
    <View style={styles.container}>
      <Home></Home>      
      <Text>Open up App.tsx to start working on your app!</Text>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});

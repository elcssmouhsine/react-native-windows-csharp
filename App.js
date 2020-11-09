/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * @format
 * @flow strict-local
 */

import React from 'react';
import {
  SafeAreaView,
  NativeModules,
  Text,
  View,
  requireNativeComponent
} from 'react-native';
console.log(NativeModules)
const CamUserControl = requireNativeComponent('CamUserControl');
const App: () => React$Node = () => {
  return (
    <>
      <SafeAreaView>
        <View style={{ backgroundColor: 'red', padding: 50 }}>
        <Text>ttextextetxtextetxtetxtetxet</Text>
        <CamUserControl label="CustomUserControl!" color='#333333' backgroundColor='#006666' />
        </View>
      </SafeAreaView>
    </>
  );
};

export default App;

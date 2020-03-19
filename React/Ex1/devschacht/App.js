import React from 'react';
import { StyleSheet, Text, View } from 'react-native';
import {Container, Content} from "native-base";
import { Footer, FooterTab, Button} from 'native-base';
import {createStore} from 'redux';
import reducers from './reducers';
import {Provider} from 'react-redux';

const initialState = {};
const store = createStore(reducers, initialState)

const App = () => (
    <Provider store={store}>
    <Container>
        <Content>
            <View>
                <Text style={styles.container}>
                    Lorem ipsum...
                </Text>
            </View>
        </Content>
        <AppFooter/>
    </Container>
    </Provider>
);
export default App;


const AppFooter = () => (
    <View>
    <Footer>
        <FooterTab>
                <Button style={styles.butt} active>
                    <Text>Кнопка</Text>
                </Button>
                <Button style={styles.butt}>
                    <Text>Вторая</Text>
                </Button>
        </FooterTab>
    </Footer>
    </View>
);
const styles = StyleSheet.create({
    container: {
        color: 'black',
        fontWeight: 'bold',
        fontSize: 30,
        textAlign: 'center',
        margin: 35,
    },
    butt: {
        backgroundColor: 'white',
        borderRadius:1,
        borderWidth:0.5,
        borderColor: 'silver',
    },

});

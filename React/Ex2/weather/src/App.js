import React, {Component} from 'react';
import logo from './logo.svg';
import './App.css';

const PLACES = [
    {name:}
]

function App() {
  return (
    <div className="App">
        <WeatherDisplay zip={"12345"}/>
    </div>
  );
}
class WeatherDisplay extends Component{
    render(){
        return(
            <h1>Displaying weather for city {this.props.zip}</h1>
        );
    }
}

export default App;

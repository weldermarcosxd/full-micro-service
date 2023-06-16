import logo from './logo.svg';
import './App.css';
import { Component } from 'react';

class App extends Component{

    state = {
        nome: 'Welder Marcos',
        clicks: 0
    };

    tratarClickNoParagrafo = () => {
      const { clicks } = this.state;
      this.setState({clicks: clicks + 1});
    }

    tratarClickNoLink = (event) => {
      event.preventDefault();
      const { clicks } = this.state;
      this.setState({clicks: clicks - 1});
    }

    render() {
      const { nome, clicks } = this.state;

      return (
        <div className="App">
          <header className="App-header">
            <img src={logo} className="App-logo" alt="logo" />
            <p onClick={this.tratarClickNoParagrafo}>
              {nome} {clicks}
            </p>
            <a
              onClick={this.tratarClickNoLink}
              className="App-link"
              href="https://reactjs.org"
              target="_blank"
              rel="noopener noreferrer"
            >
              Learn React
            </a>
          </header>
        </div>
      );
  }
}

export default App;

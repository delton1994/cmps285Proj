import React, {Component} from 'react';
import {BrowserRouter} from 'react-router-dom';

import './App.css';
import {authenticate} from './helpers/auth';
import Login from './features/authentication/Login';
import MainLayout from './features/layout/MainLayout';

class App extends Component {
  state = {
    currentUser: undefined,
  };

  login = credentials => {
    authenticate(credentials.username, credentials.password).then(response => {
      console.log(response);

      if (response.token) {
        this.setState({
          currentUser: {name: response.firstName},
        });
      }
    });
  };

  logout = () => {
    // var result = await api.put('logout', {});  //TODO: Implement this

    this.setState({currentUser: undefined});
  };

  render() {
    return (
      <BrowserRouter>
        <div className="app-container">
          {this.state.currentUser ? (
            <MainLayout
              currentUser={this.state.currentUser}
              handleLogout={this.logout}
            />
          ) : (
            <Login handleLogin={this.login} />
          )}
        </div>
      </BrowserRouter>
    );
  }
}

export default App;

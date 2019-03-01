import React, {Component} from 'react';

import './Login.css';
import Input from '../layout/Input';

class Login extends Component {
  state = {
    password: 'test', // TODO: Set default to empty string once hooked to API
    username: 'bdrizzle', // TODO: Set default to empty string once hooked to API
  };

  handleInputChanged = (value, valueName) => {
    this.setState({[valueName]: value});
  };

  handleSubmit = e => {
    e.preventDefault();

    this.props.handleLogin({
      password: this.state.password,
      username: this.state.username,
    });
  };

  render() {
    return (
      <div className="page-container">
        <div className="form-container">
          <h4 className="header">Log In</h4>
          <form className="login-form" onSubmit={this.handleSubmit}>
            <Input
              autoFocus={true}
              id="username"
              label="Username"
              handleOnChange={e =>
                this.handleInputChanged(e.target.value, 'username')
              }
              type="text"
              value={this.state.username}
            />
            <Input
              id="password"
              label="Password"
              handleOnChange={e =>
                this.handleInputChanged(e.target.value, 'password')
              }
              type="password"
              value={this.state.password}
            />
            <button
              className="login-button"
              disabled={!this.state.username || !this.state.password}
            >
              Log In
            </button>
          </form>
        </div>
      </div>
    );
  }
}

export default Login;

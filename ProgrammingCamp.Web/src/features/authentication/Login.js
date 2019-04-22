import React, {Component} from 'react';
import apiHelper from '../../helpers/api';
import './Login.css';
import Input from '../layout/Input';

class Login extends Component {
  state = {
    password: '', // TODO: Set default to empty string once hooked to API
    username: '', // TODO: Set default to empty string once hooked to API
    firstName: '',
    lastName: '',
    email: '',
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
handleSignUp = () => {
    var modal = document.getElementById('Modal')
    var form = document.getElementById('form')
    modal.style.display = 'block'
    form.style.visibility = 'hidden'

}

handleSignUpSubmit = e => {
  e.preventDefault();
  var newUser = 
  this.setState({
    password: this.props.password,
    username: this.props.username,
    firstName: this.props.firstName,
    lastName: this.props.lastName,
    email: this.props.email,
  })

  const response= apiHelper.post('/Users',{newUser})
  if(response){
    console.log(response)
  };
  
  

}
handleClose = () => {
  var modal = document.getElementById('Modal')
  var form = document.getElementById('form')
    modal.style.display = 'none'
    form.style.visibility = 'visible' 
}

  render() {
    return (
      <div className="page-container">
        <div id = 'form' className="form-container">
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
            <button
             className="signUp-button"
             onClick={this.handleSignUp}>
              Sign Up Here!
            </button>
          </form>
            {/* <button
             className="signUp-button"
             onClick={this.handleSignUp}>
              Sign Up Here!
            </button> */}
        </div>

        <div id="Modal" class="modal">
            <div class="modal-content">
              <span class="close" 
              onClick={this.handleClose}>
              &times;
              </span>
              <form className = 'signUp-Form' onSubmit = {this.handleSignUpSubmit}>
                <Input
                id = 'firstName'
                label = 'First Name'
                handleOnChange={e => 
                  this.handleInputChanged(e.target.value, 'firstName')
                }
                type='text'
                value={this.state.firstName}
                />
                <Input
                id = 'lastName'
                label = 'Last Name'
                handleOnChange={e => 
                  this.handleInputChanged(e.target.value, 'lastName')
                }
                type='text'
                value={this.state.lastName}         
                />
                <Input
                id = 'email'
                label = 'Email'
                handleOnChange={e => 
                  this.handleInputChanged(e.target.value, 'email')
                }
                type='text'
                value={this.state.email}         
                />
                <Input
                id = 'username'
                label = 'Username'
                handleOnChange={e => 
                  this.handleInputChanged(e.target.value, 'username')
                }
                type='text'
                value={this.state.username}         
                />        
                <Input
                id = 'password'
                label = 'Password'
                handleOnChange={e => 
                  this.handleInputChanged(e.target.value, 'password')
                }
                type='password'
                value={this.state.password}         
                />
                <button
                className='submit-button'
                onClick = {this.handleSignUpSubmit && this.handleClose}
                
                >
                Submit
                </button>
              </form>
            </div>
        </div>
      </div>
    );
  }
}

export default Login;

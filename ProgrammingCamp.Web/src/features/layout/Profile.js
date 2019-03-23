import React, {Component} from 'react';
import Page from './Page';
import apiHelper from '../../helpers/api'

class Profile extends Component {
  handleGetUsers = async() => {
    const response = await apiHelper.get('Users')
    if(response){
      console.log(response)
    }
  }
  render() {
    return (
      <Page header="User Profile">
        <div>
        Welcome to your profile.
        <br/>
          <button onClick={this.handleGetUsers}>Get Users</button>
          
        </div>
      </Page>
    );
  }
}

export default Profile;

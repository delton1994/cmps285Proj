import React, {Component} from 'react';
import Page from '../layout/Page';
import apiHelper from '../../helpers/api';

class UsersIndexScreen extends Component {
  handleGetUsers = async() => {
    const response = await apiHelper.get('Users/')
    if(response){
      console.log(response)
    }
  }

  render() {
    return (
      <Page header="Study Almost">
        <div>Add Users here.
          <button onClick={this.handleGetUsers}>Get Users</button>
        </div>
      </Page>
    );
  }
}

export default UsersIndexScreen;

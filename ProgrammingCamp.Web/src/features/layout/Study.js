import React, {Component} from 'react';
import Page from './Page';
import apiHelper from '../../helpers/api';

class Study extends Component {
  handleGetUsers = async() => {
    const response = await apiHelper.get('Users')
    if(response){
      console.log(response)
    }
  }
  render() {
    return (
      <Page header="Study Almost">
        <div>
        if I knew how, I would let you study.
        <button onClick={this.handleGetUsers}>Get Users</button>
        </div>
      </Page>
    );
  }
}

export default Study;

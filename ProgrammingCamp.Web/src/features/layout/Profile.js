import React, {Component} from 'react';
import Page from './Page';
import './Profile.css'
import apiHelper from '../../helpers/api'

class Profile extends Component {
  handleGetUsers = async() => {
    const response = await apiHelper.get('Users')
    if(response){
      var user = JSON.stringify(response,['id','username'])
      console.log(user)
    }
  }
  render() {
    return (
      <Page>
      <div className = "wrapper">
        <div className = "information">
        <p>ZacBurDelNik</p>
        <p>Let's code</p>
        <p>aaa@selu.edu</p>
          {/* <button onClick={this.handleGetUsers}>Get Users</button> */}
         </div>
        <div className = "score">
     <h1>Average Score :</h1>

        <h1 className = "points2">80%</h1>
        </div>
     </div>
     <div className ="expert">
     <h1>Best Understood Language :</h1>
     <h1 className = "points2"> JavaScript</h1>
     </div>

    
      </Page>
    );
  }
}

export default Profile;

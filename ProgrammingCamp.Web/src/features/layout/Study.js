import React, {Component} from 'react';
import Page from './Page';
<<<<<<< Updated upstream
import apiHelper from '../../helpers/api';
=======
import './Study.css'
import {NavLink} from 'react-router-dom';
import {ROUTES} from '../../constants';
>>>>>>> Stashed changes

class Study extends Component {
  handleGetUsers = async() => {
    const response = await apiHelper.get('Users')
    if(response){
      console.log(response)
    }
  }
  render() {
    return (
<<<<<<< Updated upstream
      <Page header="Study Almost">
        <div>
        if I knew how, I would let you study.
        <button onClick={this.handleGetUsers}>Get Users</button>
=======
      <Page header="Languages">
        <div className = "column left">
        <NavLink
          className="link"
          exact
          activeClassName="selected"
          to={ROUTES.JavaScript}
        >
        <p className = "text">JavaScript</p>
        </NavLink>

        <NavLink
          className="link"
          activeClassName="selected"
          to={ROUTES.CSharp}
        >
         <p className = "text">C#</p>
        </NavLink>

        <NavLink
          className="link"
          activeClassName="selected"
          to={ROUTES.HTML}
        >
         <p className = "text">HTML</p>
        </NavLink>

        <NavLink
          className="link"
          activeClassName="selected"
          to={ROUTES.Java}
        >
         <p className = "text">Java</p>
        </NavLink>
        </div>
        
        <div className = "column right">
        <p className = "text">
        </p>
>>>>>>> Stashed changes
        </div>
        
      </Page>
    );
  }
}

export default Study;

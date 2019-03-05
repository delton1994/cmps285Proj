import React from 'react';
import {NavLink} from 'react-router-dom';

import './NavBar.css';
import Movie from './Movie';
import {ROUTES} from '../../constants';

class NavBar extends React.Component {
  render() {
    return (
      <nav className="navigation-container">
        <NavLink
          className="navigation-link"
          exact
          activeClassName="selected"
          to={ROUTES.dashboard}
        >
          Home
        </NavLink>

        <NavLink
          className="navigation-link"
          activeClassName="selected"
          to={ROUTES.Study}
        >
          Study
        </NavLink>
        
        <NavLink
          className='navigation-link'
          exact
          activeClassName='selected'
          to={ROUTES.Profile}>
          {this.props.currentUser.name}'s Profile
        </NavLink> 

        <div className="settings-container">
          {/* <Movie /> Please include this ⚡*/}
          <span className="greeting">{this.props.currentUser.name}'s Profile</span>
          <button className="logout-button" onClick={this.props.handleLogout}>
            Logout
          </button>
        </div>
      </nav>
    );
  }
}

export default NavBar;

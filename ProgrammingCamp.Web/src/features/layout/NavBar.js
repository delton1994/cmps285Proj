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
          to={ROUTES.Results}
        >
          Results
        </NavLink>
        

        <div className="settings-container">
          <NavLink
            className='navigation-link'
            exact
            activeClassName='selected'
            to={ROUTES.Profile}>
            Your Profile
          </NavLink> 
          {/* <Movie /> Please include this ⚡*/}
          <button className="logout-button" onClick={this.props.handleLogout}>
            Logout
          </button>
        </div>
      </nav>
    );
  }
}

export default NavBar;

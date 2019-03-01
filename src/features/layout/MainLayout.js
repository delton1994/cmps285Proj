import React, {Component, Fragment} from 'react';
import {Route, Switch} from 'react-router-dom';

import './MainLayout.css';
import NavBar from './NavBar';
import Page from './Page';
import {ROUTES} from '../../constants';
import Study from './Study';
import Profile from './Profile';

class MainLayout extends Component {
  render() {
    return (
      <Fragment>
        <NavBar
          currentUser={this.props.currentUser}
          handleLogout={this.props.handleLogout}
        />
        <div className="main-content-container">
          <Switch>
            <Route
              component={() => <Page header="Home" />}
              exact
              path={ROUTES.dashboard}
            />
            <Route component={() => <Study />} path={ROUTES.Study} />
            <Route component={() => <Profile header='Profile' />}
              exact
              path={ROUTES.Profile} 
            />
          </Switch>
        </div>
      </Fragment>
    );
  }
}

export default MainLayout;

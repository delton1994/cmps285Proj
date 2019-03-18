import React, {Component, Fragment} from 'react';
import {Route, Switch} from 'react-router-dom';

import './MainLayout.css';
import NavBar from './NavBar';
import Page from './Page';
import {ROUTES} from '../../constants';
import Study from './Study';
import Profile from './Profile';
import JavaScript from './JavaScript';
import CSharp from './CSharp';
import HTML from './HTML';
import Java from './Java';

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
            <Route component={() => <JavaScript />} path={ROUTES.JavaScript}/>
            <Route component={() => <CSharp />} path={ROUTES.CSharp}/>
            <Route component={() => <HTML />} path={ROUTES.HTMl}/>
            <Route component={() => <Java />} path={ROUTES.Java}/>
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

import React, {Component} from 'react';
import Page from './Page';
import {NavLink} from 'react-router-dom';
import {ROUTES} from '../../constants';
import './Study.css'
import {Route, Switch} from 'react-router-dom';
import HTML from './Languages/HTML'
import Java from './Languages/Java'
import JavaScript from './Languages/JavaScript'
import CSharp from './Languages/CSharp'

class Study extends Component { 
  render() {
    return (
      <Page header="Almost Studying..">
        <div className='main-div'>
          <div className='left-box'>
           <nav className='left-nav'>
            <ul className='navList'>
            <NavLink
              className='language-link'
              exact
              activeClassName='selected'
              to={ROUTES.HTML}
            >
              HTML
            </NavLink>

            <NavLink
              className='language-link'
              exact
              activeClassName='selected'
              to={ROUTES.Java}
            >
              Java
            </NavLink>

            <NavLink
              className='language-link'
              exact
              activeClassName='selected'
              to={ROUTES.JavaScript}
            >
              JavaScript
            </NavLink>

            <NavLink
              className='language-link'
              exact
              activeClassName='selected'
              to={ROUTES.CSharp}
            >
              C#
            </NavLink>
            </ul>
          </nav>
          </div>
          <div className='center-card'>
            <Switch>
              <Route component={() => <HTML />} exact path={ROUTES.HTML} />
              {/* <Route component={() => <Java />} exact path={ROUTES.Java} />
              <Route component={() => <JavaScript />} exact path={ROUTES.JavaScrips} />
              <Route component={() => <CSharp />} exact path={ROUTES.CSharp} /> */}
            </Switch>
            This is a test card...
          </div>
          <div className='right-box'>
            Insert something interesting here..
          </div>
        </div>
      </Page>
    );
  }
}

export default Study;

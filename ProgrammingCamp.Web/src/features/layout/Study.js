import React, {Component} from 'react';
import Page from './Page';
import {NavLink} from 'react-router-dom';
import {ROUTES} from '../../constants';
import './Study.css'

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
          This is a test card...
          </div>
          <div className='right-box'>
            Hello
          </div>
        </div>
      </Page>
    );
  }
}

export default Study;

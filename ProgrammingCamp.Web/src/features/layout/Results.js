import React, {Component} from 'react'; 
import Page from './Page'; 
import {ROUTES} from '../../constants'; 
import {NavLink} from 'react-router-dom'; 
import './Results.css' 
 
class Results extends Component { 
  render(){ 
    return ( 
      <Page header="Your Results"> 
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
          Previous Quizzes:
          <br/>
          HTML: 85% 
          </div> 
          <div className='right-box'> 
            Hello 
          </div> 
        </div> 
      </Page> 
    ); 
  } 
} 
 
export default Results;
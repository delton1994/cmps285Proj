import React, {Component} from 'react';
import Page from './Page'; 
import {ROUTES} from '../../constants'; 
import {NavLink} from 'react-router-dom'; 
import './Home.css'



class Home extends Component {
  render(){
    return (
      <Page header="The Home Page...">
        <div className='info-title'>
        Why The Programmer Camp?
        </div>
        <div className='info-text'>
        The Programming Camp is design to help developers learn syntax to different languages using flashcards.
        This website has a Study tab alone with a Quiz that follows each study session while your results are being tracked in the Results tab.


        </div>
        <div className='client'>
        About the Client:
        </div>

        <div className='client-info'>

        Jay Tulk is a software developer II for Turner Indistries located in Baton Rouge, Louisiana. 
        He is married with two kids and enjoys playing the guitar as a hobby.
        </div>
      </Page>
      

    ); 
  }  
}

export default Home;

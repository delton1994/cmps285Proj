import React, {Component} from 'react';
import Page from './Page'; 
import {ROUTES} from '../../constants'; 
import {NavLink} from 'react-router-dom'; 
import './Home.css'



class Home extends Component {
  render(){
    return (
      <Page header="Where Learning Begins...">
        <div className='info-title'>
        Why The Programmer Camp?
        </div>
        <div className='info-text'>
        The Programming Camp is design to help developers learn syntax to different languages using flashcards.
        Users will find a Study tab alone with a Quiz that follows each study session while your quiz results are being tracked in the Results tab.


        </div>
        <div className='client2'>
        About the Client
        </div>
        <div className='tree'>
        *
        </div>

        <div className='client-info'>

        Jay Tulk is a software developer II for Turner Indistries located in Baton Rouge, Louisiana. 
        He is married with two kids and enjoys playing the guitar as a hobby.
        </div>
        <div className='proj-title'>
        The Programming Camp
        </div>
        <div className='proj-slogan'>
        When you or your friends need a refesher on five of the biggest programming languages to help study, practice Quizzes, or just play around, The Programming Camp is the place to be! 
        Learning has never been so easy and our goal is to make it fun for users but also a way of remembering what you stuided.
        The flashcards will ask a question and all users have to do is press on the card to reveal the answer. Remember to track your progress, head to the Results tab in the top left corner!
        </div>
        <div class="camp-image"></div>
        <div class="camp-image2"></div>
        <div class="camp-image3"></div>
        
      </Page>
      

    ); 
  }  
}

export default Home;

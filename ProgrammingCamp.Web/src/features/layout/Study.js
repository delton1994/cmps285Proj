import React, {Component} from 'react';
import Page from './Page';
import './Study.css'
import apiHelper from '../../helpers/api';

var myJSON

class Study extends Component {  
  handleGetQuestions = async() => {
    const response = await apiHelper.get('api/Question?languageId=' + 2)
    if(response){
      this.state = {response: null} 
      JSON.stringify(response)
      console.log(response)
    }
  }


  render() {
  const element = document.getElementsByClassName('center-card')
    return (
      <Page header="Almost Studying..">
        <div className='main-div'>
          <div className='left-box'>
           <nav className='left-nav'>
            <ul className='navList'>
            <button
              className='language-link'
              onClick={this.handleGetQuestions}
              
            >
              HTML
            </button>

            <button
              className='language-link'
            >
              Java
            </button>

            <button
              className='language-link'

            >
              JavaScript
            </button>

            <button
              className='language-link'
            >
              C#
            </button>
            </ul>
          </nav>
          </div>
          <div className='center-card'>
            Info goes here.
          </div>
          <div className='right-box'>
           
          </div>
        </div>
      </Page>
      
    );
  }
}

export default Study;

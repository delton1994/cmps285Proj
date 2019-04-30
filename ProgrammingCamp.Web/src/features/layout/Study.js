import React, {Component} from 'react';
import Page from './Page';
import './Study.css'
import apiHelper from '../../helpers/api';

const baseUrl = process.env.REACT_APP_BASE_API_URL;

class Study extends Component {  
  var = 2
  counter = 0
  questionVar = 0

  constructor(){
    super();
      this.state = {
        Question: {question: '', answer: ''}
      }
    this.getQuestions = this.getQuestions.bind(this);    
  }
   componentWillMount(){
     this.getQuestions();
     this.getChoices();
   }

 getQuestions(url, params){
   fetch(`${baseUrl}${'api/Question?languageId=' + this.var}`)
   .then(response => {
     if(response.ok) return response.json();
     console.log(response)
   })
   .then(data => {
     this.setState({question: data[this.questionVar].name })
   })
   .catch(error => {
     console.log(error);
   })
 }

 getChoices(url, params){
  fetch(`${baseUrl}${'api/Question?languageId=' + this.var}`)
  .then(response => {
    if(response.ok) return response.json();
    console.log(response)
  })
  .then(data => {
   console.log(data)
      this.setState({answer: data[this.questionVar].choices[0].name })
  })
  .catch(error => {
    console.log(error);
  })
}

 doAll(id){
   this.var = id
   this.getQuestions()
   this.getChoices()

   if(this.counter !=0 && this.counter % 2 != 0){
     this.counter--
     this.getQuestions()
     this.getChoices()
     this.switchVisible()
   }
 }

 doAllChoices(){
  this.counter++
  if(this.counter > 3){
    this.questionVar = 0
    this.counter = 0
    this.getQuestions()
    this.getChoices()
  }
  else if(this.counter % 2 == 0){
    this.questionVar = this.counter / 2
    this.getQuestions()
    this.getChoices()
  }
  this.switchVisible()
 }

switchVisible() {
 
      if (document.getElementById('center-card-question').style.display == 'none') {
          document.getElementById('center-card-question').style.display = 'inline-block';
          document.getElementById('center-card-answer').style.display = 'none';
      }
      else {
          document.getElementById('center-card-question').style.display = 'none';
          document.getElementById('center-card-answer').style.display = 'inline-block';
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
              onClick={() => this.doAll(2)}     
              autoFocus      
            >
              HTML
            </button>

            <button
              className='language-link'
              onClick={() => this.doAll(3)}
            >
              Java
            </button>

            <button
              className='language-link'
              onClick={() => this.doAll(1)}
            >
              JavaScript
            </button>

            <button
              className='language-link'
              onClick={() => this.doAll(4)}
            >
              C#
            </button>
            </ul>
          </nav>
          </div>
          <div className='center-card-question'
          id='center-card-question'
          onClick={() => this.doAllChoices()}
          >
            {`${this.state.question}`}
          </div>
          <div className='center-card-answer'
          id='center-card-answer'
          onClick={() => this.doAllChoices()}
          >
            {`${this.state.answer}`}
          </div>
          <div className='right-box'>
           
          </div>
        </div>
      </Page>
      
    );
  }
}

export default Study;

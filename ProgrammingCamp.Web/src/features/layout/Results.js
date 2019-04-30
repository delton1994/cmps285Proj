import React, {Component} from 'react'; 
import Page from './Page'; 
import apiHelper from '../../helpers/api';  
import './Results.css' 

class Results extends Component { 
state={
  currentUser: localStorage.getItem('Id'),
  userResult: [],
  languageId:2
};

handleGetPastQuiz = async() => {
  const response = await apiHelper.get('api/UserResults/GetAll/'+ this.state.currentUser)
  if(response){
    const userResult = JSON.stringify(response).split(",",7)
    this.setState({userResult: userResult})
  
  }
  const a = this.state.userResult.splice()
  a[0] = this.state.userResult[0].replace(/[{["]/g, '');
  a[1] = this.state.userResult[1].replace(/["]/g, '');
  a[2] = this.state.userResult[2].replace(/["]/g, '');
  a[3] = this.state.userResult[3].replace(/["]/g, '');
  a[4] = this.state.userResult[4].replace(/["]/g, '');
  a[5] = this.state.userResult[5].replace(/["]/g, '');
  a[6] = this.state.userResult[6].replace(/[}/\]"]/g, '');
  this.setState({userResult: a})

}
//figure out how to assign language id to button
 
  handleGetUserResult = async() => {
    const response = await apiHelper.get('api/UserResults/'+  this.state.currentUser + "/"+ this.state.languageId)
    if(response){
      const userResult = JSON.stringify(response).split(",",7)
      
      this.setState({userResult: userResult})
    
    }
    const a = this.state.userResult.splice()
    a[0] = this.state.userResult[0].replace(/[{["]/g, '');
    a[1] = this.state.userResult[1].replace(/["]/g, '');
    a[2] = this.state.userResult[2].replace(/["]/g, '');
    a[3] = this.state.userResult[3].replace(/["]/g, '');
    a[4] = this.state.userResult[4].replace(/["]/g, '');
    a[5] = this.state.userResult[5].replace(/["]/g, '');
    a[6] = this.state.userResult[6].replace(/[}/\]"]/g, '');
    this.setState({userResult: a})
    //idea to try: i could use .replace to replace the words of languageid
    // and get the value to compare or assign to a button
    //
    //current workflow: figure out how to set the language id
  }

  render(){ 
    return ( 
      <Page header="Your Results"> 
        <div className='main-div'> 
          <div className='left-box'> 
           <nav className='left-nav'> 
            <ul className='navList'> 
            <button 
              className='language-link'  
              onClick = {this.handleGetUserResult}
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
          Previous Quizzes:
          <br/>
          <div>{this.state.userResult[3]}</div>
          <div>{this.state.userResult[5]}</div>
          <div>{this.state.userResult[6]}</div>
          </div> 
          <div className='right-box'>
          Previous Quiz
          </div> 
        </div> 
      </Page> 
    ); 
  } 
} 
 
export default Results;
import React, {Component} from 'react';
import Page from './Page';
import apiHelper from '../../helpers/api';
import './Results.css';

class Results extends Component {
  state = {
    currentUser: localStorage.getItem('Id'),
    currentQuiz: undefined,
    languages: [],
    userQuizzes: [],
  };

  async componentWillMount() {
    const language = await apiHelper.get(`Language`);
    if (language) {
      this.setState({languages: language});
    }
  }

  handleGetUserResult = async languageId => {
    const response = await apiHelper.get(
      `api/UserResults/${this.state.currentUser}/${languageId}`
    );
    if (response) {
      console.log(response);
      this.setState({
        currentQuiz: response[0],
        userQuizzes: response,
        response,
      });
      console.log(this.state.userQuizzes);
      console.log(this.state.currentQuiz);
    }
  };

  pastQuiz = async id => {
    this.setState({
      currentQuiz: this.state.userQuizzes.find(x => x.id === id),
    });
    console.log(this.state.currentQuiz.result);
  };
  render() {
    return (
      <Page header="Your Results">
        <div className="left-text">Languages</div>
        <div className="right-text">Quizzes</div>
        <div className="main-div">
          <div className="left-box">
            <nav className="left-nav">
              <ul className="navList">
                {this.state.languages.length &&
                  this.state.languages.map((language, index) => (
                    <button
                      key={index}
                      className="language-link"
                      onClick={() => this.handleGetUserResult(language.id)}
                    >
                      {language.name}
                    </button>
                  ))}
              </ul>
            </nav>
          </div>
          <div className="center-card">
            Previous Quiz:
            <br />
            {this.state.currentQuiz && (
              <React.Fragment>
                <div>
                  {this.state.currentQuiz.result
                    ? this.state.currentQuiz.result + ' %'
                    : 'Select a language please.'}
                </div>
                <div>
                  {this.state.currentQuiz.correctAnswer
                    ? this.state.currentQuiz.correctAnswer + ' Correct'
                    : ' '}
                </div>
                <div>
                  {this.state.currentQuiz.incorrectAnswer
                    ? this.state.currentQuiz.incorrectAnswer + ' Incorrect'
                    : ' '}
                </div>
              </React.Fragment>
            )}
          </div>
          <div className="right-box">
            <nav className="right-nav">
              <ul className="navList">
                {this.state.userQuizzes.length && this.state.userQuizzes
                  ? this.state.userQuizzes.map((quiz, index) => (
                      <button
                        key={index}
                        className="past-quiz"
                        // onClick={() => this.pastQuiz()}
                      >
                        Quiz {index + 1}
                      </button>
                    ))
                  : ' '}
              </ul>
            </nav>
          </div>
        </div>
      </Page>
    );
  }
}

export default Results;

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
    const languages = await apiHelper.get(`api/Language`);
    if (languages) {
      this.setState({languages: languages});
    }
  }

  handleGetUserResult = async languageId => {
    const response = apiHelper.get(
      `api/UserResults/${this.state.currentUser}/${languageId}`
    );
    if (response) {
      this.setState({
        currentQuiz: response[0],
        userQuizzes: response,
        response,
      });
      console.log(this.state.userQuizzes);
      console.log(this.state.currentQuiz);
    }
  };

  pastQuiz = async resultId => {
    this.setState({
      currentQuiz: this.state.userQuizzes.find(x => x.resultId === resultId),
    });
  };

  render() {
    return (
      <Page header="Your Results">
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
                    : 'Select a language pls.'}
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
                Past Quiz:
                <br />
                <br />
                {this.state.userQuizzes.length && this.state.userQuizzes
                  ? this.state.userQuizzes.map((quiz, index) => (
                      <button
                        key={index}
                        className="past-quiz"
                        onClick={() => this.pastQuiz(quiz.resultId)}
                      >
                        Quiz
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

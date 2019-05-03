import React, {Component} from 'react';
import Page from './Page';
import './Study.css';
import apiHelper from '../../helpers/api';

class Study extends Component {
  state = {
    questions: [],
    currentQuestions: [],
    languages: [],
    currentQuestion: undefined,
    answer: '',
  };

  async componentWillMount() {
    const result = await apiHelper.get('Language');
    if (result) {
      this.setState({languages: result});
    }
  }

  getQuestions = async languageId => {
    const questions = await apiHelper.get(`question?languageId=${languageId}`);
    if (questions) {
      this.setState({
        currentQuestions: questions,
        questions,
        currentQuestion: questions[0],
        answer: '',
      });
    }
  };

  showAnswer = () => {
    if (!this.state.currentQuestion) {
      return;
    }

    this.setState({
      answer: this.state.currentQuestion.choices.find(x => x.isAnswer).name,
    });
  };

  nextQuestion = () => {
    this.setState(
      {
        currentQuestions: this.state.currentQuestions.filter(
          x => x.name != this.state.currentQuestion.name
        ),
        currentQuestion: undefined,
      },
      () => {
        if (this.state.currentQuestions.length > 0) {
          this.setState({
            currentQuestion: this.state.currentQuestions[0],
            answer: '',
          });
        } else {
          this.setState({
            currentQuestions: this.state.questions,
            currentQuestion: this.state.questions[0],
            answer: '',
          });
        }
      }
    );
  };

  render() {
    return (
      <Page header="Almost Studying..">
        <div className="main-div">
          <div className="left-box">
            <nav className="left-nav">
              <ul className="navList">
                {this.state.languages.length &&
                  this.state.languages.map((language, index) => (
                    <button
                      key={index}
                      className="language-link"
                      onClick={() => this.getQuestions(language.id)}
                    >
                      {language.name}
                    </button>
                  ))}
              </ul>
            </nav>
          </div>
          <div
            className="center-card-question"
            onClick={() =>
              this.state.answer ? this.nextQuestion() : this.showAnswer()
            }
          >
            {this.state.currentQuestion
              ? this.state.currentQuestion.name
              : 'Select a language pls.'}
            <br />
            {this.state.answer}
          </div>

          <div className="right-box" />
        </div>
      </Page>
    );
  }
}

export default Study;

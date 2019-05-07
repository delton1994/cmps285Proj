import React, {Component} from 'react';
import Page from './Page';
import './Profile.css';
import apiHelper from '../../helpers/api';
import Results from './Results';

class Profile extends Component {
  state = {
    currentUser: localStorage.getItem('Id'),
    userInfo: {},
    userScore: '',
    Name: '',
    languageId: '',
    result: {},
    languages: [],
    language: '',
  };
  var = this.state.languageId;
  async componentWillMount() {
    const userInfo = await apiHelper.get(`Users/${this.state.currentUser}`);
    if (userInfo) {
      this.setState({userInfo: userInfo});
    }
    const Score = await apiHelper.get(
      `api/UserResults/GetAll/${this.state.currentUser}`
    );
    if (Score) {
      Score.map((result, index) => {
        result.result > this.state.userScore
          ? this.setState({userScore: result.result})
          : console.log('result.result');
      });
      Score.map((result, index) => {
        result.result >= this.state.userScore
          ? this.setState({languageId: result.languageId})
          : console.log();
      });
    }
    // console.log(this.state.userScore);
    console.log(this.state.languageId);

    const languageName = await apiHelper.get('api/Language');
    if (languageName) {
      this.setState({languages: languageName});
    }
    console.log(this.state.languages);
  }
  render() {
    return (
      <Page header={'Welcome ' + this.state.userInfo.firstName}>
        <div className="wrapper">
          <div className="information" />
          <div className="score">
            <h1>Highest Score :</h1>
            <h1 className="points2">{this.state.userScore + '%'}</h1>
          </div>
        </div>
        <div className="expert">
          <h1>Best Understood Language :</h1>
          <h1 className="points2">Java</h1>
        </div>
      </Page>
    );
  }
}

export default Profile;

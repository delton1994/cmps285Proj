import React, {Component} from 'react';
import Page from './Page';
import './Profile.css';
import apiHelper from '../../helpers/api';

class Profile extends Component {
  state = {
    currentUser: localStorage.getItem('Id'),
    userInfo: {},
    userScore: [],
    Name: '',
    result: {},
  };

  async componentWillMount() {
    const userInfo = await apiHelper.get(`Users/${this.state.currentUser}`);
    if (userInfo) {
      this.setState({userInfo: userInfo});
    }
    const Score = await apiHelper.get(
      `api/UserResults/GetAll/${this.state.currentUser}`
    );
    if (Score) {
      this.setState({
        userScore: Math.max.apply(
          Math,
          Score.map(function(score) {
            return score.result;
          })
        ),
      });
    }

    const result = await apiHelper.get(
      `api/UserResults/GetAll/${this.state.currentUser}`
    );
    if (result) {
      this.setState({
        result: result.filter(x => x.result === this.state.userScore),
      });
      if (this.state.result[0].languageId === 1) {
        this.setState({Name: 'JavaScript'});
      } else if (this.state.result[0].languageId === 2) {
        this.setState({Name: 'Html'});
      } else if (this.state.result[0].languageId === 3) {
        this.setState({Name: 'Java'});
      } else if (this.state.result[0].languageId === 4) {
        this.setState({Name: 'C#'});
      }
    }
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
          <h1 className="points2"> {this.state.Name}</h1>
        </div>
      </Page>
    );
  }
}

export default Profile;

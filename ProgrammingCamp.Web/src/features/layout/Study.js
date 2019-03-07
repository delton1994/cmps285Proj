import React, {Component} from 'react';
import Page from './Page';
import apiHelper from '../../helpers/api';

class Study extends Component { 
  render() {
    return (
      <Page header="Almost Studying..">
        <div>
          If I knew how, I would let you study.
        </div>
      </Page>
    );
  }
}

export default Study;

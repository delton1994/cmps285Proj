import React from 'react';
import YouTube from 'react-youtube';

class Movie extends React.Component {
  render() {
    const opts = {
      height: '50',
      playerVars: {
        autoplay: 1,
      },
      width: '70',
    };

    return (
      <YouTube videoId="WNCYn6iALzY" opts={opts} onReady={this._onReady} />
    );
  }

  _onReady(event) {
    // event.target.pauseVideo(); //But why would you?
  }
}

export default Movie;

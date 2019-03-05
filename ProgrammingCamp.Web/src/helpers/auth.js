import apiHelper from './api';
import {SSL_OP_NETSCAPE_DEMO_CIPHER_CHANGE_BUG} from 'constants';

export const authenticate = (username, password) => {
  return apiHelper
    .post('Users/authenticate', {username, password})
    .then(response => {
      if (response.token) {
        localStorage.setItem('token', response.token);
      }

      return Promise.resolve(response);
    });
};
//Hmmmmm, I guess this works?
//Is it supposed to do something different?

/**
 * Nah, this is about right. The real magic is here: localhost:3000
 * That should let you open up my localhost instance on your computer.
 *
 * I am going to try to start an audio connection
 *
 *
 * can u hear me?
 *
 */

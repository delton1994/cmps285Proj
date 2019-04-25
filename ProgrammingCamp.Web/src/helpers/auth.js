import apiHelper from './api';

export const authenticate = (username, password) => {
  return apiHelper
    .post('Users/authenticate', {username, password})
    .then(response => {
      if (response.token) {
        localStorage.setItem('token', response.token);
        apiHelper.setAuthHeader(`Bearer ${response.token}`);
      }

      return Promise.resolve(response);
    });
};


const defaultHeaders = {
  Accept: 'application/json',
  'Content-Type': 'application/json',
};

const baseUrl = process.env.REACT_APP_BASE_API_URL;

const apiHelper = {
  get(url, params){
    return fetch(url)
    .then(response => response.json())
    .catch(error => {
       console.log(error);
       return Promise.resolve();
     });
  },
  headers: defaultHeaders,
  setAuthHeader(value){
    this.headers = {
      ...defaultHeaders,
      authorization: value
    };
  },
  post(url, content) {
    return fetch(`${baseUrl}${url}`, {
      headers: this.headers,
      method: 'POST',
      body: JSON.stringify(content),
    })
      .then(response => response.json())
      .catch(error => {
        console.log(error);
        return Promise.resolve();
      });
  },
};

// TODO: Use and extend the real api helper once hooked up to API

export default apiHelper;

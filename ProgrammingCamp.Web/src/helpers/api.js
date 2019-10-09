const defaultHeaders = {
  Accept: 'application/json',
  'Content-Type': 'application/json',
};

const baseUrl = process.env.REACT_APP_BASE_API_URL;

const apiHelper = {
  get(url, params){
    return fetch(`${baseUrl}${url}`, {
      headers: this.headers
    })
    .then(response => response.json())
    .catch(error => {
       console.log(error);
       return Promise.resolve();
     });
  },
  headers: defaultHeaders,
  setAuthHeader(value){
    console.log('setting off header', value)
    this.headers = {
      
      ...defaultHeaders,
      Authorization: value
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

const defaultHeaders = {
  Accept: 'application/json',
  'Content-Type': 'application/json',
};

const baseUrl = process.env.REACT_APP_BASE_API_URL;

// TODO: Delete this once hooked up to API
const fakeFetch = (
  url,
  params,
  willSucceed = true,
  response = {success: true, data: {}}
) => {
  return new Promise((resolve, reject) => {
    const totallyOptionalTimeoutVariableInMilliseconds = 50;
    console.log(`Calling ${url} with `, params);
    setTimeout(
      () => (willSucceed ? resolve(response) : reject(response)),
      totallyOptionalTimeoutVariableInMilliseconds
    );
  });
};

// TODO: Delete this once hooked up to API
const fakeApiHelper = {
  post(url, content, requestHeaders = defaultHeaders) {
    console.log('posting', content);
    return fakeFetch(
      `${baseUrl}${url}`,
      {
        headers: requestHeaders,
        method: 'POST',
        body: JSON.stringify(content),
      },
      true,
      {token: '123', success: true, firstName: 'Jay'}
    ).catch(error => {
      console.log(error);
      return Promise.resolve();
    });
  },
};

const apiHelper = {
  post(url, content, requestHeaders = defaultHeaders) {
    return fetch(`${baseUrl}${url}`, {
      headers: requestHeaders,
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

export default fakeApiHelper;

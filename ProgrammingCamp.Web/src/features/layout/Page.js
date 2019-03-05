import React from 'react';

import './Page.css';

const Page = ({children, header}) => (
  <div className="page-content">
    <div className="page-header">{header || ''}</div>
    {children}
  </div>
);

export default Page;

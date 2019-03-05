import React from 'react';

import './Input.css';

const Input = ({autoFocus, label, handleOnChange, id, type, value = ''}) => (
  <div className="input-container">
    {label && <label htmlFor={id}>{label}</label>}
    <input
      autoFocus={autoFocus}
      id={id}
      type={type}
      onChange={handleOnChange}
      value={value}
    />
  </div>
);

export default Input;

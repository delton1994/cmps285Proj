import React from "react";
import ReactDOM from "react-dom";
import App from "./App";

const checker = a => `${a}~${a}`;

it("renders without crashing", () => {
  const div = document.createElement("div");
  ReactDOM.render(<App />, div);
  ReactDOM.unmountComponentAtNode(div);
});

describe("test cases", () => {
  test.each`
    input  | formatted
    ${"A"} | ${"A~A"}
    ${"B"} | ${"B~B"}
    ${"C"} | ${"C~C"}
    ${"D"} | ${"D~D"}
  `("when $input and $formatted", async ({ input, formatted }) => {
    const price = checker(input);
    expect(price).toEqual(formatted);
  });
});

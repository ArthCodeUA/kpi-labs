// ES6 Version [Lab #6 | Task #13]

"use strict";

// Function h(a,b) is a function, that is being used in function F.
let h = (a, b) => {
    return (a / (1 + b ** 2) + (b / (1 + a ** 2)) - (a - b) ** 3);
};

// Function F, that is solution of the task. Instead of h(1,1) there is just 1 in the end of function.
// This is because of h(1,1) is a constant value and it equals to 1.
let f = (s, t) => {
    return h(s, t) + Math.max(h(s - t, s * t) ** 2, h(s - t, s + t) ** 4) + 1;
};
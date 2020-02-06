// ES6 Version [Lab #4 | Task #13]

"use strict";

// Sequence function.
const sequence = (n) => {
    let sum = 0;
    let x = 1, y = 1;
    for (let i = 1; i <= n; i++) {
        sum += x / (1 + Math.abs(y));
        y += x;
        x *= 0.3;
    }
    return sum;
};

// Checking if N is a valid parameter.
let valid = false;
while(!valid) {
    const n = parseFloat(prompt('Input N'));
    valid = n >= 1;
    alert(valid ? sequence(n) : "Wrong parameter. N should be a natural number, so it should be 1 or more.");
}
// ES6 Version [Lab #3 | Task #13]

"use strict";

// Sequence function.
const sequence = (x) => {
    const E = 0.0001;
    let current = 1;
    let sum = current;
    for (let i = 1; current > E; i++) {
        current *= x * x / (2 * i * (2 * i - 1));
        sum += i % 2 === 0 ? current : 0;
    }
    return sum;
};

// Checking if X is a valid parameter.
let valid = false;
while(!valid) {
    const x = parseFloat(prompt('Input X'));
    valid = x >= 0 && x <=5;
    alert(valid ? sequence(x) : "Wrong parameter. X should be a number and between 0 and 5 inclusively.");
}
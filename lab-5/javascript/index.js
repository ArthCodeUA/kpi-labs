// ES6 Version [Lab #5 | Task #13]

"use strict";

// Function for returning the list of divisors of number p, that in the same time are coprime with number q.
const task = (p, q) => {
    let arr = [];
    for (let i = 1; i <= p; i++) {
        if(p % i === 0) {
            if(areCoprime(i, q)) {
                arr.push(i);
            }
        }
    }
    return arr;
};

// Checking if numbers are coprime, i.e their GCD (greatest common divisor) is 1.
const areCoprime = (a, b) => {
    a = Math.abs(a);
    b = Math.abs(b);
    while(b) {
        let t = b;
        b = a % b;
        a = t;
    }
    // Here a variable is GCD, calculated by Euclidean Algorithm, which is represented above in while method.
    return a === 1;
};

let valid = false;
while(!valid) {
    const p = parseInt(prompt('Input P'));
    const q = parseInt(prompt('Input Q'));
    valid = p % 1 === 0 && q % 1 === 0;
    alert(valid ? task(p, q) : "Wrong parameter. P and Q should be integers.");
}
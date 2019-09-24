// ES6 Version

"use strict";

// Default way of introducing a function
const APROG = function (a, d, n) {
    return a && d && n ? a + d * (n - 1) : "Not enough data";
};

// Introducing function using lambda-expression
const APROGL = (a, d, n) => {
    return a && d && n ? a + d * (n - 1) : "Not enough data";
};
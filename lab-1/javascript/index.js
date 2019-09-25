// ES6 Version

"use strict";

// Default way of introducing a function
function aprog(a, d, n) { return a && d && n ? a + d * (n - 1) : "Not enough data"; }

// Semi-default way of introducing a function
const APROGS = function (a, d, n) { return a && d && n ? a + d * (n - 1) : "Not enough data"; };

// Introducing function using lambda-expression
const APROGL = (a, d, n) => { return a && d && n ? a + d * (n - 1) : "Not enough data"; };
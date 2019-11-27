// ES6 Version [Lab #8 | Task #13]

"use strict";

// Function matrix(nums) is creating new Matrix with special order, that
// is described in task
const matrix = (...nums) => {
    let mx = [];
    for(let q = 0; q < nums.length; q++) {
        mx.push([...nums]);
        nums.push(nums.shift());
    }
    return mx;
};

// Testing how programm works
console.log(matrix(1,2,3,4,5,6,7,8,9,10));
// ES6 Version [Lab #7 | Task #13]

"use strict";

// Function newArray(a,b) is a function, that is being used to get new array, containing
// all the even numbers multiplied by multiplier m
const newArray = (arr, m) => {
  let newArr = [];
  for (let k = 0; k < arr.length; k++) {
      newArr.push(isEven(k) ? arr[k] * m : arr[k]);
  }
  return newArr;
};

// Function avgNegative, that returns average of negative numbers in array
const avgNegative = arr => {
  let negativeArray = arr.filter(a => a < 0);
  return Math.abs(negativeArray.reduce((a, b) => a + b, 0) / negativeArray.length);
};

// Function isEven check, if number is even
const isEven = n => n % 2 === 0;

// Testing how programm works
const testArr = [1, 4, 5, -2, -1, -5, 1, 57, -21];
console.log(newArray(testArr, avgNegative(testArr)));

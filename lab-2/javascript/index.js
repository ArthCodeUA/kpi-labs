// ES6 Version [Lab #2 | Task #13]

"use strict";

// Function defines if point with coordinates x and y is in triangle with points
// A, B and C, coordinates of which are in object "triangle"
let isInTriangle = (x, y, triangle) => {
    let a = (triangle.a.x - x) * (triangle.b.y - triangle.a.y) - (triangle.b.x - triangle.a.x) * (triangle.a.y - y);
    let b = (triangle.b.x - x) * (triangle.c.y - triangle.b.y) - (triangle.c.x - triangle.b.x) * (triangle.b.y - y);
    let c = (triangle.c.x - x) * (triangle.a.y - triangle.c.y) - (triangle.a.x - triangle.c.x) * (triangle.c.y - y);
    return (a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0);
};

// Function defines if point with coordinates x and y is in circle with center
// in point with coordinates x and y and radius r, which are in object "triangle"
let isInCircle = (x, y, circle) => {
    return Math.pow(x - circle.center.x, 2) + Math.pow(y - circle.center.y, 2) <= Math.pow(circle.radius, 2);
};

// Function defines if point with coordinates x and y is in figure, that is coloured in task #13
let isInArea = (x, y) => {
    return (isInCircle(x, y, {center: {x: 1, y: 0}, radius: 2}) && x <= 1 && x >= -1) ||
        (isInTriangle(x, y, {a: {x: 1, y: 2}, b: {x: 3, y: 0}, c: {x: 1, y: -2}}));
};
// ES6 Version [Lab #2 | Task #13]

"use strict";

// Function defines if point with coordinates x and y is in triangle with points A, B and C, coordinates of which are in object "triangle"
let isInTriangle = (x, y, triangle) => {
    let a = (triangle.a.split(";")[0] - x) * (triangle.b.split(";")[1] - triangle.a.split(";")[1]) - (triangle.b.split(";")[0] - triangle.a.split(";")[0]) * (triangle.a.split(";")[1] - y);
    let b = (triangle.b.split(";")[0] - x) * (triangle.c.split(";")[1] - triangle.b.split(";")[1]) - (triangle.c.split(";")[0] - triangle.b.split(";")[0]) * (triangle.b.split(";")[1] - y);
    let c = (triangle.c.split(";")[0] - x) * (triangle.a.split(";")[1] - triangle.c.split(";")[1]) - (triangle.a.split(";")[0] - triangle.c.split(";")[0]) * (triangle.c.split(";")[1] - y);
    return (a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0);
};

// Function defines if point with coordinates x and y is in circle with center in point with coordinates x and y and radius r, which are in object "triangle"
let isInCircle = (x, y, circle) => {
    return Math.pow(x - circle.center.split(";")[0], 2) + Math.pow(y - circle.center.split(";")[1], 2) <= Math.pow(circle.radius, 2);
};

// Function defines if point with coordinates x and y is in figure, that is coloured in task #13
let isInArea = (x, y) => {
    return (isInCircle(x, y, {center: "1;0", radius: 2}) && x <= 1 && x >= -1) || (isInTriangle(x, y, {a: '1;2', b: '3;0', c: '1;-2'}));
};
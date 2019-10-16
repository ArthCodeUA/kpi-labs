let sequence = (x) => {
    let result = [];
    let e = 1;
    let i = 0;
    while(e >= Math.pow(10, -4)) {
        i++;
        if(i !== 1 && i % 4 !== 0) {
            continue;
        }
        result.push(expression(x, i));
        e = Math.abs(result[result.length - 1] - expression(x, next(i)));
    }
    return add(result);
};

let next = (i) => {
    return i === 1 ? 4 : i + 4;
};

let fac = (n) => {
    return n ? n * fac(n - 1) : 1;
};

let expression = (x, i) => {
    return i === 1 ? 1 : (Math.pow(x, i) / fac(i));
};

let add = (array) => {
    let result = 0;
    for (let number of array) {
        result += number;
    }
    return result;
};

console.log(sequence(0));
console.log(sequence(1));
console.log(sequence(2));
console.log(sequence(3));
console.log(sequence(4));
console.log(sequence(5));
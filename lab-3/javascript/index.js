let sequence = (x) => {
    const E = 0.0001;
    let current = 1;
    let sum = current;
    for (let i = 1; current > E; i++) {
        current *= x * x / (2 * i * (2 * i - 1));
        sum += i % 2 === 0 ? current : 0;
    }
    return sum;
};
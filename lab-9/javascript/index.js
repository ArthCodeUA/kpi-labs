const filterString = (str, sl, el) => {
    return str.split(" ").filter(x => x[0] == sl && x[x.length - 1] == el);
};

console.log(filterString("hello hbo friend halo wow cool of haslo great britain very well", "h", "o").join(" "));
function calc(x) {
    console.log(1)
    return x;
}

function calc(x, y) {
    console.log(2)
    return x + y;
}

function calc(x, y, z) {
    console.log(3)
    return x + y + z;
}

console.log(calc(x=10))
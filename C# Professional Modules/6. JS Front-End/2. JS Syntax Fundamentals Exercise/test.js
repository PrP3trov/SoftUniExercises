function check(op,number) {
    if (op === 'chop') {
        number /= 2;
        console.log(number);
    }
    else if (op === 'dice') {
        number = Math.sqrt(number);
        console.log(number);
    }
    else if (op === 'spice'){
        number += 1;
        console.log(number);
    }
    else if (op === 'bake') {
        number *= 3;
        console.log(number);
    }
    else if (op === 'fillet') {
        number = (number *  0.8).toFixed(1);
        console.log(number);
    }
}
function solve (numString,op1,op2,op3,op4,op5) {
    let number = Number(numString);
    check(op1,number);
    check(op2,number);
    check(op3,number);
    check(op4,number);
    check(op5,number);
}


solve('32', 'chop', 'chop', 'chop', 'chop', 'chop');

//ne baca

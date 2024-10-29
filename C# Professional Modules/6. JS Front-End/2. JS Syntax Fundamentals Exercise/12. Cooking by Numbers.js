function solve (numString,op1,op2,op3,op4,op5) {
    let number = Number(numString);
    if (op1 === 'chop') {
        number /= 2;
        console.log(number);
    }
    else if (op1 === 'dice') {
        number = Math.sqrt(number);
        console.log(number);
    }
    else if (op1 === 'spice'){
        number += 1;
        console.log(number);
    }
    else if (op1 === 'bake') {
        number *= 3;
        console.log(number);
    }
    else if (op1 === 'fillet') {
        number = (number *  0.8).toFixed(1);
        console.log(number);
    }

    if (op2 === 'chop') {
        number /= 2;
        console.log(number);
    }
    else if (op2 === 'dice') {
        number = Math.sqrt(number);
        console.log(number);
    }
    else if (op2 === 'spice'){
        number += 1;
        console.log(number);
    }
    else if (op2 === 'bake') {
        number *= 3;
        console.log(number);
    }
    else if (op2 === 'fillet') {
        number = (number *  0.8).toFixed(1);
        console.log(number);
    }

    if (op3 === 'chop') {
        number /= 2;
        console.log(number);
    }
    else if (op3 === 'dice') {
        number = Math.sqrt(number);
        console.log(number);
    }
    else if (op3 === 'spice'){
        number += 1;
        console.log(number);
    }
    else if (op3 === 'bake') {
        number *= 3;
        console.log(number);
    }
    else if (op3 === 'fillet') {
        number = (number *  0.8).toFixed(1);
        console.log(number);
    }

    if (op4 === 'chop') {
        number /= 2;
        console.log(number);
    }
    else if (op4 === 'dice') {
        number = Math.sqrt(number);
        console.log(number);
    }
    else if (op4 === 'spice'){
        number += 1;
        console.log(number);
    }
    else if (op4 === 'bake') {
        number *= 3;
        console.log(number);
    }
    else if (op4 === 'fillet') {
        number = (number *  0.8).toFixed(1);
        console.log(number);
    }

    if (op5 === 'chop') {
        number /= 2;
        console.log(number);
    }
    else if (op5 === 'dice') {
        number = Math.sqrt(number);
        console.log(number);
    }
    else if (op5 === 'spice'){
        number += 1;
        console.log(number);
    }
    else if (op5 === 'bake') {
        number *= 3;
        console.log(number);
    }
    else if (op5 === 'fillet') {
        number = (number *  0.8).toFixed(1);
        console.log(number);
    }
}
function solve (num1, num2) {
    let array = [];
    let sum = 0;
    for(let i = num1; i <= num2; i++){
        array.push(i);
        sum += i;
    }
    console.log(array.join(' '));
    console.log(`Sum: ${sum}`);
}

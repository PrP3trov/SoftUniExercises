function solve (array) {
    let sumOdd = 0;
    let sumEven = 0;
    array.forEach(element => {
        if (element % 2 == 0){
            sumOdd += element;
        }
        else {
            sumEven += element;
        }
    });
    console.log(sumOdd-sumEven);
}

solve([2,4,6,8,10]);
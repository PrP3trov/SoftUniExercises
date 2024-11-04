function solve(array) {
    let zippedArray = [];
    let initialArrayLenght = array.length
    array.sort((a,b) => a - b);

    for(let i = 0; i < initialArrayLenght; i++){
        if (i % 2 == 0){
            let element = array.shift();
            zippedArray.push(element);
        }
        else {
            let element = array.pop();
            zippedArray.push(element);
        }
    }

    return zippedArray;
}
solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);
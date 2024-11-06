function solve (array, step) {
    let newArray = [];
    for(let i=0; i < array.length; i+=step){
        newArray.push(array[i])
       
    }
    return newArray;
}

solve(['1', '2','3', '4', '5'], 6);
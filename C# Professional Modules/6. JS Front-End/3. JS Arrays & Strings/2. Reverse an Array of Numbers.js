function reverseArray(n, array) {
    let partialArray = array.slice(0,n);
    partialArray.reverse();
    console.log(partialArray.join(' '));
}

reverseArray(2, [66, 43, 75, 89, 47]);
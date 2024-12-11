function repeatString (string,times) {
    let result = '';
    for(let i = 0; i < times; i++) {
        result += string;
    }
    return result;
}
console.log(repeatString('String',2));
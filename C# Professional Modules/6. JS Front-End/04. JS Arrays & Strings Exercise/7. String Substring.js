function solve(word,text) {
    if (text.toLowerCase().split(' ').includes(word.toLowerCase())){
        console.log(`${word}`);
    }
    else{
        console.log(`${word} not found!`);
    }
}

solve('python','JavaScript is the best programming language');
function countOfOccurences(text,search) {
    let words = text.split(' ');
    let occurances = 0;
    for (let word of words) {
        if (word === search) {
            occurances++;
        }
    }
    console.log(occurances);
}

countOfOccurences('This is a word and it also is a sentence','is');
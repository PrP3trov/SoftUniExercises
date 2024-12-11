function solve(sentence) {
    let words = sentence.split(' ');
    for ( let w of words) {
        if(w.startsWith('#') && w.length > 1){
            const asciiCode = w.charCodeAt(1);
            if((asciiCode >= 65 && asciiCode <=90) || (asciiCode >= 97 && asciiCode <=122))
            {
                console.log(w.substring(1));
            }
        }
    }
}

solve('The symbol # is known #variously in English-speaking #regions as the #number sign');
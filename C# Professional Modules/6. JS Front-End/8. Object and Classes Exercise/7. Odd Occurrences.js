function solve(input) {

    const words = input.toLowerCase().split(' ');    
    const matched = words.reduce((matched, word) => ({...matched, [word]: 0}), {});

    words.forEach(word => {
       if (matched.hasOwnProperty(word)) matched[word] += 1; 
    });

    let output = '';

    Object.entries(matched)
    .filter(element => element[1] % 2 != 0)
    .forEach(([word, count]) => output += `${word} `);

    console.log(output);
}

solve('Java C# Php PHP Java PhP 3 C# 3 1 5 C#');
solve('Cake IS SWEET is Soft CAKE sweet Food');

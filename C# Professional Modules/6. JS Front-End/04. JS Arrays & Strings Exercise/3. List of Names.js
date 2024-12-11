function sort(array) {
    array
    .sort((a,b) => a.localeCompare(b))
    .forEach(function(element,index){
        console.log(`${index+1}.${element}`)
    });
}
sort(["John", "Bob", "Christina", "Ema"]);
function solve (num1, num2, operator) {
    let result;
    switch (operator) {
    case '+': result = numl+num2; break;
    case '-': result = numl-num2; break; 
    case '/': result = numl/num2; break; 
    case '*': result = numl*num2; break; 
    case '%': result = num1%num2; break;
    case '**': result = num1**num2; break; 
    }
    console.log(result); 
}
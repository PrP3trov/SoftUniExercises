function solve (num1,num2,num3){
    const sum = (x,y) => x + y;
    const subtract = (x,y) => x - y;

    return subtract(sum(num1,num2), num3);
}
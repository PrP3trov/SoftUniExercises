function subtract(firstNum, secondNum) {
    firstNumElement = document.querySelector('#firstNumber').value;
    secondNumElement = document.querySelector('#secondNumber').value;
    resultElement = document.querySelector('#result');
    const result = Number(firstNumElement) - Number(secondNumElement);

    resultElement.textContent = result;
}
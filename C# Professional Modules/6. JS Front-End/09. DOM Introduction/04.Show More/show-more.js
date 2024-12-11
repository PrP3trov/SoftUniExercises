function showText() {
    const readMoreElement = document.querySelector('#more');
    const textElement = document.querySelector('#text');
    readMoreElement.style.textDecoration = 'none';
    readMoreElement.textContent = textElement.textContent;
}
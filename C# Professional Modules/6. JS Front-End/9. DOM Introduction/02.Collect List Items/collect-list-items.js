function extractText() {
    const listElements = document.querySelectorAll('ul li');
    const textareaElement = document.querySelector('#result')
    textareaElement.value = [...listElements].map(e => e.textContent.trim()).join('\n').trim();
}
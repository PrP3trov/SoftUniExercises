function attachEvents() {
    const baseUrl = 'http://localhost:3030/jsonstore/messenger';

    const outputEl = document.querySelector('#messages');
    const inputs = document.querySelectorAll('#controls input[name]');
    const sendButtonEl = document.querySelector('#submit');
    const refreshButtonEl = document.querySelector('#refresh');

    sendButtonEl.addEventListener('click', (e) => {

        const [author, content] = [...inputs].map(field => field.values);

        if (! author || ! content) return;

        const body = {author, content}

        fetch(baseUrl, {
            method: 'POST',
            body: JSON.stringify(body)
        })
        .then(response => response.json())
        .then(result => {
            refreshButtonEl.click();
        })
        .catch(error => console.error('Error: ', error));
    });

    refreshButtonEl.addEventListener('click', (e) => {

        outputEl.textContent = '';

        fetch(baseUrl)
        .then(response => response.json())
        .then(messages => {
            Object.values(messages).forEach(message => {
                outputEl.textContent += `${message.author}: ${message.content}\n`
            });
        })
        .catch(error => console.error('Error: ', error));
    });

}

attachEvents();
document.addEventListener('DOMContentLoaded', () => {

    const defaultChars = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^*()_+[]{}|;:,.?~';
    const randomString = (length, chars = defaultChars) => {
    return [...Array(length)]
        .map(() => chars[Math.floor(Math.random() * chars.length)])
        .join('')
    }

    const textEl = document.querySelector('.text');
    textEl.textContent.trim().split(' ').forEach(word => {
        
        const wordEl = document.createElement('span');
        wordEl.classList.add('word');

        const spaceEl = document.createElement('span');
        spaceEl.classList.add('space');

        word.split('').forEach(letter => {

            const letterEl = document.createElement('span');
            letterEl.classList.add('letter');

            const charactersEl = document.createElement('span');
            charactersEl.classList.add('characters');
            charactersEl.textContent = randomString(20) + letter.toLocaleUpperCase();

            letterEl.append(charactersEl);
            wordEl.append(letterEl);
        });

        textEl.append(wordEl, spaceEl);

    });

    document.querySelectorAll('.characters').forEach((el, i) => {
        el.style.transitionDelay = ( 0.02 * i ) + 's';     
    })
});
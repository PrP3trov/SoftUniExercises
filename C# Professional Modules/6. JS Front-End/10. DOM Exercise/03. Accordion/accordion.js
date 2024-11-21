function toggle() {
    let buttonEl = document.querySelector('#accordion .button');
    let contentEl = document.querySelector('#extra');

    if(contentEl.style.display == 'block'){
        contentEl.style.display = 'none';
        buttonEl.textContent = 'More';
    }
    else {
        contentEl.style.display = 'block';
        buttonEl.textContent = 'Less';
    }
}
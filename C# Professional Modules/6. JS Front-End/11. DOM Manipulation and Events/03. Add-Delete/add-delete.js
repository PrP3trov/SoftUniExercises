function addItem() {
    let items = document.querySelector('#items');
    let text = document.querySelector('#newItemText');

    let newItem = document.createElement('li');
    let deleteButton = document.createElement('a');

    newItem.textContent = text.value;
    deleteButton.setAttribute('href', '#');
    deleteButton.textContent = '[Delete]';

    deleteButton.addEventListener('click', e => {
        e.currentTarget.parentElement.remove();
    });

    newItem.appendChild(deleteButton);
    items.appendChild(newItem);

    text.value = '';
}

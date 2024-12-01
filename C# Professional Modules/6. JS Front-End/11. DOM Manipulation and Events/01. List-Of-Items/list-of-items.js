function addItem() {
    let items = document.querySelector('#items');
    let text = document.querySelector('#newItemText');

    let newItem = document.createElement('li');
    newItem.textContent = text.value;
    
    items.appendChild(newItem);
    text.value = '';
}

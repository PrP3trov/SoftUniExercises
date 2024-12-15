function init() {
    const baseUrl = 'http://localhost:3030/jsonstore/workout/';
    
    const inputs = [...document.querySelectorAll('#workout, #location ,#date')];

    const btnAddEntryEl = document.querySelector('#add-workout');
    const btnEditEntryEl = document.querySelector('#edit-workout');

    const listEntriesEl = document.querySelector('#list'); 

    btnAddEntryEl.addEventListener('click', createHandler);
    btnEditEntryEl.addEventListener('click',updateHandler);

    function loadEntries() {
        listEntriesEl.innerHTML = '';

        loadResources(baseUrl, (result) => {
             Object.values(result).forEach(createEntry);
        });
    }

    function createEntry({ workout, location, date, _id }) {
        const entryEl = createElement('div', { className: 'container', dataset: { workout, location, date, _id }}, listEntriesEl);
        createElement('h2', { textContent: workout }, entryEl);
        createElement('h3', { textContent: date }, entryEl);
        createElement('h3', { textContent: location, id: 'location' }, entryEl);
        const buttonsEl = createElement('div', { className: 'buttons-container' }, entryEl);
        createElement('button', { textContent: 'Change', className: 'change-btn', onclick: changeHandler }, buttonsEl);
        createElement('button', { textContent: 'Done', className: 'delete-btn', onclick: deleteHandler }, buttonsEl);
    }   

    function deleteEntry({workout, location, date, _id}) {
        listEntriesEl.querySelector(`div[data-_id="${_id}"]`).remove();
    }

    function createHandler(e) {
        e.preventDefault();

        const [ workout, location, date] = inputs.map(field => field.value);

        if (! workout || ! location || ! date) return;

        const resourceObject = { workout, location, date};

        console.log(resourceObject); 

        createResource(baseUrl, resourceObject, (result => {
            createEntry(result);
        }));    
        
        inputs.forEach(field => field.value = '');
    }

    function changeHandler(e) {
        const entryEl = e.target.closest('.container');
        const values = Object.values(entryEl.dataset);

        inputs.forEach((field, index) => field.value = values[index]);

        entryEl.classList.add('active');

        btnAddEntryEl.disabled = true;
        btnEditEntryEl.disabled = false;
    }   

    function updateHandler(e) {
        e.preventDefault();

        const [ workout, location, date] = inputs.map(field => field.value);

        if (! workout || ! location || ! date) return;

        const entryEl = listEntriesEl.querySelector('.active');

        const resourceObject = { workout, location, date, _id: entryEl.dataset._id};

        updateResource(baseUrl, resourceObject, (result) => {
            loadEntries();
            inputs.forEach(field => field.value = '');
            btnAddEntryEl.disabled = false;
            btnEditEntryEl.disabled = true;
        });
    }

    function deleteHandler(e) {
        const entryEl = e.target.closest('.container');
        const resourceObject = Object.assign({}, entryEl.dataset);

        deleteResource(baseUrl, resourceObject, (result) => {
             deleteEntry(result);
        });
    }
     
    loadEntries();
}


document.addEventListener('DOMContentLoaded', init);

// API Functions

function loadResources(baseUrl, onSuccess) {
    fetch(baseUrl)
        .then(response => response.json())
        .then(onSuccess)
        .catch(error => console.error('Error: ', error));
}

function createResource(baseUrl, resource, onSuccess) {
    fetch(baseUrl, {
        method: 'POST',
        body: JSON.stringify(resource)
    })
        .then(response => response.json())
        .then(onSuccess)
        .catch(error => console.error('Error: ', error));
}

function updateResource(baseUrl, resource, onSuccess) {
    fetch(baseUrl + resource._id, {
        method: 'PUT',
        body: JSON.stringify(resource)
    })
        .then(response => response.json())
        .then(onSuccess)
        .catch(error => console.error('Error: ', error));
}

function deleteResource(baseUrl, resource, onSuccess) {
    fetch(baseUrl + resource._id, {
        method: 'DELETE'
    })
        .then(response => response.json())
        .then(onSuccess)
        .catch(error => console.error('Error: ', error));
}

// UTIL Functions

function createElement(tag, properties, container) {
    const element = document.createElement(tag);

    Object.keys(properties).forEach(key => {
        if ( typeof properties[key] === 'object' ) {
            element[key] ??= {};
            Object.assign(element[key], properties[key]);
        } else {
            element[key] = properties[key];
        }
    });
    
    if ( container ) container.append(element);
    
    return element;
}
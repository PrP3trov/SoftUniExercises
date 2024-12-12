function loadContacts(baseUrl, onSuccess){

    fetch(baseUrl)
    .then(response => response.json())
    .then(onSuccess)
    .catch(error => console.error('Error: ', error));
}

function createContact(baseUrl, contact, onSuccess){

    fetch(baseUrl, {
        method: 'POST',
        body: JSON.stringify(contact)
     })
    .then(response => response.json())
    .then(onSuccess)
    .catch(error => console.error('Error: ', error));
}

function deleteContact(baseUrl, contact, onSuccess){

    fetch(baseUrl + '/' +  contact._id, {
        method: 'DELETE',
     })
    .then(response => response.json())
    .then(onSuccess)
    .catch(error => console.error('Error: ', error));

}

function createElement(tag, properties, container = null) {
    let element = document.createElement(tag);

    Object.keys(properties).forEach(key => {
        if (typeof properties[key] === 'object'){
            Object.assign(element.dataset, properties[key])
        }
        else {
            element[key] = properties[key];
        }
    });

    if (container) container.append(element);

    return element;
}
function attachEvents() {
    let baseurl = 'http://localhost:3030/jsonstore/phonebook';

    let buttonLoadEl = document.querySelector('#btnLoad');
    let buttonCreateEl = document.querySelector('#btnCreate');
    let phonebookEl = document.querySelector('#phonebook');

    function createEntry({person, phone, _id}) {
      createElement(
        'button', 
        {
            textContent: 'Delete', 
            onclick: deleteEntryHandler
        }, 
            createElement(
                'li', 
                {
                    textContent: `${person}: ${phone}`,
                    dataset: {person, phone, _id}
                }, 
                phonebookEl
            )
        );
    }

    function deleteEntry(contact){
        phonebookEl.querySelector(`li[data-_id="${contact._id}"`).remove();
    }

    function createEntryHandler(e) {
        const inputs = document.querySelectorAll('input[type="text"] [id]');

        const [person, phone] = [...inputs].map(field => field.value);

        if (! person || ! phone) return;
        const contact = {person, phone};

        createContact(baseurl, contact, (result) => {
            createEntry(result);
        });
    }

    function deleteEntryHandler(e) {
        entryEl = e.target.closest('li');
        let contact = Object.assign({}, entryEl.dataset);
        deleteContact(baseurl, contact, (result) => {
            deleteEntry(result);
        });
    }

    loadContacts(baseurl, (resutlt) => {
        Object.values(resutlt).forEach(createEntry);
    })

    buttonCreateEl.addEventListener('click', createEntryHandler);
}

attachEvents();
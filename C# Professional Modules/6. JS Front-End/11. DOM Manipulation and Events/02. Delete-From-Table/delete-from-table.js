function deleteByEmail() {
    let searchStr = document.querySelector('input[name="email"]').value.toLowerCase();
    let people = document.querySelectorAll('table tbody tr td:nth-child(2)');
    let resultEl = document.querySelector('#result');

    people.forEach(person => {
        if (person.textContent.toLowerCase().includes(searchStr)) {
            person.parentElement.remove();
            resultEl.textContent = 'Deleted.';
        }
        else {
            resultEl.textContent = 'Not found.';
        }
    });
}

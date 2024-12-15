window.addEventListener("load", solve);

function solve() {

  function createElement(tag, properties, container) {
    const element = document.createElement(tag);

    Object.keys(properties).forEach(key => {
        if ( typeof properties[key] === 'object' ) {
            Object.assign(element[key], properties[key]);
        } else {
            element[key] = properties[key];
        }
    });
    
    if ( container ) container.appendChild(element);
    
    return element;
}

const inputs = [...document.querySelectorAll('form.registerEvent input')];
const btnAddEl = document.querySelector('#next-btn');

const listCheckEl = document.querySelector('#preview-list')
const listWishEl = document.querySelector('#event-list')

btnAddEl.addEventListener('click', addHandler)

function createEntry({email, event, location}) {
  const entryEl = createElement('li', { className: 'application', dataset: { email, event, location}}, listCheckEl);
  const article = document.createElement('article');
  entryEl.appendChild(article);
  createElement('h4', { textContent: email }, article);

  const paragraph = createElement('p', { textContent: event }, article);
  const strong = document.createElement('strong');
  strong.textContent = 'Event:';
  const br = document.createElement('br');
  paragraph.insertBefore(br, paragraph.firstChild);
  paragraph.insertBefore(strong, paragraph.firstChild);

  const paragraph2 = createElement('p', { textContent: location }, article);
  const strong2 = document.createElement('strong');
  strong2.textContent = 'Location:';
  const br2 = document.createElement('br');
  paragraph2.insertBefore(br2, paragraph2.firstChild);
  paragraph2.insertBefore(strong2, paragraph2.firstChild);
  
  createElement('button', { textContent: 'edit', className: 'action-btn edit', onclick: editHandler }, entryEl);
  createElement('button', { textContent: 'apply', className: 'action-btn apply', onclick: confirmHandler }, entryEl);
}

function addHandler(e) {
    e.preventDefault();

    const [ email, event, location] = inputs.map(field => field.value);

    if (! email || ! event || ! location) return;

    createEntry({ email, event, location});

    console.log(document.querySelector(".application>article>h4").textContent);
    console.log(document.querySelectorAll(".application>article>p")[0].textContent);
    console.log(document.querySelectorAll(".application>article>p")[1].textContent);
    inputs.forEach(field => field.value = '');

    btnAddEl.disabled = true;

}

function editHandler(e) {
  e.preventDefault();

  const entryEl = e.target.closest('li');
  const values = Object.values(entryEl.dataset);

  inputs.forEach((field, index) => field.value = values[index]);

  listCheckEl.removeChild(entryEl);

  btnAddEl.disabled = false;
}

function confirmHandler(e) {
  e.preventDefault();

  const entryEl = e.target.closest('li');
  entryEl.remove();

  entryEl.querySelectorAll('button').forEach(btn => btn.remove());

  listWishEl.append(entryEl);

  btnAddEl.disabled = false;
}
}


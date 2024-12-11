function extract(content) {
    const text = document.querySelector('#' + content).textContent.trim();
    const pattern = /\(([^()]+)/g;
    const result = [...text.matchAll(pattern)].map(el => el[1]).join('; ');

    return result;
}
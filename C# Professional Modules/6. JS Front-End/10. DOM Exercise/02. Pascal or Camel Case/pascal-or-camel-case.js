function solve() {
  let input = document.querySelector('#text').value.toLowerCase().split(' ');
  let currentCase = document.querySelector('#naming-convention').value.toLowerCase().trim();
  let result = document.querySelector('#result');


  switch(currentCase) {
    case 'camel case':
        result.textContent = input[0] +  input.slice(1).map(word => word[0].toUpperCase() + word.slice(1)).join('');
        break;
    case 'pascal case':
      result.textContent = input.map(word => word[0].toUpperCase() + word.slice(1)).join('');
        break;
    default: 
      result.textContent = 'Error!';
  }
}
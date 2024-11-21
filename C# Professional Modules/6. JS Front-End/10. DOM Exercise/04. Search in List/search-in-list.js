function solve() {
   let towns = document.querySelectorAll('#towns li');
   let searchEl = document.querySelector('#searchText').value.toLowerCase();
   let resultEl = document.querySelector('#result');

   if(searchEl == '') return;

   [...towns].forEach(town => {

      town.classList.remove('match');
      town.style.fontWeight = 'normal';
      town.style.textDecoration = 'none'

      if(town.textContent.toLowerCase().includes(searchEl)){
         town.classList.add('match');
         town.style.fontWeight = 'bold';
         town.style.textDecoration = 'underline'
      }
   });

   resultEl.textContent = `${document.querySelectorAll('.match').length} matches found`;
}
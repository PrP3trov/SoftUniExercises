function solve() {
   let searchStr = document.querySelector('#searchField').value.toLowerCase();
   let students = document.querySelectorAll('table tbody tr');

   if (searchStr == '') return;

   students.forEach(student => {

      student.classList.remove('select');

      if(student.textContent.toLowerCase().includes(searchStr)){
         student.classList.add('select');
      }
   })
   
}
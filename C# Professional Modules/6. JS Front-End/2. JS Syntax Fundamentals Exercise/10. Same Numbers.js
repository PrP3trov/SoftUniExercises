function solve (num) {
    let sum = 0;
    let sameNumbers = true;
    let currentDig = num %10;
    let nextDig = (Math.floor(num / 10)) % 10;
    while (num) {
        sum += num % 10;
        if (currentDig != nextDig){
            sameNumbers = false;
        }
        num = Math.floor(num / 10);
    }
    console.log(sameNumbers);
    console.log(sum);
}
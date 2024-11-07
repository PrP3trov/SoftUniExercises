function palindromeCheck (array) {
    const isPalindrome = (num) => {
        const strNum = num.toString();
        const strNumReversed = strNum.split('').reverse().join('');

        return strNum === strNumReversed;
    }

    array.forEach(num => console.log(isPalindrome(num)));
}

palindromeCheck([32,2,232,1010]);
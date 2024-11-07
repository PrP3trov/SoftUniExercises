function validatePassword(password) {

    const fullPassword = new RegExp(/^(?=.*\d.*\d)[a-zA-Z\d]{6,10}$/);
    const onlyLettersAndDigits = new RegExp(/^[a-zA-Z]+$/);
    const atLeast2Digits = new RegExp(/(.*\d){2}/);

    const checkLength = password.length < 6 || password.length > 10;
    const checkContents = ! onlyLettersAndDigits.test(password);
    const checkNumCount = ! atLeast2Digits.test(password);

    if (fullPassword.test(password)) {
        console.log('Password is valid');
    }
    else {
        if (checkLength) console.log("Password must be between 6 and 10 characters");
        if (checkContents) console.log("Password must consist only of letters and digits");
        if (checkNumCount) console.log("Password must have at least 2 digits");
    }
}

validatePassword('Pa$s$s');
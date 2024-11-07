function printMatrix(n) {
    const result = ((n + ' ').repeat(n) + '\n').repeat(n);

    console.log(result);
}

printMatrix(3);
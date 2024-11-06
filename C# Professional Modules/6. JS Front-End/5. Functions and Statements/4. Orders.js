function orders (product, quantity) {
    switch(product){
        case 'coffee':
            console.log(`${(quantity * 1.50).toFixed(2)}`)
            break;
        case 'water':
            console.log(`${(quantity * 1.00).toFixed(2)}`)
            break;
        case 'coke':
            console.log(`${(quantity * 1.40).toFixed(2)}`)
            break;
        case 'snacks':
            console.log(`${(quantity * 2.00).toFixed(2)}`)
            break;
    }
}

orders("coffee", 2);
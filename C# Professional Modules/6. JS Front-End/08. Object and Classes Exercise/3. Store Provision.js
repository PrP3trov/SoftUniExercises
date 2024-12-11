function solve(stock, ordered) {
    let storage = {}

    for(let i = 0; i < stock.length; i += 2){
        storage[stock[i]] = Number(stock[i+1]);
    }

    for(let i = 0; i < ordered.length; i += 2){
        if (! storage.hasOwnProperty(ordered[i]) ) storage[ordered[i]] = 0;
        storage[ordered[i]] += Number(ordered[i+1]);
    }

    for (const product in storage) {
        console.log(`${product} -> ${storage[product]}`);
    }
}

solve([
    'Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'
    ],
    [
    'Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30'
    ]
    )
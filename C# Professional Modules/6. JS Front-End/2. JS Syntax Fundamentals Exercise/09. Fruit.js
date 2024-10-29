function solve (fruit,weightInGrams,pricePerKilo) {
    console.log(`I need $${((weightInGrams/1000) * pricePerKilo).toFixed(2)} to buy ${(weightInGrams/1000).toFixed(2)} kilograms ${fruit}.`);
}
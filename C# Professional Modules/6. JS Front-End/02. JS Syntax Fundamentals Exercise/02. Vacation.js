function solve (people, group, day) {
    let price;
    switch(group) {
        case 'Students':
            if (day === 'Friday') {
                price = 8.45 * people;
            }
            else if (day === 'Saturday') {
                price = 9.80 * people;
            }
            else if (day === 'Sunday') {
                price = 10.46 * people;
            }

            if (people >= 30) {
                price *= 0.85;
            }
            break;

        case 'Business':
            if (day === 'Friday') {
                price = 10.90 * people;
                if (people >= 100) {
                    price = price - (10.90 * 10);
                }
            }
            else if (day === 'Saturday') {
                price = 15.60 * people;
                if (people >= 100) {
                    price = price - (15.60 * 10);
                }
            }
            else if (day === 'Sunday') {
                price = 16 * people;
                if (people >= 100) {
                    price = price - (16 * 10);
                }
            }
            break;

        case 'Regular':
            if (day === 'Friday') {
                price = 15 * people;
            }
            else if (day === 'Saturday') {
                price = 20 * people;
            }
            else if (day === 'Sunday') {
                price = 22.50 * people;
            }

            if (people >= 10  && people <= 20) {
                price *= 0.95;
            }
            break;
    }
    console.log(`Total price: ${price.toFixed(2)}`);
}
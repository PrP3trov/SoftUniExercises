function solve(input) {

    const list = [];

    input.forEach(line => {
        let [name, level, items] = line.split(' / ');

        level = Number(level);

        const hero = {name, level, items};

        list.push(hero);
    });

    list.sort((a, b) => a.level - b.level);

    list.forEach(hero => {
        console.log(`Hero: ${hero.name}`);
        console.log(`level => ${hero.level}`);
        console.log(`items => ${hero.items}`);
    });
}

solve([
    'Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara'
    ]
    );
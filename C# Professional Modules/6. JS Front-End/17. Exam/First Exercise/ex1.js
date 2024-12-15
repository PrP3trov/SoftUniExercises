function solve(input){
    const farmerCount = input.shift();
    const farmerInput = input.splice(0, farmerCount);
    
    const farmers = farmerInput.reduce((farmers, farmer) => {

        let [name, area, tasks] = farmer.split(' ');

        tasks = tasks.split(',');
        
        farmers[name] = { area, tasks};

        return farmers;
    }, {});

    input.forEach(row => {
        
        const splitRow = row.split(' / ');
        const command = splitRow.shift();

        switch(command){
            case 'Execute': {
                const [name, area, task] = splitRow;

                if(farmers[name].area === area && farmers[name].tasks.includes(task))
                    console.log(`${name} has executed the task: ${task}!`);
                else
                    console.log(`${name} cannot execute the task: ${task}.`);

                break;
            }

            case 'Change Area': {
                const [name, newArea] = splitRow;
                farmers[name].area = newArea;

                console.log(`${name} has changed their work area to: ${newArea}`);
                break;
            }

            case 'Learn Task': {
                const [name, newTask] = splitRow;

                if(!farmers[name].tasks.includes(newTask)){
                    farmers[name].tasks.push(newTask);
                    console.log(`${name} has learned a new task: ${newTask}.`);
                }
                else
                    console.log(`${name} already knows how to perform ${newTask}.`);

                break;
            }
        }
    });

    Object.keys(farmers).forEach(name => {
        const output = `Farmer: ${name}, Area: ${farmers[name].area}, Tasks: ${farmers[name].tasks.sort().join(', ')}`;
        console.log(output);
    });
}
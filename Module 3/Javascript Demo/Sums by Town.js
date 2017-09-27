function solve(args) {
    let result = [];

    for(let i = 0; i < args.length; i++){
        let townIncome = JSON.parse(args[i]);
        let name = townIncome.town;
        let income = townIncome.income;

        result.push({name, income})
    }

    let towns = result.sort(function (a, b) {
        return a.income - b.income;
    });

    console.log(towns)
}

solve([
    '{"town":"Sofia","income":200}',
    '{"town":"Varna","income":120}',
    '{"town":"Pleven","income":60}',
    '{"town":"Lovech","income":20}'
]);
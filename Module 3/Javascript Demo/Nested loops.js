'use strict';

// [0...10] - i
// [15...20] - j
// [5...10] - k

for(let i = 0; i <= 10; i += 1)
{
    for(let j = 15; j <= 20; j += 1)
    {
        for(let k = 5; k <= 10; k += 1)
        {
            console.log(`${i}, ${j}, ${k}`)
        }
    }
}


## Problem 3 – A Box Full of Balls

### Miki and Nishi play a very interesting game: When the game begins a few balls are placed in a box. Miki and Nishi take out balls in turns. The one who takes the last ball wins. Miki always plays first.

### On each turn, a player may take a fixed number of balls (one of a few predefined number of balls).

### For each integer from A to B, inclusive a game will be played with that number of balls in the box (this means that B-A+1 games will be played). E.g. if A is 5 and B is 7, there will be played 3 games with 5, 6 and 7 balls.

### Assuming that both players play optimally, find in how many of these games Miki will win.

### Input

On the first input line there will be the list of all possible turns (getting just one ball will always be a possible turn).

On the second line there will be the numbers **A** and **B** separatedby a single space (&#39;&#39;).

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output data should be printed on the console.

On the only output line write the **number of games Miki wins** (when both players play optimally).

### Constraints

- .You will be given between 1 and 54 possible turns.
- .Each turn will be an integer between 1 and 100, inclusive.
- .1 &lt;= **A** &lt;= **B** &lt;= 100 000
- .Allowed working time for your program: 0.15 second Allowed memory: 32 MB.

### Examples

| **Example input** | **Example output** | **Explanation** |
| --- | --- | --- |
| 4 1 31 5 | 4 | If the box contains **1** , **3** or **4** balls, Miki wins by taking them all on his first turn. If the box contains **2** balls, Miki is forced to take 1 balls, and Nishi wins by taking the other one. If the box contains **5** balls, Miki takes 3 balls (leaving 2 balls in the box) and wins the game on his next turn. |
| 11 100 | 50 |   |
| 1 3 5 7 2 4 61 7 | 7 |   |
| 1 2 31 8 | 6 | Miki will always win when both player play optimally if the number of balls are **1** , **2** , **3** , **5** , **6** or **7**.In the other 2 cases ( **4** and **8** ) Nishi will win the game playing optimally. |
| 1 1001 100000 | 50495 |   |

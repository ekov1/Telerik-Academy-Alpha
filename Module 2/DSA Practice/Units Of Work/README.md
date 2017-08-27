

## Problem 1 – Units of Work

You are implementing a game engine. Your game has different kinds of _units_, which have _name_, _type_ and _attack_. The player can create (add) new units, find all units of certain type and find his/her most powerful units. Sometimes a unit is destroyed and it should be removed from the game.

You are given a sequence of commands that must be implemented:

- . **add UNIT\_NAME UNIT\_TYPE UNIT\_ATTACK** – adds new unit to the game
  - . **UNIT\_NAME** can be any unique sequence from 1 to 30 characters
  - . **UNIT\_TYPE** can be any sequence from 1 to 40 characters and may not be unique
  - . **UNIT\_ATTACK** can be any integer between 100 and 1000, inclusive
  - .Print &quot; **SUCCESS:**  **UNIT\_NAME**  **added!**&quot;, if the unit is added successfully
  - .Print &quot; **FAIL**** : **** UNIT\_NAME **** already exists!**&quot;, if the unit already exists
- . **remove UNIT\_NAME** – removes an existing unit with _UNIT\_NAME_ from the game
  - .Print &quot; **SUCCESS:**  **UNIT\_NAME**  **removed!**&quot;, if the unit was removed successfully
  - .Print &quot; **FAIL:**  **UNIT\_NAME**  **could not be found!**&quot;, if the unit does not exist in the game
- . **find UNIT\_TYPE** – finds the top 10 units, first ordered by attack in descending order and then by their name in ascending order
  - .Print the results in the following format &quot; **RESULT:**  **UNIT**** , **** UNIT ****,**  **UNIT**&quot; where _UNIT_ should be printed in the format &quot; **UNIT\_NAME**** [****UNIT\_TYPE****]( ****UNIT\_ATTACK**** ) **&quot;. If no units are found just print &quot;** RESULT:**&quot; (ending with one space)
- . **power**  **NUMBER\_OF\_UNITS** - prints the top _NUMBER\_OF\_UNITS_ most powerful units currently in the game in the same format as the &quot; **find**&quot; command(inside joke: this command should have been &quot;POWER OVERWHELMING!&quot;). If there are less units than requested just return them.
- . **end** – marks the end of the commands and no other commands will follow afterwards.

### Input

The input data should be read from the console.

The input consists of a sequence of commands, each at a separate line, ending by the command &quot; **end**&quot;.

The commands will be valid (as described in the above list), in the specified format, within the constraints given below. **There is no need to check the input data explicitly**.

### Output

The output data should be printed on the console.

For each command from the input sequence print at the standard output its result as a single line.

### Constraints

- .All **UNIT\_NAME** and **UNIT\_TYPE** will consist of letters and digits only. No spaces are allowed.
- .The total number of lines in the input will be in the range [1 … 100 000]
- .Allowed working time for your program: 0.6seconds.
- .Allowed memory: 64 MB.



| **Input** | **Output** |
| --- | --- |
| add TheMightyThor God 100add Artanis Protoss 250add Fenix Protoss 200add Spiderman MutatedHuman 180add XelNaga God 500add Wolverine MutatedHuman 200add Zeratul Protoss 300add Spiderman MutatedHuman 180power 3find Protossfind Godremove Kerriganremove XelNagapower 3find Kerriganfind Godend | SUCCESS: TheMightyThor added!SUCCESS: Artanis added!SUCCESS: Fenix added!SUCCESS: Spiderman added!SUCCESS: XelNaga added!SUCCESS: Wolverine added!SUCCESS: Zeratul added!FAIL: Spiderman already exists!RESULT: XelNaga[God](500), Zeratul[Protoss](300), Artanis[Protoss](250)RESULT: Zeratul[Protoss](300), Artanis[Protoss](250), Fenix[Protoss](200)RESULT: XelNaga[God](500), TheMightyThor[God](100)FAIL: Kerrigan could not be found!SUCCESS: XelNaga removed!RESULT: Zeratul[Protoss](300), Artanis[Protoss](250), Fenix[Protoss](200)RESULT:RESULT: TheMightyThor[God](100) |



## Problem 3 – Online Market

You are given an online market.Products can be added and queried in the market. You are given a sequence of commands that must be implemented:

- **add PRODUCT\_NAME PRODUCT\_PRICE PRODUCT\_TYPE** – adds a new product to the market
  - **PRODUCT\_NAME** can be any unique sequence of 3 to 20 characters
  - **PRODUCT\_PRICE** can be any positive floating-point number, up to 5000
  - **PROCUCT\_TYPE** can be any sequence of 3 to 20 characters. Product type may not be unique
  - Print &quot; **Ok: Product PRODUCT\_NAME added successfully**&quot; if the product is added
  - Print &quot; **Error: Product PRODUCT\_NAME already exists**&quot; if the product already exists
- **filter by type PRODUCT\_TYPE** – lists the first 10 products that have the given PRODUCT\_TYPE
  - Print &quot; **Error: Type PRODUCT\_TYPE does not exists**&quot;, if the given PRODUCT\_TYPE is non-existent
- **filter by price from MIN\_PRICE to MAX\_PRICE** – lists the first 10 products that have PRODUCT\_PRICE in the given range, inclusive
- **filter by price from MIN\_PRICE** – lists the first 10 products that have a greater PRODUCT\_PRICE than the given, inclusive
- **filter by price to MAX\_PRICE** – lists the first 10 products that have a smaller PRODUCT\_PRICE that the given, inclusive
- **end** – marks the end of the commands. No commands will follow

All products that are listed by the **filter** commands must be printed in the format
&quot; **Ok: LIST\_OF\_PRODUCTS**&quot;. LIST\_OF\_PRODUCTS contains the filtered products, separated by a space and a comma (&quot;, &quot;) and each product is represented as &quot;**PRODUCT\_NAME(PRODUCT\_PRICE)**&quot;. If the result from **the filtering by price is 0** products, then print &quot; **Ok:**&quot;. They must also be sorted by the following criteria:

- First by PRODUCT\_PRICE, ascending
- Then by PRODUCT\_NAME, ascending
- Last by PRODUCT\_TYPE, ascending

### Input

The input data is given at the standard input. It consists of a sequence of commands, each at a separate line, ending by the command &quot;end&quot;. The commands will be valid (as described in the above list), in the specified format, within the constraints given below. There is no need to check the input data explicitly.

### Output

For each command from the input sequence print at the standard output its result as a single line.

### Constraints

- All **PRODUCT\_NAME** and **PRODUCT\_TYPE** will consist of letters and digits only. No spaces are allowed.
- All **filter by price \*** commands will occur no more than 100 times in any test, and approximately 2% of all commands in a test
- The total **number of lines** in the input will be in the range [1 … 50 000]
- Allowed working time for your program: 0.6 seconds.
- Allowed memory: 64 MB.

### Example

| **Input** | **Output** |
| --- | --- |
| add Milk 1.90 dairyadd Yogurt 1.90 dairyadd Notebook 1111.90 technologyadd Orbit 0.90 foodadd Rakia 11.90 drinksadd Dress 121.90 clothesadd Jacket 49.90 clothesadd Milk 1.90 dairyadd Socks 2.90 clothesfilter by type dairyfilter by price from 1.00 to 2.00filter by price from 1.50filter by price to 2.00filter by type clothesend | Ok: Product Milk added successfullyOk: Product Yogurt added successfullyOk: Product Notebook added successfullyOk: Product Orbit added successfullyOk: Product Rakia added successfullyOk: Product Dress added successfullyOk: Product Jacket added successfullyError: Product Milk already existsOk: Product Socks added successfullyOk: Milk(1.9), Yogurt(1.9)Ok: Milk(1.9), Yogurt(1.9)Ok: Milk(1.9), Yogurt(1.9), Socks(2.9), Rakia(11.9), Jacket(49.9), Dress(121.9), Notebook(1111.9)Ok: Orbit(0.9), Milk(1.9), Yogurt(1.9)Ok: Socks(2.9), Jacket(49.9), Dress(121.9) |
| add Milk 1.90 dairyadd Yogurt 1.90 dairyadd Notebook 1111.90 technologyadd Orbit 0.90 foodadd Rakia 11.90 drinksadd Dress 121.90 clothesadd Jacket 49.90 clothesadd Milk 1.90 dairyadd Eggs 2.34 foodadd Cheese 5.55 dairyfilter by type clothesfilter by price from 1.00 to 2.00add CappyOrange 1.99 juice add Nestey 2.7 juice filter by price from 1200add Socks 2.90 clothesfilter by type fruitsadd MacBookPro 1700.1234 technologyfilter by price from 1200filter by price from 1.50filter by price to 2.00filter by type clothesend | Ok: Product Milk added successfullyOk: Product Yogurt added successfullyOk: Product Notebook added successfullyOk: Product Orbit added successfullyOk: Product Rakia added successfullyOk: Product Dress added successfullyOk: Product Jacket added successfullyError: Product Milk already existsOk: Product Eggs added successfullyOk: Product Cheese added successfullyOk: Jacket(49.9), Dress(121.9)Ok: Milk(1.9), Yogurt(1.9)Ok: Product CappyOrange added successfullyOk: Product Nestey added successfullyOk:Ok: Product Socks added successfullyError: Type fruits does not existsOk: Product MacBookPro added successfullyOk: MacBookPro(1700.1234)Ok: Milk(1.9), Yogurt(1.9), CappyOrange(1.99), Eggs(2.34), Nestey(2.7), Socks(2.9), Cheese(5.55), Rakia(11.9), Jacket(49.9), Dress(121.9)Ok: Orbit(0.9), Milk(1.9), Yogurt(1.9), CappyOrange(1.99)Ok: Socks(2.9), Jacket(49.9), Dress(121.9) |

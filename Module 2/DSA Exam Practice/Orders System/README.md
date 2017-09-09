<div class="page">

<div id="preview-page" class="preview-page" data-autorefresh-url="">

<div role="main" class="main-content">

<div class="container new-discussion-timeline experiment-repo-nav">

<div class="repository-content">

<div id="readme" class="readme boxed-group clearfix announce instapaper_body md">

### <span class="octicon octicon-book"></span>README.md

<article class="markdown-body entry-content" itemprop="text" id="grip-content">

[![](https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png)](https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png)

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#telerik-academy-alpha--dsa---31-august-2017)_Telerik Academy Alpha / DS&A - 31 August 2017_

# [<span aria-hidden="true" class="octicon octicon-link"></span>](#task-1-orders-system)Task 1: Orders system

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#description)Description

An orders system keeps a set of orders. Each order has name, price and consumer. Your task is to model the orders system and design a data structure to hold the orders. Write a program that executes N commands, given in the input (a single command at a line):

*   **AddOrder name;price;consumer** - adds an order by given name, price and consumer. If an order with the same name / consumer / price already exists, the newly added order does not affect existing ones (duplicates are allowed). As a result, the command prints "**Order added**".
*   **DeleteOrders consumer** - deletes all orders by given consumer. As a result, the command prints "**X orders deleted**" where **X** is the number of deleted orders or "**No orders found**" if no such orders exist.
*   **FindOrdersByPriceRange fromPrice;toPrice** – finds all orders whose price is greater or equal than **fromPrice** and less or equal than **toPrice**. As a result the command prints a list of orders in format **{name;consumer;price}**. The list items should be ordered in alphabetical order. You should print each order on a single line. If no orders exist within the specified price range, the command prints “**No orders found**”.
*   **FindOrdersByConsumer consumer** – finds all orders by given consumer. As a result the command prints a list of orders in format **{name;consumer;price}**. The list items should be ordered in alphabetical order. You should print each order on a single line. If no orders exist by the specified consumer, the command prints “**No orders found**”.

See the examples bellow.

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#input)Input

The input data is read from the standard input (the console).

*   On the first line you will receive the number **N** of the commands.
*   On the next **N** lines you will be given a command in the format described above.

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#output)Output

The output data is printed on the standard output (the console).

*   The output should contain the output from each command from the input.

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#constraints)Constraints

*   **N** will be between 1 and 60000
*   All string in the commands (e.g. order names and consumers) consist of alphabetical characters, numbers and spaces.
*   Prices are given as real numbers with up to 2 digits after the decimal point, (e.g. 35.18, or 120).
*   The ‘.’ symbol is used as decimal separator.
*   Prices should be printed with exactly 2 digits after the decimal point (e.g. 120.30 instead of 120.3).
*   **Time limit: 2.7 s**
*   **Memory limit: 64 MB**

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-tests)Sample Tests

### [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-input-1)Sample Input 1

    10
    AddOrder IdeaPad Z560;1536.50;Ivan
    AddOrder ThinkPad T410;3000;Ivan
    AddOrder VAIO Z13;4099.99;Pesho
    AddOrder CLS 63 AMG;200000;Gosho
    AddOrder 320i;10000;Tosho
    AddOrder G560;999;Ivan
    FindOrdersByConsumer Ivan
    DeleteOrders Ivan
    FindOrdersByConsumer Ivan
    FindOrdersByPriceRange 100000;200000

### [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-output-1)Sample Output 1

    Order added
    Order added
    Order added
    Order added
    Order added
    Order added
    {G560;Ivan;999.00}
    {IdeaPad Z560;Ivan;1536.50}
    {ThinkPad T410;Ivan;3000.00}
    3 orders deleted
    No orders found
    {CLS 63 AMG;Gosho;200000.00}

</article>

</div>

</div>

</div>

</div>

</div>

</div>

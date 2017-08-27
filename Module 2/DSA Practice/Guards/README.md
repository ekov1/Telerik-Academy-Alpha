<div class="page">

<div id="preview-page" class="preview-page" data-autorefresh-url="">

<div role="main" class="main-content">

<div class="container new-discussion-timeline experiment-repo-nav">

<div class="repository-content">

<div id="readme" class="readme boxed-group clearfix announce instapaper_body md">

### <span class="octicon octicon-book"></span>Guards

<article class="markdown-body entry-content" itemprop="text" id="grip-content">

# [<span aria-hidden="true" class="octicon octicon-link"></span>](#guards)Guards

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#description)Description

Once again you have to escape from a maze. You are in the **top left corner** of the maze and you have to go the **bottom right** one. You are allowed to go only **right** and **down** and passing through a cell takes **1 second**.

In some of the cells there will be guards. Here is a picture of a guard:

[![guard](./imgs/cat.jpg)](https://www.youtube.com/watch?v=5dsGWM5XGdg)

It is absolutely forbidden to step through a guard's cell. Each guard will be looking in one of the neighbouring cells (up, down, left or right). Going through those cells takes **3 seconds**.

Write a program which finds the minimum amount of seconds needed to escape the maze. If it is impossible to escape print `Meow`.

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#input)Input

*   Input is read from the console
    *   The first line contains two numbers separated by space
        *   The number of rows and number of columns
    *   The second line contains an integer - the number of guards
    *   Each guard is described on a single line with two numbers and direction separated by spaces
        *   the first number is the row on which the guard resides
        *   the second number is the column
        *   the direction is one of `U`, `D`, `L` and `R` representing the direction in which the guard is looking

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#output)Output

*   Output should be printed on the console
    *   A single line denoting the maximum profit which can be obtained.

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#constraints)Constraints

*   1 <= **rows**, **columns** <= 1000
*   0 <= **number of guards** <= **rows** * **columns**
*   0 <= **number of guards** <= 50000
*   **Time limit**: **0.1s**
*   **Memory limit**: **32 MB**

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-tests)Sample tests

### [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-test-1)Sample test 1

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#input-1)Input

    4 3
    2
    1 0 R
    2 2 L

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#output-1)Output

    10

### [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-test-2)Sample test 2

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#input-2)Input

    8 8
    10
    7 3 R
    5 3 R
    4 3 L
    6 1 U
    2 4 R
    2 7 D
    0 3 R
    6 2 D
    3 7 U
    2 1 R

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#output-2)Output

    15

### [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-test-3)Sample test 3

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#input-3)Input

    8 8
    8
    7 0 L
    6 1 U
    5 2 L
    4 3 L
    3 4 D
    2 5 L
    1 6 D
    0 7 D

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#output-3)Output

    Meow

</article>

</div>

</div>

</div>

</div>

</div>

</div>

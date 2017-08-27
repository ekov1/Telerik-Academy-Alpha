<div class="page">

<div id="preview-page" class="preview-page" data-autorefresh-url="">

<div role="main" class="main-content">

<div class="container new-discussion-timeline experiment-repo-nav">

<div class="repository-content">

<div id="readme" class="readme boxed-group clearfix announce instapaper_body md">

<article class="markdown-body entry-content" itemprop="text" id="grip-content">

# [<span aria-hidden="true" class="octicon octicon-link"></span>](#swapping)Swapping

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#description)Description

Don't you like to swap? You are starting with a sequence of numbers **from 1 to N**. A swap around number **X** transforms the sequence:

    <left numbers> X <right numbers>

to:

    <right numbers> X <left numbers>

Your task is to perform several swap arounds.

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#input)Input

*   Input is read from the console
    *   A number **N** is read from the first input line
    *   A sequence of numbers - swap around each of them from left to right

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#output)Output

*   Output should be printed on the console
    *   Print the sequence after all the swapping
        *   Separate numbers by spaces

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#constraints)Constraints

*   **N** <= 100 000
*   **number of swaps** <= 100 000
*   **Time limit**: **0.2s**
*   **Memory limit**: **48 MB**

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-tests)Sample tests

### [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-test-1)Sample test 1

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#input-1)Input

    6
    3

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#output-1)Output

    4 5 6 3 1 2

### [<span aria-hidden="true" class="octicon octicon-link"></span>](#description-1)Description

    1 2 (3) 4 5 6 -> 4 5 6 (3) 1 2

### [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-test-2)Sample test 2

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#input-2)Input

    8
    5 4 7

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#output-2)Output

    8 5 1 2 3 7 4 6

### [<span aria-hidden="true" class="octicon octicon-link"></span>](#description-2)Description

    1 2 3 4 (5) 6 7 8 -> 6 7 8 (5) 1 2 3 4
    6 7 8 5 1 2 3 (4) -> (4) 6 7 8 5 1 2 3
    4 6 (7) 8 5 1 2 3 -> 8 5 1 2 3 (7) 4 6

### [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-test-3)Sample test 3

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#input-3)Input

    12
    11 5 10 6 9 10

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#output-3)Output

    9 7 8 10 6 5 12 11 1 2 3 4

### [<span aria-hidden="true" class="octicon octicon-link"></span>](#description-3)Description

    1 2 3 4 5 6 7 8 9 10 (11) 12 -> 12 (11) 1 2 3 4 5 6 7 8 9 10
    12 11 1 2 3 4 (5) 6 7 8 9 10 -> 6 7 8 9 10 (5) 12 11 1 2 3 4
    6 7 8 9 (10) 5 12 11 1 2 3 4 -> 5 12 11 1 2 3 4 (10) 6 7 8 9
    5 12 11 1 2 3 4 10 (6) 7 8 9 -> 7 8 9 (6) 5 12 11 1 2 3 4 10
    7 8 (9) 6 5 12 11 1 2 3 4 10 -> 6 5 12 11 1 2 3 4 10 (9) 7 8
    6 5 12 11 1 2 3 4 (10) 9 7 8 -> 9 7 8 (10) 6 5 12 11 1 2 3 4

</article>

</div>

</div>

</div>

</div>

</div>

</div>

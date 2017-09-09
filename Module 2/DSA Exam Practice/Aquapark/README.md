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

# [<span aria-hidden="true" class="octicon octicon-link"></span>](#task-3-aquapark)Task 3: Aquapark

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#description)Description

You like having fun on the water slides in an Aquapark, right? Now you need to build a monitoring system for the Aquapark which will display who is using the water slides. Write a program that executes N commands, given in the input (a single command at a line):

*   **add ID** - adds a person (person's Aquapark ID) to the end of queue of people waiting for the water slide. There is no problem to add an **ID** which is already added (it will appear twice). As a result, the command prints "**Added ID**".
*   **slide K** - slides **K** people on the water slide and adds them in the same order to the back of the queue of people. As a result, the command prints "**Slided K**".
*   **print** – prints all people which are waiting for the water slide (separated by space). As a result, the command prints **ID1 ID2 ID3 ... IDn**.

See the examples bellow.

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#input)Input

The input data is read from the standard input (the console).

*   On the first line you will receive the number **N** of the commands.
*   On the next **N** lines you will be given a command in the format described above.

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#output)Output

The output data is printed on the standard output (the console).

*   The output should contain the output from each command from the input.

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#constraints)Constraints

*   **N** will be between 1 and 9000
*   Each **ID** will be between 1 and 100.
*   **K** will be between 1 and 20000.
*   All input data will be correct, so there's no need to check it explicitly.
*   **Time limit: 0.7 s**
*   **Memory limit: 24 MB**

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-tests)Sample Tests

### [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-input-1)Sample Input 1

    10
    add 4
    add 3
    add 2
    add 1
    print
    slide 2
    print
    add 10
    slide 13
    print

### [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-output-1)Sample Output 1

    Added 4
    Added 3
    Added 2
    Added 1
    1 2 3 4
    Slided 2
    3 4 1 2
    Added 10
    Slided 13
    4 1 2 10 3

</article>

</div>

</div>

</div>

</div>

</div>

</div>

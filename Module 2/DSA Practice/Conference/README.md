<div class="page">

<div id="preview-page" class="preview-page" data-autorefresh-url="">

<div role="main" class="main-content">

<div class="container new-discussion-timeline experiment-repo-nav">

<div class="repository-content">

<div id="readme" class="readme boxed-group clearfix announce instapaper_body md">

<article class="markdown-body entry-content" itemprop="text" id="grip-content">

# [<span aria-hidden="true" class="octicon octicon-link"></span>](#conference)Conference

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#description)Description

Your manager is sending you to a developer conference and one of your goals is to meet as many programmers from **different** companies as you can.

There will be **N** developers attending the conference numbered from **0** to **N - 1**. Your manager doesn't know each developer's company. The only information he has is that some particular pairs of developers work in the same company.

What you need to do prior to the conference is to compute in how many ways you can pick a pair of developers belonging to different companies, so they can get to know each other. Your manager provided you enough pairs to let you identify the groups of developers even though you might not know their company directly. For example, if **1, 2, 3** are developers from the same company, it is sufficient to mention that **(1, 2)** and **(2, 3)** are pairs of developers from the same company without providing information about a third pair **(1, 3)**. If there is no information about a developer you can assume that he is from different (his own) company.

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#input)Input

*   Input is read from the console
    *   On the first line are two integers, **N** and **M**, separated by a single space.
    *   Each of the following **M** lines contains **2** integers separated by a single space **X** and **Y** such that **0 <= X, Y <= N - 1** and **X** and **Y** are developers from the same company.

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#output)Output

*   Output should be printed on the console
    *   A single line denoting the number of possible ways to choose a pair of developers from different companies.

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#constraints)Constraints

*   1 <= N <= 100000
*   1 <= M <= 10000
*   **Time limit**: **0.05s**
*   **Memory limit**: **16 MB**

## [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-tests)Sample tests

### [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-test-1)Sample test 1

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#input-1)Input

    4 2
    0 1
    2 3

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#output-1)Output

    4

### [<span aria-hidden="true" class="octicon octicon-link"></span>](#sample-test-2)Sample test 2

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#input-2)Input

    7 3
    0 2
    0 3
    1 4

#### [<span aria-hidden="true" class="octicon octicon-link"></span>](#output-2)Output

    17

</article>

</div>

</div>

</div>

</div>

</div>

</div>

# Integer right triangles
## Problem 39
If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120.

{20,48,52}, {24,45,51}, {30,40,50}

For which value of p ≤ 1000, is the number of solutions maximised?

## Solution Notes
Written in C#, and it is sloooowwwww...but it returns the right answer. I know that the search range values
probably do not make much sense, like there can't be a right triangle with a = b = c = 1, but I really
don't know of a better way of reducing the number of searches.
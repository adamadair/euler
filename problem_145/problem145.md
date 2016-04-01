# How many reversible numbers are there below one-billion?
## Problem 145
Some positive integers n have the property that the sum `n + reverse(n)` consists 
entirely of odd (decimal) digits. For instance, 36 + 63 = 99 and 409 + 904 = 1313.
We will call such numbers reversible; so 36, 63, 409, and 904 are reversible. Leading
zeroes are not allowed in either n or reverse(n).

There are 120 reversible numbers below one-thousand.

How many reversible numbers are there below one-billion (10**9)?

# Solution Notes
Interestingly enough 89990001 is the last number. If I looked at it longer I
might be able to gather some insight. This was a bad solution. It was brute force and
it took forever, but it did finish and with the correct answer.

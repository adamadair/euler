# Champernowne's constant
## Problem 40
An irrational decimal fraction is created by concatenating the positive integers:

0.123456789101112131415161718192021...

It can be seen that the 12th digit of the fractional part is 1.

If dn represents the nth digit of the fractional part, find the value of the following expression.

d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000
## Solution Notes
Written in C#, this is my approach:

1. Make a big decimal string by concatenating the first million integers together. This takes some time.
2. Then search the string for the 7 requested digits.
3. Multiply the digits.
4. write it.
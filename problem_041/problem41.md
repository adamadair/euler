# Pandigital prime
## Problem 41
We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once. For example, 2143 is a 4-digit pandigital and is also prime.

What is the largest n-digit pandigital prime that exists?

# Solution Notes
It's ugly, it builds on code from Problem #32, but it's fairly quick considering it has a search range
of 987,654,321 numbers. It takes about 3 seconds on my machine. The strategy is to first 
calculate the lists of pandigital numbers and then check each for primality, working backwards. 
 

# Lexicographic permutations
## Problem 24
A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. The lexicographic permutations of 0, 1 and 2 are:

012   021   102   120   201   210

What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?

# Solution Notes

This one was a fun one, and it actually required some thought. The first reaction was to brute force it and
just create all permutations and then sort the array, then pick the millionth item in the array, but that would
create twice as many permutations as necessary. So a little searching on the internet turned up that this 
problem had been solved as early as the 14th century in India. I took the algorithm described on [Wikipedia](https://en.wikipedia.org/wiki/Permutation#Generation_in_lexicographic_order) and
turned it into C#. 

The following algorithm generates the next permutation lexicographically after a given permutation. It changes the given permutation in-place.

1. Find the largest index `k` such that `a[k] < a[k + 1]`. If no such index exists, the permutation is the last permutation.
2. Find the largest index `l` greater than k such that `a[k] < a[l]`.
3. Swap the value of `a[k]` with that of `a[l]`.
4. Reverse the sequence from `a[k + 1]` up to and including the final element `a[n]`.

The only difference to the algorithm is that I've added a counter so that it stops at the millionth. The only
thing left to do is convert to Ruby for completeness sake.

# Prime permutations
## Problem 49
The arithmetic sequence, 1487, 4817, 8147, in which each of the terms increases by 3330, is unusual in two ways: (i) each of the three terms are prime, and, (ii) each of the 4-digit numbers are permutations of one another.

There are no arithmetic sequences made up of three 1-, 2-, or 3-digit primes, exhibiting this property, but there is one other 4-digit increasing sequence.

What 12-digit number do you form by concatenating the three terms in this sequence?

# Solution Notes
C#, long search through the available list of primes to find triplets where the differences
between the first and second matched the difference of the second and third. The values of the 
triplet are then checked to see if each is made from identical digits. The runtime is slower
than I expected, but it worked. 

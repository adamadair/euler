# Large non-Mersenne prime
## Problem 97
The first known prime found to exceed one million digits was discovered in 
1999, and is a Mersenne prime of the form 2<sup>6972593</sup>−1; it contains exactly 
2,098,960 digits. Subsequently other Mersenne primes, of the form 2p−1, have 
been found which contain more digits.

However, in 2004 there was found a massive non-Mersenne prime which contains 
2,357,207 digits: 28433×2<sup>7830457</sup>+1.

Find the last ten digits of this prime number.

# Solution Notes
I used the ruby command line interpereter to solve this:

`puts ((28433*(2**7830457))+1).to_s[-10..-1]`

I'm just using Ruby like a powerful calculator. So, perhaps it is true that I do 
not understand the mathematics behind how Ruby is able calculate very large numbers, 
but I do not how to use the tools at my disposal to find the answers to these
questions.  
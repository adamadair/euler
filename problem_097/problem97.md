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

`puts (28433*(2**7830457)+1) % 10000000000`

I'm just using Ruby like a powerful calculator. So, perhaps it is true that I do 
not understand the mathematics behind how Ruby is able calculate very large numbers, 
but I do know how to use the tools at my disposal to find the answers to these
questions. I don't know what that says about me as a programmer, but I am very aware
what it says about my math skills. I am not a mathematician. 

I wrote a C program to calculate the same answer and it should be obvious what it is doing.
Using a `long` variable set to 1 we just shift left 7830457 times
and since we only care about the last 10 digits and to take care not to overflow the
variable we use modular division to trim the value. Program execution is fast, but I think
that the Ruby solution is just as fast. 

So I used the `time` feature on Mac to time the execution of both programs.

**Ruby:**
<pre>
  real	0m0.068s
  user	0m0.046s
  sys	0m0.018s 
</pre>

**C:**
<pre>
  real	0m0.157s
  user	0m0.145s
  sys	0m0.004s
</pre>
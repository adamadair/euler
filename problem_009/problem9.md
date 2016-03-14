# Special Pythagorean triplet
## Problem 9
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

`a**2 + b**2 = c**2`

For example, `3**2 + 4**2 = 9 + 16 = 25 = 5**2`.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.

## Solution Notes
1. I wrote the first solution in C, simply because I wanted to change from Ruby.
Interestingly enough, in C you have to include the math.h library to use the
pow() and sqrt() functions. Then you have to explicity link to the math
library when compiling with gcc. This solution is found in **solution.c** and you 
can compile on linux using the following
`$ gcc -o solution solution.c -lm`

2. I then wrote the solution in Ruby. This solution is found in **solution.rb**.
Note the much simpler syntax to a Ruby program compared to C. 
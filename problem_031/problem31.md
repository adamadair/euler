# Coin sums
## Problem 31
In England the currency is made up of pound, £, and pence, p, and there are eight coins in general circulation:

1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) and £2 (200p).
It is possible to make £2 in the following way:

1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
How many different ways can £2 be made using any number of coins?

# Solution Notes
2 different solutions, one in C# and one in Ruby. Both return the same answer. The C# as it is written 
is not reusable. The Ruby with only slight modification would be able to be reused for finding 
solutions for different denominations of coins. The obvious next step would be to list the 
actual coin combinations.

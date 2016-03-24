# Goldbach's other conjecture
## Problem 46

It was proposed by Christian Goldbach that every odd composite number can be written as the sum of a prime and twice a square.

9 = 7 + 2×12
15 = 7 + 2×22
21 = 3 + 2×32
25 = 7 + 2×32
27 = 19 + 2×22
33 = 31 + 2×12

It turns out that the conjecture was false.

What is the smallest odd composite that cannot be written as the sum of a prime and twice a square?

# Solution Notes
Wrote this one in C#. I was surprised by the answer. It's almost like Goldback didn't 
even try to check his conjecture. I expected this to be large number so I extended the
prime checking code to include long integer types, and I think I could have completed 
this with ordinary 32bit integers. 
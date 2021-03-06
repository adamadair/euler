# Multiples of 3 and 5
# Problem 1
# If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
# Find the sum of all the multiples of 3 or 5 below 1000.

output = 0  # init output
1.upto(999){ |x|
  if((x % 3 == 0) || (x % 5 == 0)) 
    output += x
  end       
}
puts output


# The prime factors of 13195 are 5, 7, 13 and 29.
#
# What is the largest prime factor of the number 600851475143 ?

# A prime number (or a prime) is a natural number greater than 1 that has no 
# positive divisors other than 1 and itself. In number theory, the prime 
# factors of a positive integer are the prime numbers that divide that integer 
# exactly.

def get_lpf(x)
  lpf = 2;
  while (x > lpf) do
    if (x % lpf==0)
      x = x / lpf 
      lpf = 2
    else
      lpf += 1
    end
  end
  lpf
end
   
 
number = 600_851_475_143
puts get_lpf(number)





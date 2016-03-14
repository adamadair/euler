# returns true if n is prime
def is_prime?(n) 
 return false if (n % 1 > 0 || n < 2)  
 return true if (n == least_factor(n))
 false
end

# least_factor(n)
# returns the smallest prime that divides n
def least_factor(n)   
 return 0 if (n == 0)  
 return 1 if (n % 1 > 0 || n * n <2)
 return 2 if (n % 2 == 0)  
 return 3 if (n % 3 == 0)  
 return 5 if (n % 5 == 0)  
 m = Math.sqrt(n)
 i = 7
 while i <= m do 
  return i if (n % i == 0)      
  return i + 4 if (n % (i + 4) == 0)  
  return i + 6 if (n % (i + 6) == 0) 
  return i + 10 if (n % (i + 10) == 0) 
  return i + 12 if (n % (i + 12) == 0) 
  return i + 16 if (n % (i + 16) == 0) 
  return i + 22 if (n % (i + 22) == 0)
  return i + 24 if (n % (i + 24) == 0)
  i += 30
 end
 n
end
top = 2_000_000
sum = 2  # we add the only even 
int = 3
while(int < top) do
  sum += int if is_prime?(int)
  int += 2
end

puts sum

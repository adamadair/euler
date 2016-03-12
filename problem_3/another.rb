# this one is based on the solution given on the web site after
# providing the solution. I don't think I like this one, but
# it is also very fast. For simplicity sake I like the solution
# in problem3.rb
 
def get_lpf(x)
  n = x
  lf = 1
  if n % 2 == 0
    lf = 2
    n = n / 2
    while n % 2 == 0 do
      n = n / 2
    end
  end  
  fact = 3
  max = Math.sqrt(n)
  while n > 1 && fact <= max do
    if n % fact == 0
      n = n / fact
      lf = fact
      while n % fact == 0 do
        n = n / fact
      end
      max = Math.sqrt(n)
    end
    fact += 2
  end  
    
  if n == 1
    return lf
  end
  n
end 
  
number = 600_851_475_143
puts get_lpf(number)
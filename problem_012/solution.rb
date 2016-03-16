# returns number of divisors for number x
# The number of divisors can be calculate from the exponents of the 
# distinct prime numbers which are factors of x.
def find_divisor_num(x)
  return 1 if x == 1
  n = x
  pary = Array.new
  
  if n % 2 == 0   
    n = n / 2
    y = 1
    while n % 2 == 0 do
      n = n / 2
      y+=1
    end
    pary << (y+1)
  end  
  fact = 3  
  while n > 1 && fact <= x do
    if n % fact == 0
      y = 1
      n = n / fact
      while n % fact == 0 do
        n = n / fact
        y += 1
      end
      pary << (y+1)
    end
    fact += 2
  end      
  prod = 1
  pary.each{|d| prod *= d }
  return prod  
end

dnum = 0
tn = 0
index = 0
while dnum < 500
  index += 1
  tn += index
  dnum = find_divisor_num(tn)
  puts "#{tn} : #{dnum}"
end

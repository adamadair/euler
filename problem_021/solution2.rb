def sum_of_divisors(n)
  sum=1
  p=2
  while p*p<=n && n>1 do
    if (n % p)==0
      j = p * p
      n = n / p
      while (n % p)==0 do
        j = j * p
        n = n / p
      end
      sum = sum * (j-1)
      sum = sum /(p-1)
    end
    if p==2 then p=3 else p=p+2 end
  end
  if n>1 then sum=sum*(n+1) end
  sum
end 

def sum_of_proper_divisors(n)
  sum_of_divisors(n)-n
end

def d(n)
  sum_of_proper_divisors(n)
end

sums = Array.new(10001)
for i in 1..10000
  sums[i]=d(i)
end
sum = 0
for i in 1..10000
  if sums[i]>1 && sums[i]<=10000
    if i != sums[i] && i == sums[sums[i]]
      num1 = i 
      num2 = sums[i]
      
      sum += sums[i] + sums[sums[i]];
      sums[sums[i]]=0
      sums[i]=0
      puts "#{num1} #{num2}"    
    end
  end
end
puts sum



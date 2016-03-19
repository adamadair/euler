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

abundant = []
for i in 1..28123
  abundant<<i if sum_of_proper_divisors(i)>i
end

ary = Array.new(28123,1)

index = 0
while index < abundant.length do
  nxt = 0
  while(abundant[index]+abundant[nxt]<28123) do
    ary[abundant[index]+abundant[nxt]]=0
    nxt += 1;
  end
  index += 1;
end

sum = 0
other = 0
for i in 0..28122
  
  if(ary[i]==0)
    sum += i
  else 
    other += i
  end 
end
puts other

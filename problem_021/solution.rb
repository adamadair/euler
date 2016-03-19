def d(n)
  sum = 0
  for i in 1..n/2
    sum += i if n%i==0  
  end
  sum
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



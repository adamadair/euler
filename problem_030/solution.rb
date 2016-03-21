def is_sum_of_power(n,p)
  s = 0
  n.to_s.each_char{|d| s+=d.to_i**p}
  s==n
end
sum=0
for n in 2..1000000 do
  sum+=n if is_sum_of_power(n,5)
end
puts sum
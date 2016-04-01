def all_odd?(n)
  return false if (n%10).even?
  if n/10!=0 
    return all_odd?(n/10)
  end
  true  
end

def reverse_i(n)
  n.to_s.reverse.to_i
end

count = 0
for n in (1..1_000_000_000)
  next if n % 10 == 0
  rn = reverse_i(n)
  sum = n + rn  
  if all_odd?(sum)
    count += 1
    puts "#{n} + #{rn} = #{sum}"
  end 
end
puts count
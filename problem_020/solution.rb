def fact(n)
  v=1
  for i in 1..n
    v *= i
  end
  v
end
number = fact(100).to_s
sum = 0
number.each_char{|c|sum+=c.to_i}
puts sum

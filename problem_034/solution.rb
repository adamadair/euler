sum = 0
for i in (3..50000) do
  if i == i.to_s.each_char.map { |d| (1..d.to_i).reduce(1, :*) }.reduce(:+)
    sum += i
  end
end
puts sum  

def get_digit_sum(n)
  n.to_s.chars.map{|x|x.to_i}.reduce(:+)
end

largest=0
for a in (1..99) do
  for b in (1..99) do
    s = get_digit_sum(a**b)
    largest = s if s > largest
  end
end
puts largest



def sum_digit_squares(n)
  n.to_s.chars.map{|x|x.to_i**2}.reduce(:+)
end

def do_chain(n)
  sum = sum_digit_squares(n)
  return sum if sum==1 || sum==89
  do_chain(sum)
end
eighty_nines=0
for i in (1...10000000)
  eighty_nines+=1 if do_chain(i)==89
end
puts eighty_nines
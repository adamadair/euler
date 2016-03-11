# this is a corrected version of the program that is more efficient

def sum_divisible_by(target, number)
  p = target / number
  number*((p*(p+1)) / 2)
end

puts (sum_divisible_by(999,3) + sum_divisible_by(999,5)) - sum_divisible_by(999,15)

sum_of_squares = 0
sum_of_integers = 0
for x in 1..100 do
  sum_of_integers += x
  sum_of_squares += x*x
end
square_of_sums = sum_of_integers * sum_of_integers
puts "sum_of_integers = #{sum_of_integers}"
puts "sum of squares = #{sum_of_squares}"
puts "square_of_sums = #{square_of_sums}"
puts square_of_sums-sum_of_squares
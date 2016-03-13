limit = 100
sum = (limit*(limit + 1))/2
sumsq = (((2*limit) + 1)*(limit + 1)*limit)/6
puts "#{(sum**2) - sumsq}"
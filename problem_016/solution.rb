# Ruby is good for this because it handles BigNums very well.
val = 2**1000
sval = val.to_s
sum = 0
puts " 0"
for i in 0..sval.length-1
  num = sval[i]
  puts "+#{num}"
  sum += num.to_i
end
puts"-------"
puts sum

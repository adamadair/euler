require File.join(File.dirname(__FILE__), 'words')
sum = 0
for i in 1..1000
  sum += digit_letter_count(i)
end
puts sum

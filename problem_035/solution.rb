require "../lib/ruby/is_prime"
# Returns true if n is circular prime
def circular_prime?(n)
  return false if !n.prime?
  s = n.to_s
  (s.length-1).times do
    s = s.chars.rotate.join
    return false if !s.to_i.prime?
  end
  true
end

count = 13
for i in (100..999999) 
  count += 1 if circular_prime?(i)  
end

puts count


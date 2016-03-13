# returns true if n is prime
def is_prime?(n) 
 n < 2 ? false : ('1' * n) !~ /^1?$|^(11+?)\1+$/
end

count = 1
val = 3
last_prime = 2;
while count < 10001 do
  if is_prime?(val)
    count += 1
    puts"#{count} - #{val}"
    last_prime = val
  end
  val += 2
end
puts last_prime




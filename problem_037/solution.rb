require "../lib/ruby/is_prime"

def truncate_left(n)
  str = n.to_s
  return 0 if str.length==1
  str[0]=''
  str.to_i
end

def truncate_right(n)
  str = n.to_s
  return 0 if str.length==1
  str.chop!
  str.to_i
end

def is_truncateable_prime?(n)
  i = n
  begin
    return false if !i.prime?
    i = truncate_left(i)
  end until i == 0
  i = n
  begin
    return false if !i.prime?
    i = truncate_right(i)
  end until i == 0  
  true
end

puts(is_truncateable_prime?(11))

count=0
i = 11
sum = 0
while(count<11) do
  if (is_truncateable_prime?(i))
    count +=1
    sum += i
    puts i
  end
  i += 1
end
puts sum


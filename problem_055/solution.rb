# return true if n is a palindrome
def is_palindrome(n)
  s = n.to_s
  s==s.reverse
end
# returns sum of n with its reverse
def add_reverse(n)
  n+n.to_s.reverse.to_i
end

def is_lychrel(n)
  i = 0
  done = false
  while !done do
    return true if i > 50
    n = add_reverse(n)
    done = is_palindrome(n)
    i+=1
  end
  false
end

count = 0
for n in (1..9999) do
  count += 1 if is_lychrel(n)
end
puts count
 
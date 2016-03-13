# palindrome test for integers. This is a cheat because it uses
# the ruby string library. There is a mathematical way to test for 
# testing for palindromic numbers, but I simply don't understand it.
def is_plaindrome?(i)
  s = i.to_s
  s == s.reverse
end

def find_largest_palindrome
  return_val = 0
  for x in 0..499 do
    for y in 0..499 do
      val = (999-x) * (999-y)
      if(is_plaindrome?(val) && val > return_val)
        return_val = val
      end
    end
  end
  return_val
end

puts find_largest_palindrome

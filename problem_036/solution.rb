def is_palindrome?(s)
  s==s.reverse
end
sum = 0
for i in 1..999999 do
  sum += i if is_palindrome?(i.to_s) && is_palindrome?((i.to_s(2)))
end
puts sum
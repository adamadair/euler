# At each step outwards toward 1001 we can calculate the values
# of the four corners. Add all the corner values together plus 1
# should come up with the solution.
val = 1
n = 3
while n <= 1001 do
  ne = (n**2)
  nw = ne - (n-1)
  sw = nw - (n-1)
  se = sw - (n-1)
  val += se + sw + nw + ne
  n += 2
end
puts val
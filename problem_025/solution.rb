f1 = 1
f2 = 1
index = 2
while(f2.to_s.length<1000) do
  nxt = f2 + f1
  f1 = f2
  f2 = nxt
  index += 1
end
puts index

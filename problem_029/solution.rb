hash = {}
for a in 2..100 do
  for b in 2..100 do
    hash[a**b]=1
  end # b
end # a
puts hash.length


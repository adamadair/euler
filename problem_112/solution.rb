def is_increasing(n)
  a = n.to_s.chars
  curr=a[0]
  for c in a do
    if c>=curr
      curr=c
    else
      return false
    end 
  end
  true#a[0]!=a[a.count-1]
end

def is_decreasing(n)
  a = n.to_s.chars
  curr=a[0]
  for c in a do
    if c<=curr
      curr=c
    else
      return false
    end 
  end
  true#a[0]!=a[a.count-1]
end

bcount = 0
limit = 99.0
n=0
while true
  n += 1
  bcount += 1 if(!is_decreasing(n)&&!is_increasing(n))
  break if (bcount.to_f / n.to_f)*100.0>=limit
end
puts "#{n} => #{bcount}"

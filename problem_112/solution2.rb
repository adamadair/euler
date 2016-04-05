# All math solution, this is faster
def is_increasing(n)
  curr=n%10
  while n > 0 do
    c = n % 10
    if c<=curr
      curr=c
    else
      return false
    end
    n /= 10 
  end
  true
end

def is_decreasing(n)
  curr=n%10
  while n > 0 do
    c = n % 10
    if c>=curr
      curr=c
    else
      return false
    end
    n /= 10 
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

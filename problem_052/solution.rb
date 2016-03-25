def digits(n)
  n.to_s.split('').sort
end
i=0
d=''
begin
  i += 1
  d=digits(i)
end until (d==digits(i*2)&&d==digits(i*3)&&d==digits(i*4)&&d==digits(i*5)&&d==digits(i*6))
puts i
 
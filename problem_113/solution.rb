def factorial(n)
  return 1 if n==0
  n*factorial(n-1)
end

def calc(n,r)
  factorial(n)/factorial(n-r)/factorial(r)
end

def nN(n)
  calc(n+10,10)+calc(n+9,9)-9*n-(n+1)-1
end

puts nN(100)
def in_kernel(n1,n2,n3)
  n1^n2^n3
end
sum=0
for n in (1..2**30) do
  sum += 1 if in_kernel(n,n*2,n*3)==0
end
puts sum

def calculate_c(a, b)
  c_sq = (a**2) + (b**2);
  Math.sqrt(c_sq)
end

c = 0
a = 100
while a <= 500 && c == 0 do
  b = 1;
  while b <= a && c ==0 do
    tmp_c = calculate_c(a, b);
    sum = a + b + tmp_c;
    if sum == 1000.0 
      c = tmp_c.to_i
    end
    b += 1 if c == 0
  end
  a += 1 if c == 0 
end
puts "a = #{a}; b = #{b}; c = #{c}; product = #{a*b*c}"

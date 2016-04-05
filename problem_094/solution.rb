x = 2
y = 1
limit = 1000000000
sum = 0
while true do
  a3 = 2 * x - 1
  area3 = y * (x - 2)
  break if a3 > limit
  if a3 > 0 && area3 > 0 && a3 % 3 == 0 && area3 % 3 == 0
    sum += (3 * ( a3 / 3)) + 1
  end
  
  a3 = 2 * x + 1
  area3 = y * (x + 2)
  if a3 > 0 && area3 > 0 && a3 % 3 == 0 && area3 % 3 == 0
    sum += (3 * ( a3 / 3)) -1
  end
  
  nx = 2 * x + y * 3
  ny = y * 2 + x
  x = nx
  y = ny
end

puts sum
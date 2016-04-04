n=50
rt_count = n**2
for x1 in (0..n) do
  for y1 in (0..n) do
    for x2 in (0..n) do
      for y2 in (0..n) do
        if (x1==0 && y1==0) || (x2==0 && y2==0)
          next
        end
        if (x1**2 + y1**2 - x1 * x2 - y1 * y2 == 0) && (x1 != x2 || y1 != y2)
          rt_count+=1
        end
      end
    end
  end
end
puts rt_count 
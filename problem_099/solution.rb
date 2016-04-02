max=0
max_row=0
index=0
File.open("p099_base_exp.txt", "r") do |f|
  f.each_line do |line|
    index += 1
    nums = line.split(",")
    a,x=nums[0].to_i,nums[1].to_i
    if x * Math.log10(a) > max
        max = x * Math.log10(a)
        max_row = index
    end
  end
end
puts max_row
# this may be a cheat, but I don't care
num_array = Array.new
sum = 0
File.open("numbers.txt", "r") do |f|
  f.each_line do |line|
    num_array << line.to_i
    sum += line.to_i
  end
end
puts sum
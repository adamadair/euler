triangle = Array.new
File.open("triangle.txt", "r") do |f|
  f.each_line do |line|
    d_array = Array.new
    tok_array = line.split(' ')
    tok_array.each {|t| d_array << t.to_i }
    triangle << d_array
  end
end
last = []
for i in 0...triangle.length
  row = Array.new(triangle[i].length)
  row_len = triangle[i].length
  for j in 0..row_len-1
    row[j] = triangle[i][j]
    if i > 0
      if j == 0 
        row[j] += last[j]
      elsif j == row_len-1
        row[j] += last[j-1]
      else
        if last[j-1]>last[j]
          row[j] += last[j-1]
        else
          row[j] += last[j]
        end
      end
    end
    last = row
  end
end

max = 0
last.each{|x| max = x if x > max }

puts max

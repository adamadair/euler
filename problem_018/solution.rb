triangle = Array.new
File.open("triangle.txt", "r") do |f|
  f.each_line do |line|
    d_array = Array.new
    tok_array = line.split(' ')
    tok_array.each {|t| d_array << t.to_i }
    triangle << d_array
  end
end
puts triangle
count = Array.new
for i in 0...triangle.length
  row = Array.new
  row_len = triangle[i].length
  for j in 0..row_len-1
    row << triangle[i][j]
    if i > 0
      if j == 0 
        row[j] += count[i-1][j]
      elsif j == row_len-1
        row[j] += count[i-1][j-1]
      else
        puts "i = #{i}  j = #{j} row_len = #{row_len}"
        if count[i-1][j-1]>count[i-1][j]
          row[j] += count[i-1][j-1]
        else
          row[j] += count[i-1][j]
        end
      end    
    end
    count << row
  end
end

max = 0
for i in count[count.length-1]
  man = i if i > max
end

puts max

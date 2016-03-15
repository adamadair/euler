# brute force grid traversal and calculations. There might be
# a recursive approach to this but I did not give it much thought.
def horizontal(ary, row, col)
  return -1 if col + 3 > 19
  line = ary[row]
  line[col] * line[col + 1] * line[col + 2] * line[col + 3]
end

def vertical(ary, row, col)
  return -1 if row + 3 > 19
  ary[row][col] * ary[row+1][col] * ary[row+2][col] * ary[row+3][col]
end

def diagonal_down(ary, row, col)
  return -1 if col + 3 > 19 || row + 3 > 19
  ary[row][col] * ary[row+1][col+1] * ary[row+2][col+2] * ary[row+3][col+3]
end

def diagonal_up(ary, row, col)
  return -1 if col + 3 > 19 || row - 3 < 0
  ary[row][col] * ary[row-1][col+1] * ary[row-2][col+2] * ary[row-3][col+3]
end

grid = Array.new
File.open("grid.txt", "r") do |f|
  f.each_line do |line|
    d_array = Array.new
    tok_array = line.split(' ')
    tok_array.each {|t| d_array << t.to_i }
    grid << d_array
  end
end

top_product = 0
for row in 0..19 
  for col in 0..19
    val = horizontal(grid,row,col)
    top_product = val if val > top_product
    val = vertical(grid,row,col)
    top_product = val if val > top_product
    val = diagonal_down(grid,row,col)
    top_product = val if val > top_product    
    val = diagonal_up(grid,row,col)
    top_product = val if val > top_product
  end
end

puts top_product

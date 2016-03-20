require './sudoku'

sum = 0
pz = []
File.open("p096_sudoku.txt", "r") do |f|
  x = -1
  f.each_line do |line|
    x += 1
    ln = x % 10
    puts "ln=#{ln} #{x}- #{line}"
    if ln == 0
      pz = Array.new
    else
      pz<<line
    end
    if ln==9
      puts "Puzzle:"
      puts pz
      puts 
      ans = Sudoku.solve(Sudoku::Puzzle.new(pz)).to_s
      sum += ans[0..2].to_i
      puts "Solved:"
      puts ans
      puts
    end 
  end
end
puts sum

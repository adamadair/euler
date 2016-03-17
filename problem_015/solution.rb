class Lattice
 def initialize(r, c)
  @rows, @cols = r, c
  @cache = Array.new(r, Array.new(c,-1))
 end
 
 def paths
  count_routes(@rows-1,@cols-1)
 end
 
 def count_routes(m,n)
  return 1 if (m == 0 || n == 0)
  return @cache[m][n] if @cache[m][n] > -1
  @cache[m][n] = count_routes(m,n-1) + count_routes(m-1,n)
  return @cache[m][n]   
 end
end
print "rows: "
r = gets.chomp.to_i
print "cols: "
c = gets.chomp.to_i

l = Lattice.new(r,c)
puts "\nThe answer is: #{l.paths}"

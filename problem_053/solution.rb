class Combinatorics
  def initialize 
    @factorial = []
    @factorial<<1 # 0 factorial is 1 
    @factorial<<1
    (2..100).to_a.each{|n|@factorial<<(1..n).to_a.reduce(:*)}
  end
  def calc(n,r)
    @factorial[n]/(@factorial[r]*@factorial[n-r])  
  end
end

c = Combinatorics.new
count = 0
(1..100).to_a.each{|n|
  (1..100).to_a.each{|r|
    count += 1 if c.calc(n,r)>1_000_000
  }
}
puts count
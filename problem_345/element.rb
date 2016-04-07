class Element
  attr_accessor :value, :row, :col

  def initialize(n, r, c)
    @value = n
    @row = r
    @col = c
  end

  def to_s
    "#{@value} [#{@row+1}] [#{@col+1}]"
  end
end
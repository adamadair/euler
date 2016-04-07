class AwaMatrix

  def initialize(a)
    @values = []
    @rows = []
    @cols = []
    @max_col = 0
    @max_row = 0
    if(!a.nil?)
      insert_values(a)
    end
  end


  def sum
    @rows = Array.new(@max_row, 0)
    @cols = Array.new(@max_col, 0)
    @values.sort!{|x,y|y.value<=>x.value}
    selected = []
    calc_sum(0,selected)
  end

  private

  def insert_values(matrix)
    (0..matrix.length-1).to_a.each{|r|
      @max_row += 1
      row=matrix[r]
      (0..row.length-1).to_a.each{|c|
        @max_col = c + 1 if c + 1 > @max_col
        printf("%3d ",matrix[r][c])
        @values<<Element.new(matrix[r][c],r,c)
      }
      puts
    }
  end

  def calc_sum(depth, selected)
    return -1 if(depth==@values.length) # There is no solution
    v = @values[depth]
    if @rows[v.row]==0 && @cols[v.col]==0
      @rows[v.row]=1
      @cols[v.col]=1
      selected<<v
      if(selected.length >= @max_col && selected.length >= @max_row)
        #calculate sum
        puts selected
        sum = selected.map{|x|x.value}.reduce(:+)
        selected.delete(v)
        @rows[v.row]=0
        @cols[v.col]=0
        # cc = depth+1
        # while cc<@values.length && @values[cc].value==v.value
        #   if(v.row==@values[cc].row || v.col==@values.col)
        #     # potential collision
        #     nv = @values[cc]
        #     @values[cc] = v
        #     @values[depth] = nv
        #     new_sum = calc_sum(depth,selected)
        #     if new_sum > sum
        #       sum=new_sum
        #     else
        #
        #     end
        #   end
        #   cc += 1
        # end
        return sum
      end
    end
    calc_sum(depth+1,selected)
  end

end
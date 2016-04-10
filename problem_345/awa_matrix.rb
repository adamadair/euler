class AwaMatrix

  def initialize(a)
    @matrix = a
    @rows = a.length
    @cols = a[0].length
    @max_sum = []
  end


  def sum
    (0..@rows).to_a.each{
      @max_sum << Array.new((1<<@cols), 0)
    }
    puts @max_sum.length
    find_max_sum(0,(1<<@cols)-1)
  end

  private
  def find_max_sum(start_row, set_of_cols)
    return 0 if start_row==@rows
    puts "#{start_row} - #{set_of_cols}"
    if @max_sum[start_row][set_of_cols]==0
      max = 0
      col = 0
      while (1<<col)<=set_of_cols
        max = max_i(@matrix[start_row][col]+find_max_sum(start_row+1, set_of_cols ^ (1<<col)), max) if set_of_cols & (1 << col) != 0
        @max_sum[start_row][set_of_cols]=max
        col += 1
      end
    end
    @max_sum[start_row][set_of_cols]
  end

  def max_i(a,b)
    return a if a > b
    b
  end

    # https://github.com/nayuki/Project-Euler-solutions/blob/master/java/p345.java
    # private int findMaximumSum(int startRow, int setOfCols) {
    # if (startRow == ROWS) {
    #     if (Integer.bitCount(setOfCols) != COLUMNS - ROWS)
    #       throw new AssertionError();
    #       return 0;
    #       }
    #
    #       if (maxSum[startRow][setOfCols] == 0) {
    #           int max = 0;
    #       for (int col = 0; (1 << col) <= setOfCols; col++) {
    #           if ((setOfCols & (1 << col)) != 0)
    #             max = Math.max(MATRIX[startRow][col] + findMaximumSum(startRow + 1, setOfCols ^ (1 << col)), max);
    #             }
    #             maxSum[startRow][setOfCols] = max;
    #             }
    #             return maxSum[startRow][setOfCols];
    #             }


end
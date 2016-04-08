class AwaMatrix

  def initialize(a)
    @matrix = a
    @rows = a.length
    @cols = a[0].length
    @max_sum = []
  end


  def sum
    (0..@rows).to_a.each{
      @max_sum << array.new((1<<@cols), 0)
    }
    0
  end

  private
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
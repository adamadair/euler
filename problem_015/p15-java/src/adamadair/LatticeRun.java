package adamadair;

import java.util.Scanner;

/**
 * LatticeRun represents a defeat, and is the implementation of the solution
 * provided by the Euler Project. I wrote it in Java as penance for my shame.
 * 
 * @author adam
 */
public class LatticeRun {

	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		System.out.print("Rows: ");
		int rows = reader.nextInt();
		System.out.print("Columns: ");
		int cols = reader.nextInt();
		long paths = new LatticeRun(rows, cols).getLatticePaths();
		System.out.println(String.format("%d x %d grid has %d paths.", rows, cols, paths));
		reader.close();
	}

	private int _rows, _cols;

	public LatticeRun(int rows, int cols) {
		_rows = rows;
		_cols = cols;
	}

	public long getLatticePaths() {
		int m = _rows;
		int n = _cols;

		long[][] grid = new long[m + 1][n + 1]; // A two-dimensional 0-indexed
												// array of size m + 1 by n + 1
		for (int i = 0; i <= m; ++i)
			grid[i][0] = 1l;

		for (int j = 0; j <= n; ++j)
			grid[0][j] = 1l;

		for (int i = 1; i <= m; ++i) {
			for (int j = 1; j <= n; ++j) {
				grid[i][j] = grid[i - 1][j] + grid[i][j - 1];
			}
		}
		return grid[m][n];
	}
}

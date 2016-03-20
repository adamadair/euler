# Su Doku
## Problem 96
Su Doku (Japanese meaning number place) is the name given to a popular puzzle concept. Its origin is unclear, but credit must be attributed to Leonhard Euler who invented a similar, and much more difficult, puzzle idea called Latin Squares. The objective of Su Doku puzzles, however, is to replace the blanks (or zeros) in a 9 by 9 grid in such that each row, column, and 3 by 3 box contains each of the digits 1 to 9.

## Solution Notes
I love Sudoku. I actually had some code to do this prior that I could use to provide the solution. 
The Sudoku solver is in sudoku.rb. I didn't write the code in sudoku.rb, and I can't recall where
it actually came from so I can't give proper credit where credit is due, but I want it to be clear
that I am NOT claiming credit for the sudoko solving algorithm.

Here are some tests:

Puzzle:

003020600<br/>
900305001<br/>
001806400<br/>
008102900<br/>
700000008<br/>
006708200<br/>
002609500<br/>
800203009<br/>
005010300<br/>

can be solved with:

`Sudoku.solve(Sudoku::Puzzle.new("003020600900305001001806400008102900700000008006708200002609500800203009005010300"))`

returns:

483921657<br/>
967345821<br/>
251876493<br/>
548132976<br/>
729564138<br/>
136798245<br/>
372689514<br/>
814253769<br/>
695417382<br/>

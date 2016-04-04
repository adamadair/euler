# Right triangles with integer coordinates
## Problem 91

The points P (x1, y1) and Q (x2, y2) are plotted at integer co-ordinates and are joined to the origin, O(0,0), to form ΔOPQ.

Given that 0 ≤ x1, y1, x2, y2 ≤ 50, how many right triangles can be formed?

## Solution Notes
The distance between two points is the <span style="white-space: nowrap; font-size:larger">
&radic;<span style="text-decoration:overline;">&nbsp;(X2-X1)<sup>2</sup>+(Y2-Y1)<sup>2</sup>&nbsp;</span>
</span>

So, loop across all possible point values of P and Q and test whether the three points OPQ create a right triangle. Is one
way of doing this. Also, it is easy to calculate all the right triangles that occur when one of the point lies along one
of the axes.
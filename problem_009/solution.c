/**
 * solution.c
 * 
 * This is a C language solution for the Euler Project problem number 9.
 * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
 * 
 * a**2 + b**2 = c**2
 * ('**' denotes exponent, for which C does not have an operator like Fortran.)
 * 
 * For example, 3**2 + 4**2 = 9 + 16 = 25 = 5**2
 * 
 * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
 * Find the product abc.
 * 
 * This solution is simply a brute force, incremental calculation that should
 */

#include <stdio.h>
#include <math.h>
#define TARGET 1000.0

double calculate_c(int,int);
void
main()
{
  int a = 0, b = 0, c = 0;
  double tmp_c, sum;
  printf("Problem #9 Solution\n-------------------\n");
  a = 100;
  while( a <= 500 && c == 0 ){
    b = 1;
    while( b <= a && c ==0 ){
      tmp_c = calculate_c(a, b);
      sum = (double)a + (double)b + tmp_c;
      if(sum == TARGET){
        c = (int)tmp_c;
      }
      if(!c)
        ++b;
    }
    if(!c)
        ++a;
  }
  printf("a = %d; b = %d; c = %d; product = %d\n", a,b,c,(a*b*c));
}

double calculate_c(int a, int b)
{
  double c_sq;
  c_sq = pow((double)a ,2) + pow((double)b , 2);
  return sqrt(c_sq);
}
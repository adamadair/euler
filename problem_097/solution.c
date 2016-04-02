#include<stdio.h>
int
main(){
  int i = 0;
  long result = 1;
  for (i = 0; i < 7830457; i++)
  {
    result <<= 1;
    result %= 10000000000;
  }
  result *= 28433;
  result %= 10000000000;
  result += 1;
  printf("%ld\n",result);
}
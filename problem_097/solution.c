#include<stdio.h>
int
main(){
  int i = 0;
  long res = 1;
	for (i = 0; i < 7830457; i++)
	{
		res <<= 1;
		res %= 10000000000;
	}
	res *= 28433;
	res %= 10000000000;
	res += 1;
  printf("%ld\n",res);
}
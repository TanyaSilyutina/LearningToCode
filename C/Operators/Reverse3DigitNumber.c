#include <stdio.h>
 
 int main ()
 {
 	int d1, d2, d3, s1, s2, s3, input;

 	printf ("Enter a three-digit number: ");
 	scanf ("%d", &input);

 	d1 = input % 10;
 	s1 = input / 10;
 	d2 = s1 % 10;
 	s2 = s1 / 10;
 	d3 = s2 % 10;


 	printf ("The reversal is: %d%d%d", d1, d2, d3);

 	return 0;

 }
#include <stdio.h>

int main ()
{
	int a, b, c, d, max, min;

	printf ("Enter four digits: ");
	scanf ("%d %d %d %d", &a, &b, &c, &d);

	max = a; // max = 3
	min = a; // min = 3

	// 2 > 3 FALSE
	if(b > max)
		max = b;
	else if (b < min)
		min = b;

	// max = 3 and min = 2


	// 1 > 3
	if(c > max)
		max = c;
	else if (c < min)
		min = c;

	// max = 3 and min = 1


	// 4 > 3
	if(d > max)
		max = d;
	else if (d < min)
		min = d;

	// max = 4 and min = 1

	printf ("Smallest Number: %d\n", min);
	printf ("Largest Number: %d\n", max);


	return 0;
}
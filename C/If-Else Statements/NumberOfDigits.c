#include <stdio.h>

int main ()
{
	int number, digits;

	printf ("Enter a number: ");
	scanf ("%d", &number);

	if (number >= 1 && number <= 9)
		digits = 1;

	if (number >= 10 && number <= 99)
		digits = 2;

	if (number >= 100 && number <= 999)
		digits = 3;

	if (number >= 1000 && number <= 9999)
		digits = 4;


	printf ("The number %d has %d digits", number, digits);	


	return 0;
}
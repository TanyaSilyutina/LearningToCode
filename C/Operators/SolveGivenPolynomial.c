#include <stdio.h>

int main ()
{
	// Declaring variables
	float x;
	float x5, x4, x3, x2;
	float y;

	// Asking for user input
	printf ("Enter a value for x: ");
	scanf ("%f", &x);

	// Precalculating exponents
	x5 = x * x * x * x * x;
	x4 = x * x * x * x;
	x3 = x * x * x;
	x2 = x * x;

	// Calculating polynomial
	y = 3 * x5 + 2 * x4 - 5 * x3 - x2 + 7 * x - 6;

	// Printing out final output
	printf ("3x^5+2x^4-5x^3-x^2+7x-6 = %.2f", y);

	return 0;
}
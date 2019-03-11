#include <stdio.h>

int main ()
{
	int x, a, b, c, d, e, f;
	printf ("Enter a dollar amount: ");
	scanf ("%d", &x);

	a = x/20;
	b = x - (a * 20);
	c = b/10;
	d = b - (c * 10);
	e = d/5;
	f = x - (a * 20 + c * 10 + e * 5);

	printf ("$20 bills: %d\n", a);
	printf ("$10 bills: %d\n", c);
	printf (" $5 bills: %d\n", e);
	printf (" $1 bills: %d\n", f);

	return 0;
}
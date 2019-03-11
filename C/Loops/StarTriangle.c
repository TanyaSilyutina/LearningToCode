#include <stdio.h>

int main ()
{
	int stars;

	printf ("Enter the number of stars: ");
	scanf ("%d", &stars);

	for (int i = 1; i <= stars; ++i)
	{
		for (int j = 1; j <= i; ++j)
		{
			printf ("* ");
		}
		
		printf ("\n");
	}
	return 0;
}
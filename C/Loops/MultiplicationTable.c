#include <stdio.h>

int main ()
{
	int columns, rows;

	printf ("Enter number of rows: ");
	scanf ("%d", &rows);

	printf ("Enter number of columns: ");
	scanf ("%d", &columns);

	for (int i = 1; i <= rows; ++i)
	{
		printf ("\n");

		for (int j = 1; j <= columns; ++j)
		{
			printf ("%d ", i * j);
		}
	}

	return 0;
}
	
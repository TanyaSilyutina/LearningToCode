// 1st Step

/*

* * * * *

*/

// 2nd Step 

/*

* * * * *
* * * * *
* * * * *
* * * * *
* * * * *

*/

// 3rd Step

/*

* * * * *
* * * *
* * *
* *
*

*/

#include <stdio.h>

int main ()
{
	int stars;
		
	printf ("Enter the number of stars: ");
	scanf ("%d", &stars);

	for (int i = 0; i < stars; i++)
	{
		for (int j = 0; j < stars - i; j++)
		{	
			printf ("* ");
		}

		printf ("\n");
	} 

	return 0;
}
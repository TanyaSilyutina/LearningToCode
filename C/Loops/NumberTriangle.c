/*

Enter the number: 5
........1
.......22
......333
.....4444
....55555

*/

#include <stdio.h>

int main ()
{
	int n;

	printf ("Enter the number: ");
	scanf ("%d", &n);
 	
 	// pushing the loop to print numbers
	// if i = 1 then it'll work one by one 
	for (int i = 1; i <= n; ++i)
	{	
		// print docs max to min
		for (int j = n; i < j; --j) 
		{
			printf (".");	
		}

		printf ("%d", i); // print first 1 that is increased ev.time
 
 		// print the numbers after dots
		// k = 2 ev.time this loop reenters
		for (int k = 2; k <= i; k++)
		{
			printf("%d", i);
		}

		printf ("\n");
	}	
		

	return 0;
}

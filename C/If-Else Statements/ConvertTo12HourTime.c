#include <stdio.h>

int main ()
{
	// Declaring Variables
	int hh, mm, zero_check;

	// Getting user input for 24-hour time
	printf ("Enter a 24-hour time (hh:mm): ");
	scanf ("%d:%d", &hh, &mm);

	// Checking if minute is between 0 and 9
	if(mm >= 0 && mm <= 9)
		zero_check = 1;

	// Checking to see if time is in PM
	if (hh >= 12 && hh <= 23)
	{
		// Deduct 12 for time
		if(hh != 12)
			hh -= 12;

		// Checking if we need to add a zero before mm
		if(zero_check == 1)
	    	printf ("Equivalent 12-hour time: %d:0%d PM", hh, mm);
	    else	    
	    	printf ("Equivalent 12-hour time: %d:%d PM", hh, mm);
	}
	// Checking to see if time is in AM
	else
	{
		// Edge case for when hh is 0
		if (hh == 0)
			hh = 12;		

		// Checking if we need to add a zero before mm
		if (zero_check == 1)
			printf ("Equivalent 12-hour time: %d:0%d AM", hh, mm);  
		else	
			printf ("Equivalent 12-hour time: %d:%d AM", hh, mm);  
	}

	return 0;
}
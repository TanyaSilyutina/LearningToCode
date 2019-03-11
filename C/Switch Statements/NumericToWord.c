#include <stdio.h>

int main ()
{
	int number, second_number, number1;
	
	printf ("Enter a two-digit number: ");
	scanf ("%d", &number);

	number1 = number;

	
	if (number < 10 || number > 100)
	{
		printf ("Invalid number");
		return 0;
	}

	switch (number)
	{
		case 10:
		printf ("You entered the number: Ten"); return 0;
		case 11:
		printf ("You entered the number: Eleven"); return 0;
		case 12:
		printf ("You entered the number: Twelve"); return 0;
		case 13:
		printf ("You entered the number: Thirteen"); return 0;
	}
	
	printf ("You entered the number: ");

	if (number > 13 && number < 20)
	{
		number %= 10;

		switch (number)
		{
			case 9:
			printf ("Nineteen"); return 0;
			case 8:
			printf ("Eighteen"); return 0;
			case 7:
			printf ("Seventeen"); return 0;
			case 6:
			printf ("Sixteen"); return 0;
			case 5:
			printf("Fifteen"); return 0;
			case 4:
			printf ("Fourteen"); return 0;
		}
	}	

	number1 /= 10;	
	second_number = (number %= 10);

	switch (number1)
	{
		case 9:
		printf ("Ninety "); break;
		case 8:
		printf ("Eighty "); break;
		case 7:
		printf ("Seventy "); break;
		case 6:
		printf ("Sixty "); break;
		case 5:
		printf ("Fifty "); break;
		case 4:
		printf ("Fourty "); break;
		case 3:
		printf ("Thirty "); break;
		case 2:
		printf ("Twenty "); break;
	} 

	switch (second_number)
	{
		case 9:
		printf ("Nine"); break;
		case 8:
		printf ("Eight"); break;
		case 7:
		printf ("Seven"); break;
		case 6:
		printf ("Six"); break;
		case 5:
		printf ("Five"); break;
		case 4:
		printf ("Four"); break;
		case 3:
		printf ("Three"); break;
		case 2:
		printf ("Two"); break;
		case 1:
		printf ("One"); break;
	}


	return 0;
}
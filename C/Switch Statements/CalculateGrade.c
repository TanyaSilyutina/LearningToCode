#include <stdio.h>

int main ()
{
	int grade;

	printf("Enter numerical grade: ");
	scanf("%d", &grade);

	if (grade < 0 || grade > 100)
	{
		printf ("Illegal grade");
		return 0;
	}

	grade /= 10;

	switch (grade)  {
		case 9: case 10:
		printf ("Letter grade: A", grade); break;
		case 8:
		printf ("Letter grade: B", grade); break;
		case 7:
		printf ("Letter grade: C", grade); break;
		case 6:
		printf ("Letter grade: D", grade); break;
		case 5: case 4: case 3: case 2: case 1: case 0:
		printf ("Letter grade: F", grade); break;


	}


	return 0;
}
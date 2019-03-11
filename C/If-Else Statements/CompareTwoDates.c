#include <stdio.h>

int main ()
{

	int m1, m2, d1, d2, y1, y2;

	printf("Enter the first date (mm/dd/yy) : ");
	scanf ("%d/%d/%d", &m1, &d1, &y1);

	printf("Enter the second date (mm/dd/yy) : ");
	scanf ("%d/%d/%d", &m2, &d2, &y2);

	if(y2 != y1)
	{		
		if (y2 > y1)
			printf ("%d/%d/%d is earlier than %d/%d/%d", m1, d1, y1, m2, d2, y2);
		else 
			printf ("%d/%d/%d is earlier than %d/%d/%d", m2, d2, y2, m1, d1, y1);
	}
	else 
	{
		if(m2 != m1)
		{
			if (m2 > m1)
				printf ("%d/%d/%d is earlier than %d/%d/%d", m1, d1, y1, m2, d2, y2);
			else 
				printf ("%d/%d/%d is earlier than %d/%d/%d", m2, d2, y2, m1, d1, y1);			
		}
		else
		{
			if (d2 > d1)
				printf ("%d/%d/%d is earlier than %d/%d/%d", m1, d1, y1, m2, d2, y2);
			else 
				printf ("%d/%d/%d is earlier than %d/%d/%d", m2, d2, y2, m1, d1, y1);
		}

	}

	return 0;
}
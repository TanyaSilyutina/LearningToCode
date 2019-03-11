#include <stdio.h>

int main ()
{
	int radius = 10;
	float pi = 3.14f;
	float volume = 4.0f/3.0f * pi * radius * radius * radius;

	printf ("Radius: %d\n", radius);
	printf ("Volume of Sphere = 4/3 * %.2f * %d * %d * %d\n", pi, radius, radius, radius); 
	printf ("Calculated Volume = %.2f\n", volume);

	return 0;
}
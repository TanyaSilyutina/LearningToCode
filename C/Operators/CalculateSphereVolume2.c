#include <stdio.h> 

#define PI 3.14f // defining constant value of PI

// main function
int main () 
{
	// declaring variables for sphere's volume and radius
	float volume, r;

	printf ("Enter sphere radius: ");

	// getting user input for radius
	scanf ("%f", &r);

	// calculating volume of sphere
	volume = 4.0f/3.0f * PI * r * r * r;

	// printing final output
	printf ("Volume of sphere is: %.2f", volume);

	return 0;
}
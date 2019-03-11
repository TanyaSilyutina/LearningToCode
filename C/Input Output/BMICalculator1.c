#include <stdio.h>

int main ()
{
	float weight, height, BMI;

	printf ("Enter body weight (Kilograms): ");
	scanf ("%f", &weight);

	printf ("Enter body height (Centimeters): ");
	scanf ("%f", &height);

	BMI = weight/((height/100) * (height/100));

	printf ("Your BMI is: %.2f", BMI);
    
	return 0;
}
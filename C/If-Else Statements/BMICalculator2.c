#include <stdio.h>

int main ()
{
	float height, weight, BMI;

	printf ("Your height (centimeters): ");
	scanf ("%f", &height);

	printf ("Your weight (kilograms): ");
	scanf ("%f", &weight);

	BMI = weight / (height/100 * height/100);
	printf ("\nYour BMI is: %.2f \n", BMI);

	if (BMI < 18.5)
		printf ("\nUnderweight");
	else if (BMI >= 18.5 && BMI <= 24.9)
		printf ("\nNormal");
	else if (BMI >= 25 && BMI <= 29.9)
		printf ("\nOverweight");
	else if (BMI >= 30)
		printf ("Obese");

	
	return 0;
}
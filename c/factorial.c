#include <stdio.h>

double factorial(double n);
void main(int argc, char *argv[]) {
	// Make our scanner
	// Prompt the user for input, and store it in "user".
	//System.out.print("input a number to see how fast I go (factorials) : ");
	//int user = input.nextInt();
	double user = (double) argv[1];
	// Take user input, pass it to factorial method, and take the return, and store it in answer.
	double answer = factorial(user);
	// Print answer to the screen.
	printf("%f", answer);
}

double factorial(double n) {
	double total = 1;
	int i;
	for (i = 1; i <= n; i++) {
		total = total * i;
		printf("current total is: %f", total);
	}
	return total;
}


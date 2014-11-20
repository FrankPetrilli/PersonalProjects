#include <ctime>
#include <iostream>

using namespace std;

// Constants for program control.
// How many times should we calculate the value?
const int ITERATIONS = 5000000000;
// This factorial is what we'll calculate.
const int CALCULATE = 10;

// Blueprints for functions used in main.

long printTime(void);
long factorial1(int n);
long factorial2(int n);

int main(void)
{
	cout << "For loop:";
	printTime();
	int i = 1;
	for (i = 1; i <= ITERATIONS; i++) 
	{
		factorial1(CALCULATE);
	}
	// Print the answer it gets to make sure it's a valid value.
	long answer1 = factorial1(CALCULATE);
	cout << "\n" << answer1 << "\n";
	printTime();

	// Recursive verson:
	cout << "Recursive";
	printTime();
	for (i = 1; i <= ITERATIONS; i++)
	{
		factorial2(CALCULATE);
	}
	long answer2 = factorial2(CALCULATE);
	cout << "\n" << answer2 << "\n";
	printTime();
}

long printTime(void)
{
	// Gets the time in unix epoch, then prints to stdout.
	long sysTime = time(0);
	cout << "\n" << sysTime <<"\n\n";
}

long factorial1(int n)
{
	// Our poor algorithm for factorial calculation.
	long total = 1;
	for (int i = 1; i <= n; i++) 
	{
		total = total * i;
	}
	return total;
}

long factorial2(int n)
{
	// A much better way of doing it.
	if (n == 1)
	{
		return 1;
	} 
	else
	{
		return (n * factorial2(n - 1));
	}
}

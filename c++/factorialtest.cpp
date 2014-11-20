#include <ctime>
//get the system time (unix)
#include <iostream>
using namespace std;

const int ITERATIONS = 00000000;
const int CALCULATE = 10;

// Blueprints

long printTime(void);
long factorial1(int n);
long factorial2(int n);

int main(void)
{
	cout << "For loop";
	printTime();
	int i = 1;
	for (i = 1; i <= ITERATIONS; i++) 
	{
		factorial1(CALCULATE);
	}
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
	long sysTime = time(0);
	cout << "\n" << sysTime <<"\n\n";
}

long factorial1(int n)
{
	double total = 1;
	for (int i = 1; i <= n; i++) 
	{
		total = total * i;
	}
	return total;
}

long factorial2(int n)
{
	if (n == 1)
	{
		return 1;
	} 
	else
	{
		return (n * factorial2(n - 1));
	}
}

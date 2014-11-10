// Find largest prime factor of a number.
#include <stdio.h>
#include <stdbool.h>
#include <math.h>

//#define NUMBER 600851475143
#define NUMBER 13195

// Function prototypes.

bool isPrime(int num);
bool isFactor(int num);
int main(int argc, char *argv[])
{
	int i;
	int biggestPrime = 0;
	for (i = 1; i < NUMBER; i++) 
	{
		if (isFactor(i))
		{
			if (isPrime(i))
			{
				printf("%d is prime\n", i);
				biggestPrime = fmax(i,biggestPrime);
			}
		}
	}
	printf("Biggest prime of %d is %d.\n", NUMBER, biggestPrime);
	return 0;
}

bool isPrime(int num)
{
	int i;
	int countFactors = 0;
	for (i = 1; i < num; i++)
	{
		if (num % i == 0.0)
		{
			countFactors++;
		}
	}
	return (countFactors == 2);
}

bool isFactor(int num)
{
	printf("Checking whether %d is factor...", num);
	return (NUMBER % num == 0.0);
}

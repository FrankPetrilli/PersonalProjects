#include <stdio.h>

int main(void)
{
	int i = 0;
	for (i = 1; i <= 100; i++)
	{
		if (!(i % 15 == 0))
		{
			printf("FizzBuzz");
		}
		else if (!(i % 3 == 0))
		{
			printf("Fizz");
		}
		else if (!(i % 5 == 0))
		{
			printf("Buzz");
		}
	}
	return 0;
}

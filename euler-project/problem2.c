// Fibonacci
#include <stdio.h>
#include <stdbool.h>

int main(int argc, char *argv[])
{
	//int sum = 0;
	long sum = 0;
	// Fibonacci vars
	int first = 0, second = 1, next, i;
	//for (i = 0; i < 20; i++) 
	i = 0;
	while (next < 4000000)
	{
		if (i <= 1)
		{
			next = i;
		}
		else
		{
			next = first + second;
			if (next > 4000000) break;
			first = second;
			second = next;
		}
		//printf("%d\n",next);
		if (next % 2 == 0)
		{
			sum = sum + next;
		}
	i++;
	}
	printf("Sum is: %d\n",sum);
}

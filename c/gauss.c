#include <stdio.h>
int main()
{
	int sum = 0;
	int i;
	for (i = 1; i <= 1000; i++)
	{
		sum = sum + i;
	}
	printf("%d\n",sum);
	return(0);
}

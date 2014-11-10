#include <stdio.h>
#include <stdbool.h>
int main(int argc, char *argv[])
{
	int i;
	int sum = 0;
	for (i = 1; i < 1000; i++)
	{
		/*bool flag1 = false;
		bool flag2 = false;
		if (i % 3 == 0) flag1 = true;
		if (i % 5 == 0) flag2 = true;

		if (flag1 || flag2) {
		*/
		if ((i % 3 == 0) || (i % 5 == 0)) {
			//printf("%d", i);
			sum += i;
		}
	} 
	printf("Sum is: %d\n", sum);
	return 0;
}

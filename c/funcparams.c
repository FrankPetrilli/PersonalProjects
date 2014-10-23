#include <stdio.h>
void main(void)
{
	int a, b, total;
	printf("Enter a: ");
	scanf("%d",&a);
	printf("Enter b: ");
	scanf("%d",&b);
	total = sum(a, b);
	printf("Total is: %d\n",total);
}
int sum(int a, int b)
{
	return a + b;
}

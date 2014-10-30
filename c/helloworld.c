#include <stdio.h>
void main(int argc, char *argv[]) 
{
	int i;
	for (i = 1; i <= argc; i++)
	{
		printf("\n");
		printf(argv[i]);
	}
	printf("Hello world!\n"); 
}

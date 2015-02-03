/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Language: C++
 * Calling the libc.getcwd() function from C++.
 */

#include <unistd.h>
#include <stdio.h>

int main(void)
{
	char cwd[1024];
	if (getcwd(cwd, sizeof(cwd)) != NULL)
	{
		fprintf(stdout, "%s\n", cwd);
		return 0;
	} else {
		fprintf(stderr, "getcwd failed\n");
		return 1;
	}
}


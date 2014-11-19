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
		fprintf(stderr, "getcwd failed.");
		return 1;
	}
}


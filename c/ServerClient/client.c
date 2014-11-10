#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <arpa/inet.h>
#include <sys/types.h>
#include <netinet/in.h>
#include <sys/socket.h>

#define MAXRECEIVELENGTH 500
#define PORTNUM 5000

int main(int argc, char *argv[])
{
	char buffer[MAXRECEIVELENGTH + 1];
	int length, mysocket;
	// Use the struct sockaddr_in(ternet) named dest.
	struct sockaddr_in dest;

	// IP, Stream transmission (TCP), protocol 0 since there isn't another.
	mysocket = socket(AF_INET, SOCK_STREAM, 0);

	memset(&dest, 0, sizeof(dest));
	dest.sin_family = AF_INET;
	dest.sin_addr.s_addr = htonl(INADDR_LOOPBACK);
	dest.sin_port = htons(PORTNUM);

	connect(mysocket, (struct sockaddr *)&dest, sizeof(struct sockaddr));

	length = recv(mysocket, buffer, MAXRECEIVELENGTH, 0);

	buffer[length] = '\0';

	printf("Received %s (%d bytes).\n", buffer, length);
	close(mysocket);
	return EXIT_SUCCESS;
}

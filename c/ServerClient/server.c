#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <arpa/inet.h>
#include <sys/types.h>
#include <netinet/in.h>
#include <sys/socket.h>
 
#define PORTNUM 5000

int main(int argc, char *argv[])
{
	//char msg[] = "Hello world!\n";
	//char msg[] = "echo helloworld;";

	struct sockaddr_in dest;
	struct sockaddr_in serv;

	int mysocket;
	socklen_t socksize = sizeof(struct sockaddr_in);

	memset(&serv, 0, sizeof(serv));
	serv.sin_family = AF_INET;
	serv.sin_addr.s_addr = htonl(INADDR_ANY);
	serv.sin_port = htons(PORTNUM);

	mysocket = socket(AF_INET, SOCK_STREAM, 0);

	bind(mysocket, (struct sockaddr *)&serv, sizeof(struct sockaddr));

	listen(mysocket, 1);
	int consocket = accept(mysocket, (struct sockaddr *)&dest, &socksize);

	while (consocket)
	{
		printf("Connection from %s - Sending message", inet_ntoa(dest.sin_addr));
		char msg[500];
		printf("\nEnter your command here: ");
		scanf("%s", &msg);
		send(consocket, msg, strlen(msg), 0);
		close(consocket);
		consocket = accept(mysocket, (struct sockaddr *)&dest, &socksize);
	}

	close (mysocket);
	close(consocket);
	return EXIT_SUCCESS;
}


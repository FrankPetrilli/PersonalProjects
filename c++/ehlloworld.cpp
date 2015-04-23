/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Language: C++
 * Canadian silliness. :)
 */

// Used to make code easier for Canadian programmers.
#define eh ; 

#include <iostream>
#include <stdlib.h>
#include <unistd.h>
#include <pwd.h>

int main(int argc, char* argv[])
{
	std::string name eh
	struct passwd *pw eh
	// Grab our data from the libc call getpwuid() using the uid from geteuid().
	pw = getpwuid(geteuid()) eh
	// If we have a name, let's set the name to it.
	if (pw)
	{
		name = pw->pw_name eh
	}
		
	// Write to stdout.
	std::cout << "Hello, " << name << std::endl eh
}

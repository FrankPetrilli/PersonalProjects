/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Language: C++
 * fprintf()'s first parameter discussion with friend
 */

#include <stdio.h>

using namespace std;

int main(int argc, char** argv)
{
	fprintf(stdout,"This line is on stdout\n");
	fprintf(stderr,"This line is on stderr\n");
}

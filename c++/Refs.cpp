/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Language: C++
 * Pointers and references
 *
 * & = Address of
 * * = Dereference
 */

#include <iostream>

using namespace std;

int main(int argc, char **argv)
{
	int valueone = 10;
	int valuetwo = 20;

	int *mypointer;

	mypointer = &valueone;
	*mypointer = 11;
	mypointer = &valuetwo;
	*mypointer = 21;

	cout << "value one is: " << valueone << '\n';
	cout << "value two is: " << valuetwo << '\n';

	return 0;
}

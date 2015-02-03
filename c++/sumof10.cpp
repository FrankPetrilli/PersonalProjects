/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Language: C++
 * Using a for loop to show efficiency in code. Prompts for ten numbers, then sums them.
 */

#include <iostream>
#include <sstream>
#include <string>
#include <cstdlib>

using namespace std;

int main(void) 
{

	int sum;
	int numbers[10];
	int i = 0;

	for (i = 0; i < 10; i++) 
	{
		cout << "\nenter number #" << i+1 << ": ";
		cin >> numbers[i];
	}

	for (i = 0; i < 10; i++) 
	{
		sum += numbers[i];
	}
	
	cout << sum << "\n";

	return 0;
}

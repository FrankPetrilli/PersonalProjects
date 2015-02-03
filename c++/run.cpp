/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Language: C++
 * Personal program launcher
 */

#include <iostream>
#include <sstream>
#include <string>
#include <cstdlib>

using namespace std;

int main(void) 
{

	int action;

	bool exit;
	do {
		cout << "What do you want to do?\n";
		cout << "Action list:\n\n";

		cout << "1) email\n";
		cout << "2) homework\n";

		cout << "Enter action (-1 to exit): ";
		cin >> action;
		switch (action) 
		{
			case 1: 
				cout << "Email running\n";
				system("mutt");
				break;

			case 2:
				system("vim -c ':cd ~/UW-CSE-142/homework/'");
				break;

			case (-1):
				exit = true;
				break;
			default:
				cout << "Try again\n";
				break;
		}
	} while (!exit);
}

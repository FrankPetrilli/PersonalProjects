/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Language: C++
 * String reverser using a stack.
 */

#include <stdio.h>
#include <iostream>
#include <stack>
#include <string>

using namespace std;

int main(int argc, char** argv)
{
	stack<char> s;

	string input;

	if (argc == 2)
	{
		input = argv[1];
	}
	else
	{
		cout << "Enter a word: ";
		getline(cin,input);
	}

	for (int i = 0; i < input.size(); i++) {
		s.push(input.at(i));
	}

	while (!s.empty()) {
		cout << s.top();
		s.pop();
	}
	cout << "\n";
	return 0;
}

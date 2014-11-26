/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Hello world objective in C++. Completely unnecessary, but why not?
 * 11/25/2014
*/

#include <iostream>
#include <sstream>
#include <string>
#include <fstream>

using namespace std;

class HelloWorld {
	public:
		HelloWorld()
		{
		}
		void printHelloWorld()
		{
			cout << "Hello world!";
			ofstream helloWorldFile;
			helloWorldFile.open("helloworld.txt");
			helloWorldFile << "Hello world!";
			helloWorldFile.close();
		}
};

int main(int argc, char **argv)
{
	HelloWorld helloworld = HelloWorld();
	helloworld.printHelloWorld();
	return 0;
}

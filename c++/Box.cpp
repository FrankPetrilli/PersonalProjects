/*
 * Frank Petrilli | frank@petril.li | http://frank.petril.li/
 * Language: C++
 * "Box" object and method for calculating volume.
*/

#include <iostream>
#include <sstream>
#include <string>

using namespace std;


class Box
{
	public:
		double length;
		double width;
		double height;

		Box(int h, int w, int l)
		{
			this->height = h;
			this->width = w;
			this->length = l;
		}

		double volume(void)
		{
			return this->length * this->width * this->height;
		}
};

int main(void)
{
	// Construct our box.
	Box box1 (10, 13, 12);
	// Calculate its volume and output to Stdout.
	cout << "volume of box is: " << box1.volume() << "\n";
}

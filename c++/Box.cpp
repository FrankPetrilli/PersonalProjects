/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Language: C++
 * "Box" object and method for calculating volume.
 */

#include <iostream>
#include <sstream>
#include <string>

using namespace std;


class Box
{
	private:
		double length;
		double width;
		double height;

	public:
		Box(int length, int width, int height)
		{
			this->length = length;
			this->width = width;
			this->height = height;
		}

		double volume(void)
		{
			return length * width * height;
		}
};

int main(void)
{
	// Construct our box.
	Box box1 (12, 13, 10);
	// Calculate its volume and output to Stdout.
	cout << "volume of box is: " << box1.volume() << "\n";
}

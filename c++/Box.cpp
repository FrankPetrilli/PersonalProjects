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

		double volume(void)
		{
			return this->length * this->width * this->height;
		}

};

int main(void)
{
	Box box1;

	box1.height = 10;
	box1.width = 13;
	box1.length = 12;

	//cout << "volume" << box1.height * box1.width * box1.length << end1;
	cout << "volume of box is: " << box1.volume() << "\n";
}

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
	Box box1 (10, 13, 12);

	/*box1.height = 10;
	box1.width = 13;
	box1.length = 12;*/

	//cout << "volume" << box1.height * box1.width * box1.length << end1;
	cout << "volume of box is: " << box1.volume() << "\n";
}

/*
 * Frank Petrilli | frank@petril.li | http://frank.petril.li/
 * Language: C++
 * Object-oriented 3D distance calculator
*/

#include <iostream>
#include <sstream>
#include <string>
#include <math.h>

using namespace std;


class Point
{
        private:

        public:
                double x;
                double y;
                double z;

                Point(int x, int y, int z)
                {
                        this->x = x;
                        this->y = y;
                        this->z = z;
                }
		
		double distance(Point other)
		{
			double diffx = pow(other.x - x, 2);
			double diffy = pow(other.y - y, 2);
			double diffz = pow(other.z - z, 2);
			
			return pow(diffx + diffy + diffz, .5);
		}
};

int main(void)
{
	cout << "Point 1:" << "\n";
	cout << "\n" << "Point 1 x: ";
	double x1;
	cin >> x1;
	cout << "\n" << "Point 1 y: ";
	double y1;
	cin >> y1;
	cout << "\n" << "Point 1 z: ";
	double z1;
	cin >> z1;

	Point point1(x1, y1, z1);
	
	cout << "\n--------\n";
	cout << "\n" << "Point 2:" << "\n";

	cout << "\n" << "Point 2 x: ";
	double x2;
	cin >> x2;
	cout << "\n" << "Point 2 y: ";
	double y2;
	cin >> y2;
	cout << "\n" << "Point 2 z: ";
	double z2;
	cin >> z2;

	Point point2(x2, y2, z2);

        cout << "distance from point 1 to point 2 is: " << point1.distance(point2) << "\n";
}


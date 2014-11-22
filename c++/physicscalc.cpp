#include <iostream>
#include <sstream>
#include <string>

using namespace std;

int main(int argc, char *argv[])
{
	int action;
        bool exit;
	char null[1];
        
	do {
                cout << "What do you want to calculate?\n";
                cout << "Action list:\n\n";

                cout << "1) force\n";
                cout << "2) linear velocity\n";

                cout << "Enter action (-1 to exit): ";
                cin >> action;
                switch (action)
                {
                        case 1:
				double mass, accel;
				cout << "Enter mass: ";
				cin >> mass;
				cout << "Enter acceleration: ";
				cin >> accel;
				
				cout << "Force exerted = " << mass * accel << "\n";
                                break;

                        case 2:
				double rpm;
				cout << "Enter RPM: ";
				cin >> rpm;
				
				cout << rpm*2*3.14 << " radians/second\n";
				cin >> null;
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

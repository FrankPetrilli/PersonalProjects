#include <iostream>
#include <queue>

using namespace std;

int main(int argc, char** argv)
{
	queue<int> q;
	int input;
	cout << "Enter an integer per line. 0 will end: \n";

	do {
		cin >> input;
		q.push(input);
	} while (input != 0);

	cout << "Queue contains: \n";

	while (!q.empty()) {
		cout << ' ' << q.front();
		q.pop();
	}
	cout << '\n';

	return 0;
}

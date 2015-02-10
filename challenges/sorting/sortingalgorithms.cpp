#include <stdlib.h>
#include <vector>
#include <time.h>
#include <algorithm>
#include <iostream>

using namespace std;

int main(int argc, char* argv[])
{
	vector<int> myvector;
	srand((unsigned)time(NULL));

	for (int i = 0; i < 10000000; i++)
	{
		int randomnumber = rand() % 10000;
		myvector.push_back(randomnumber);
	}

	std::sort(myvector.begin(),myvector.end());

	for (int i = 0; i < myvector.size(); i++)
	{
		cout << myvector[i] << ", ";
	}
}

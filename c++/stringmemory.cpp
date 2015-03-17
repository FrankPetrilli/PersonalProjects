/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Language: C++
 * String memory allocator
 * An exaggerated version of this:
 * https://groups.google.com/a/chromium.org/forum/#!msg/chromium-dev/EUqoIz2iFU4/kPZ5ZK0K3gEJ
 * Keep in mind that the string objects in the Chrome browser are likely temporal.
 */

#include <string>

#define STRING_COUNT 25000

int main(int argc, char* argv[])
{
	// Keep an array of pointers to our new objects.
	std::string* allocated_strings[STRING_COUNT];

	// Allocate the given number of empty std::strings in a group
	for (int i = 0; i < STRING_COUNT; i++)
	{
		allocated_strings[i] = new std::string;
	}
	// Now destroy them together too.
	for (int i = 0; i < STRING_COUNT; i++)
	{
		delete allocated_strings[i];
	}
}


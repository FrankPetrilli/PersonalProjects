/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Language: C++
 * String memory allocator
 * An exaggerated version of this:
 * https://groups.google.com/a/chromium.org/forum/#!msg/chromium-dev/EUqoIz2iFU4/kPZ5ZK0K3gEJ
 * Keep in mind that the string objects in the Chrome browser are likely temporal, and that
 * they'd actually contain something, so this is a completely flawed test. It's just interesting
 * to see how much memory a string on the heap takes up.
 */

#include <string>
#include <stdlib.h>
#include <unistd.h>
#include <pthread.h>

#define STRING_COUNT 25000 // Per-thread
#define NUM_THREADS 4

static void* do_stuff(void* input)
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

int main(int argc, char* argv[])
{
	pthread_t threads[NUM_THREADS];
	int returns[NUM_THREADS];
	for (int i = 0; i < NUM_THREADS; i++) {
		returns[i] = pthread_create( &threads[i], NULL, do_stuff, (void*)NULL);
	}
	for (int i = 0; i < NUM_THREADS; i++) {
		pthread_join(threads[i], NULL);
	}
}


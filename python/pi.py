#!/usr/bin/python3
import math
def main():
    for i in range(3, 50):
        print ()
	# Calculate angle via 360/(# sides, with sides coming from for loop)
        angle = (360/i)
	# Convert our angle to radians, as the math.sin function wants radians, not degrees.
        radians = math.radians(angle)
	# The length of one side is 2*sin(half the angle)
        oneside = (2*math.sin(radians/2))
	# Perimeter is the length of one side multiplied by number of all sides. 
        perimeter = (oneside*i)
	# And the estimation of pi is perimeter divided by two.
        pi = (perimeter/2)
	# Python is typed, so we need to convert the integers and floats to strings so we can concatenate. 
	# Once that's done, we just print it out. I used 3-50 as the for loop for arbitrary reasons.
        print ("When the polygon has " + str(i) + " sides, π is " + str(pi))
# And let's go ahead and run this function.
main()

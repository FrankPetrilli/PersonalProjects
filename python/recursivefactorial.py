#!/usr/bin/python3
import math
def main():
	number = input("Enter a factorial to calculate: ");
	print(number + "! = ",factorial(int(number)));
def factorial(n):
	if n < 1:
		return 1;
	else:
		return n * factorial(n - 1);
main()

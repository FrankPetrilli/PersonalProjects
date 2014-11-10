import java.util.*;
import java.io.*;
public class Factorial {
	public static void main(String[] args) {
		// Make our scanner
		Scanner input = new Scanner(System.in);
		// Prompt the user for input, and store it in "user".
		System.out.print("input a number to see how fast I go (factorials) : ");
		int user = input.nextInt();
		// Take user input, pass it to factorial method, and take the return, and store it in answer.
		double answer = factorial(user);
		// Print answer to the screen.
		System.out.println(answer);
	}

	public static double factorial(int n) {
		double total = 1;
		for (int i = 1; i <= n; i++) {
			total = total * i;
			System.out.println("current total is: " + total);
		}
		return total;
	}
}

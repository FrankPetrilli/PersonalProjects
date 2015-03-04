import java.util.*;
import java.io.*;

public class SingleThread {
	public static void main(String[] args) throws FileNotFoundException {
		Scanner input = new Scanner(new File("factorialstoprocess.txt"));
		int val = 1;
		long initialTime = System.currentTimeMillis();
		while (val > 0) {
			val = input.nextInt();
			//System.out.println("\tResult of " + val + " is: " + factorial(val));
			//factorial(val);
			wasteTime(val);
		}
		System.out.println((System.currentTimeMillis() - initialTime) + "ms");
	}

	private static long factorial(int n) {
		if (n < 1) {
			return 1;
		} else {
			return n * factorial(n - 1);
		}
	}

	private static long wasteTime(int n) {
		double number = n;
		for (int i = 0; i < 10000; i++) {
			number /= 10;
			number *= 10;
		}
		return (long)number;
	}
}

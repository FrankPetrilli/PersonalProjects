import java.util.*;

public class RandomWord {

	private static int LENGTH = 1000000;

	public static void main(String[] args) {
		Random r = new Random();
		String output = "";
		for (int i = 0; i < LENGTH; i++) {
			char nextchar = (char)(r.nextInt(26) + 'a');
			output += nextchar;
		}
		System.out.println(output);
	}
}


import java.util.*;

public class StackReverseString {
	public static void main(String[] args) {
		Stack<Character> s = new Stack<Character>();

		System.out.print("Enter a string: ");
		Scanner input = new Scanner(System.in);

		String userInput = input.next();
		System.out.println();

		for (int i = 0; i < userInput.length(); i++) {
			s.push(userInput.charAt(i));
		}

		while (!s.isEmpty()) {
			System.out.print(s.pop());
		}
		System.out.println();
	}
}

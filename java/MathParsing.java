import java.util.Scanner;

public class MathParsing {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		System.out.print("Enter a math expression: ");
		String testString = input.nextLine();
		double answer = eval(testString);

		System.out.print("Enter what you think the answer is: ");
		double testAnswer = Integer.parseInt(input.nextLine());

		if (testAnswer == answer) {
			System.out.println("You're right!");
		} else {
			System.out.println("Try again!");
		}
	}
/* ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- */
	public static double eval(final String str) {
		class Parser {
			int pos = -1, c;

			void eatChar() {
				c = (++pos < str.length()) ? str.charAt(pos) : -1;
			}

			void eatSpace() {
				while (Character.isWhitespace(c)) eatChar();
			}

			double parse() {
				eatChar();
				double v = parseExpression();
				if (c != -1) throw new RuntimeException("Unexpected: " + (char)c);
				return v;
			}

			// Grammar:
			// expression = term | expression `+` term | expression `-` term
			// term = factor | term `*` factor | term `/` factor | term brackets
			// factor = brackets | number | factor `^` factor
			// brackets = `(` expression `)`

			double parseExpression() {
				double v = parseTerm();
				for (;;) {
					eatSpace();
					if (c == '+') { // addition
						eatChar();
						v += parseTerm();
					} else if (c == '-') { // subtraction
						eatChar();
						v -= parseTerm();
					} else {
						return v;
					}
				}
			}

			double parseTerm() {
				double v = parseFactor();
				for (;;) {
					eatSpace();
					if (c == '/') { // division
						eatChar();
						v /= parseFactor();
					} else if (c == '*' || c == '(') { // multiplication
						if (c == '*') eatChar();
						v *= parseFactor();
					} else {
						return v;
					}
				}
			}

			double parseFactor() {
				double v;
				boolean negate = false;
				eatSpace();
				if (c == '(') { // brackets
					eatChar();
					v = parseExpression();
					if (c == ')') eatChar();
				} else { // numbers
					if (c == '+' || c == '-') { // unary plus & minus
						negate = c == '-';
						eatChar();
						eatSpace();
					}
					StringBuilder sb = new StringBuilder();
					while ((c >= '0' && c <= '9') || c == '.') {
						sb.append((char)c);
						eatChar();
					}
					if (sb.length() == 0) throw new RuntimeException("Unexpected: " + (char)c);
					v = Double.parseDouble(sb.toString());
				}
				eatSpace();
				if (c == '^') { // exponentiation
					eatChar();
					v = Math.pow(v, parseFactor());
				}
				if (negate) v = -v; // exponentiation has higher priority than unary minus: -3^2=-9
				return v;
			}
		}
		return new Parser().parse();
	}
}

import java.util.*;
import java.io.*;

public class GenerateNumbers {
	public static void main(String[] args) throws FileNotFoundException {
		Random r = new Random();
		PrintWriter output = new PrintWriter(new File("factorialstoprocess.txt"));
		for (int i = 0; i < 500000; i++) {
			output.print(Integer.toString(r.nextInt(15) + 1) + " ");
		}
		output.print("0");
		output.flush();
		output.close();
	}
}

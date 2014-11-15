import java.util.*;
import java.io.*;
import java.net.URL;
public class URLScanner {
	public static void main(String[] args) throws IOException {
		String URL;
		if (args.length > 0) {
			URL = args[0];
		} else {
			Scanner console = new Scanner(System.in);
			System.out.print("Website: ");
			URL = console.next();
		}

		Scanner web = new Scanner(new URL(URL).openStream());

		while (web.hasNextLine()) {
			System.out.println(web.nextLine());
		}
	}
}


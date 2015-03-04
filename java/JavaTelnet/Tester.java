import java.io.*;
public class Tester implements ReceiveHandler {
	public static void main(String[] args) throws IOException, InterruptedException {
		Tester me = new Tester();
	}

	public Tester() throws IOException, InterruptedException {
		TelnetServer server = new TelnetServer(this, 8080);
		server.run();
		while (true) {
			Thread.sleep(50);
		}
	}

	public void takeInput(String input) {
		System.out.println("Handled user input: " + input);
	}
}

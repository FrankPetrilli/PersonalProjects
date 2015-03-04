import java.net.*;
import java.util.*;
import java.io.*;
public class ClientThread implements Runnable {

	private Socket socket;
	private TelnetServer server;
	private boolean exit;
	private String threadID;

	public ClientThread (Socket socket, TelnetServer server) throws IOException {
		this.socket = socket;
		this.server = server;
		this.exit = false;
		this.threadID = Integer.toString(new Random().nextInt(1000000));
	}

	public void run() {
		while (!exit) {
			BufferedReader inFromClient = null;
			try {
				inFromClient = new BufferedReader(new InputStreamReader(socket.getInputStream()));
				while (!inFromClient.ready()) {}
				System.out.println(threadID + " - User input: " + inFromClient.readLine());
			} catch (Exception e) {
				try {
					Thread.sleep(10);
				} catch (Exception e2) {
					System.out.println("Can't sleep.");
				}
			}
		}
	}

	public void shutdown() {
		exit = true;
	}
}

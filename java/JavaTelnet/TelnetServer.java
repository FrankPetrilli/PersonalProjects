/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Language: Java
 * Telnet thread class.
 */
import java.io.*;
import java.util.*;
import java.net.*;

public class TelnetServer implements Runnable {

	private int port;
	private ReceiveHandler handler;
	private ServerSocket server;
	private Socket socket;
	private boolean exit;

	public TelnetServer(ReceiveHandler handler, int port) throws IOException {
		this.handler = handler;
		this.port = port;
		this.server = new ServerSocket(port);
	}

	public void run() {
		while (!exit) {
			try {
				System.out.println("[server] waiting for connection...");
				socket = server.accept();
				System.out.println("[debug] New connection from " + socket.toString());
				Thread t = new Thread(new ClientThread(socket, this));
				t.start();
				System.out.println("[server] connection from " + socket.toString() + " handled.");
			} catch (Exception e) {
				System.out.println("Can't accept new clients. " + e.getMessage());
			}
		}
	}

	public void shutdown() {
		exit = true;
	}
}

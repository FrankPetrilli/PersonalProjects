import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.Scanner;
import java.io.*;

public class MyScheduler {

	public static void main(String[] args) throws FileNotFoundException {
		//Scanner console = new Scanner(System.in);
		Scanner console = new Scanner(new File("factorialstoprocess.txt"));
		int processors = Runtime.getRuntime().availableProcessors();
		//int processors = 100;
		ExecutorService executor = Executors.newFixedThreadPool(processors);
		int input = 1;
		long initialTime = System.currentTimeMillis();
		while (input > 0) {
			input = console.nextInt();
			if (input > 0) {
				Runnable worker = new WorkerThread(input);
				executor.execute(worker);
			}
		}
		executor.shutdown();
		while (!executor.isTerminated()) {
		}
		System.out.println((System.currentTimeMillis() - initialTime) + "ms");
		System.out.println("Finished all threads.");
	}
}

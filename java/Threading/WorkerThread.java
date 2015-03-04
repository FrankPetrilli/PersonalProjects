public class WorkerThread implements Runnable {
	private int calculate;

	public WorkerThread(int n) {
		calculate = n;
	}

	public void run() {
		//System.out.println("[debug] Starting thread for " + calculate + ".");
		try {
			//Thread.sleep(1000);
		} catch (Exception e) {
			System.out.println("Can't sleep.");
		}
		//long result = factorial(calculate);
		wasteTime(calculate);
		//System.out.println("\tResult of " + calculate + " is: " + result);
	}

	private long factorial(int n) {
		if (n < 1) {
			return 1;
		} else {
			return n * factorial(n - 1);
		}
	}

	private long wasteTime(int n) {
		double number = n;
		for (int i = 0; i < 10000; i++) {
			number /= 10;
			number *= 10;
		}
		return (long)number;
	}
}

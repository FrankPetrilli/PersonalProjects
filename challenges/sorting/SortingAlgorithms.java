import java.util.*;

public class SortingAlgorithms {
	public static void main(String[] args) {
		List<Integer> list = new ArrayList<Integer>();
		Random r = new Random();

		for (int i = 0; i < 10000000; i++) {
			int randomNumber = r.nextInt(10000);
			list.add(randomNumber);
		}

		Collections.sort(list);

		for (int i = 0; i < list.size(); i++) {
			System.out.print(list.get(i) + ", ");
		}
	}
}

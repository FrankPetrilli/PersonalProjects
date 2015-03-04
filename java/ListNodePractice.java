public class ListNodePractice {
	public static void main(String[] args) {
		ListNode list = new ListNode(1);
		ListNode list2 = new ListNode(2, new ListNode(3, new ListNode(4)));

		ListNode temp;

		list2.next.next.next = list; // 4 points to 1
		list.next = list2; // 1 points to 2

		temp = list2.next; // temp points to 3
		list = list2.next.next; // list points to 4 (I had it where list points to 1)
		list2 = temp;
		list.next.next.next = null;
		list2.next = null;

		printList(list);
		printList(list2);
	}

	public static void printList(ListNode list) {
		int count = 0;
		while (list != null && count < 15) {
			System.out.print(list);
			System.out.print("->");
			list = list.next;
			if (list == null) {
				System.out.print("[/]");
			}
			count++;
			if (count == 15) {
				System.out.println("reached limit");
				return;
			}
		}
		System.out.println();
	}
}

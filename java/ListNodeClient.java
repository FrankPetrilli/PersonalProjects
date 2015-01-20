public class ListNodeClient {
	public static void main(String[] args) {
		ListNode list = new ListNode(1);
		list.next = new ListNode(2);
		System.out.println(list.toEnd());
	}
}

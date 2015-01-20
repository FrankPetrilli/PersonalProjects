public class ListNode {
	public int value;
	public ListNode next;

	public ListNode(int value, ListNode next) {
		this.value = value;
		this.next = next;
	}

	public ListNode(int value) {
		this.value = value;
		this.next = null;
	}

	public String toEnd() {
		ListNode myNode = null;
		String result = "";
		do {
			if (myNode == null) {
				myNode = this;
			} else {
				myNode = myNode.next;
			}

			if (myNode != null) {
				result += myNode;
				result += "\n";
			}
		} while (myNode != null);
		return result;
	}

	public String toString() {
		return Integer.toString(value);
	}
}

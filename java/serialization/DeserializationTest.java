import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.io.FileNotFoundException;

import java.util.List;
import java.util.ArrayList;

public class DeserializationTest {
	public static void main(String[] args) {

		List<Person> list = null;

		String fileName = "list.ser";
		try {
			FileInputStream fos;
			ObjectInputStream in;
			fos = new FileInputStream(fileName);
			in = new ObjectInputStream(fos);
			list = (List) in.readObject();
			in.close();
		} catch (Exception ex) {
		}
		System.out.println(list);
	}
}


class Person implements Serializable {

	public String name;
	public int age;
	public String email;

	public Person(String name, int age, String email) {
		this.name = name;
		this.age = age;
		this.email = email;
	}

	public String toString() {
		return name + ": " + age + " years old. " + email;
	}
}

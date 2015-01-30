using System;

public class DistanceCalcClient
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Point 1:\n");
		Console.Write("x: ");
		double x1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("y: ");
		double y1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("z: ");
		double z1 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Point 2:\n");
		Console.Write("x: ");
		double x2 = Convert.ToDouble(Console.ReadLine());
		Console.Write("y: ");
		double y2 = Convert.ToDouble(Console.ReadLine());
		Console.Write("z: ");
		double z2 = Convert.ToDouble(Console.ReadLine());

		Point point1 = new Point(x1, y1, z1);
		Point point2 = new Point(x2, y2, z2);	

		Console.WriteLine("Distance from Point 1 to Point 2 is: " + point1.DistanceFrom(point2));
	}
}

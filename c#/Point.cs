/*
 * Frank Petrilli | frank@petril.li | http://frank.petril.li/
 * Language: C#
 * Object-oriented 3D distance calculator
*/

using System;

public class Point
{
	private double x, y, z;

	public Point(double x, double y, double z)
	{
		this.x = x;
		this.y = y;
		this.z = z;
	}

	public double DistanceFrom(Point other)
	{
		double diffx = Math.Pow(other.x - x, 2);
		double diffy = Math.Pow(other.y - y, 2);
		double diffz = Math.Pow(other.z - z, 2);

		return Math.Pow(diffx + diffy + diffz, .5);
	}

	public double DistanceFromOrigin()
	{
		Point origin = new Point(0, 0, 0);
		return this.DistanceFrom(origin);
	}

	public override string ToString()
	{
		return x + ", " + y + ", " + z;
	}
}


using System;

public class theta
{
	public static double GetTheta ( Point A, Point B)
	{
		double dx, dy, ax, ay;
		double t;
		dx = B.X - A.X;
		dy = B.Y - A.Y;
		ax = Math.Abs (dx);
		ay = Math.Abs (dy);

		if (ax == 0 && ay == 0) t = 0;
		else t = dy/(ax+ay);
		if (dx < 0) t = 2 - t;
		else if (dy < 0) t = 4 + t;

		return t * 90.0;
	}
}


using System;

public static class CounterClockWise
{	
	public static int ccw(Point a, Point b, Point c)
	{
		double dx1 = b.X - a.X;
		double dy1 = b.Y - a.Y;
		double dx2 = c.X - a.X;
		double dy2 = c.Y - a.Y;
		
		if ( dy1*dx2 < dy2*dx1 ) // dy1/dy2 < dx1/dx2
		{
			return 1; 
		}
		else if ( dy1*dx2 > dy2*dx1 ) //dy1/dy2 > dx1/dx2
		{
			return -1;
		}
		else 
		{
			if (dx1*dx2 < 0 || dy1*dy2 < 0) 
			{ // a in der Mitte
				return -1;
			} 
			else if (Math.Pow(dx1, 2) + Math.Pow(dy1, 2) >= Math.Pow(dx2, 2) + Math.Pow(dy2, 2)) 
			{ // c in der Mitte
				return 0;
			} 
			else 
			{ // b in der Mitte
				return 1;
			}
		}
	}
}
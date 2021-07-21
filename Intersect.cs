using System;

public class Intersect
{
	public static bool DoIntersect (Line Stk1, Line Stk2) 
	{	
		if ((CounterClockWise.ccw(Stk1.StartPoint, Stk1.EndPoint, Stk2.StartPoint) * 
		     CounterClockWise.ccw(Stk1.StartPoint, Stk1.EndPoint, Stk2.EndPoint)) <= 0 && 
		    (CounterClockWise.ccw(Stk2.StartPoint, Stk2.EndPoint, Stk1.StartPoint) * 
		 	 CounterClockWise.ccw(Stk2.StartPoint, Stk2.EndPoint, Stk1.EndPoint)) <= 0) 
			return true;
		else return false;
	}
	
	public static Point Intersection (Line Stk1, Line Stk2)
	{
		Point SPoint = new Point(0,0);
        double div = Math.Tan (Stk1.T) - Math.Tan (Stk2.T);

		if (div == 0) throw new Exception ("Die Gerade liegen aufeinander.");
        else if (Math.Abs(Stk1.T - Math.PI / 2) < 1E-13 || Math.Abs(Stk1.T - Math.PI * 3 / 2) < 1E-13)
        {
            SPoint.X = Stk1.StartPoint.X;
            SPoint.Y = Stk2.StartPoint.Y + (SPoint.X - Stk2.StartPoint.X) * Math.Tan(Stk2.T);
            return SPoint;
        }
        else if (Math.Abs(Stk2.T - Math.PI / 2) < 1E-13 || Math.Abs(Stk2.T - Math.PI * 3 / 2) < 1E-13)
        {
            SPoint.X = Stk2.StartPoint.X;
            SPoint.Y = Stk1.StartPoint.Y + (SPoint.X - Stk1.StartPoint.X) * Math.Tan(Stk1.T);
            return SPoint;
        }
        else
        {
            SPoint.X = Stk2.StartPoint.X + ((Stk2.StartPoint.Y - Stk1.StartPoint.Y) - (Stk2.StartPoint.X - Stk1.StartPoint.X) * Math.Tan(Stk1.T)) / (div);
            SPoint.Y = Stk1.StartPoint.Y + (SPoint.X - Stk1.StartPoint.X) * Math.Tan(Stk1.T);
            return SPoint;
        }
	}
}


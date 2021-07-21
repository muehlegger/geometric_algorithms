using System;
using System.Collections;


//abstrakte Basisklasse
public abstract class Geometry
{

}

//Klasse Punkt
public class Point : Geometry 
{
	//Felder
	private double x; 
	private double y;
	
	//Konstruktor
    public Point(){}

	public Point(double x, double y)
	{
		this.X = x;
		this.Y = y;
	}
	
	public double X
	{
		get { return this.x; }
		set { this.x = value; }
	}
	
	public double Y
	{
		get { return this.y; }
		set { this.y = value; }
	}
}

//Klasse Strecke
public class Line : Geometry
{
	private Point startpoint;
	private Point endpoint;

    public Line() {}

	public Line(Point startpoint, Point endpoint)
	{
		this.StartPoint = startpoint;
		this.EndPoint = endpoint;
	}
	
	public Point StartPoint
	{
		get { return this.startpoint; }
		set { this.startpoint = value; }
	}
	
	public Point EndPoint
	{
		get { return this.endpoint; }
		set { this.endpoint = value; }
	}
	
	//Eigenschaft Länge
	public double Length
	{
		get { return Math.Sqrt(Math.Pow(EndPoint.X - StartPoint.X, 2) + Math.Pow(EndPoint.Y - StartPoint.Y, 2)); }
	}
	
	//Eigenschaft Richtungswinkel T
	
	public double T 
	{
        get
        {
            double dy = EndPoint.Y - StartPoint.Y;
            double dx = EndPoint.X - StartPoint.X;

            double riwi = Math.Atan(dy / dx);

            if (dy >= 0 && dx >= 0) return riwi;
            else if (dy < 0 && dx >= 0) return riwi + 2 * Math.PI;
            else return riwi + Math.PI;
        }

	}
}

// Klasse Polygon
public class Polygon : Geometry
{
	//Felder
	protected Point[] pointlist;
	
	private int n;
	private double flaeche;
	
	//Konstruktor
	public Polygon(){}
	public Polygon(Point [] pointlist)
	{
		n = pointlist.Length-1;
		this.pointlist = pointlist; //??
	}
	
	public Point[] PointList
	{
		get { return this.pointlist; }
		set { pointlist = value; }
	} 
	
	public Line[] Strecken
	{
		get {
			Line[] strecken = new Line[n];
            Point pktB = new Point();
			for (int i = 0; i < n; i++)
			{
				Point pktA = this.pointlist[i];
                
				if ( i+1 == n) 
				{	pktB = this.pointlist[0]; }
				else 
				{	pktB = this.pointlist[i+1]; }
				
				strecken[i] = new Line(pktA, pktB);
			}
			return strecken;
		}
	}
	
	public int N
	{
		get { return n; }
	}

	//Eigenschaft Fläche
	public virtual double Flaeche
	{
		get {	//Gaußsche Trapezformel Gruber S. 46
			for (int i = 0; i <= n; i++)
			{
				if (i<n)
				{ flaeche = flaeche + (this.pointlist[i].Y + this.pointlist[i+1].Y) * (this.pointlist[i].X - this.pointlist[i+1].X); }
				else 
				{ flaeche = flaeche + (this.pointlist[i].Y + this.pointlist[0].Y) * (this.pointlist[i].X - this.pointlist[0].X); }
			}

			flaeche = Math.Abs (flaeche / 2.0);
			
			return flaeche;
		}
	}

	// Eigenschaft Ist-Einfaches-Polygon
	public bool IsSimplePolygon
	{
		get {
			for (int i = 2; i <= n; i++)
			{
				if (this.pointlist[i-2].Equals (this.pointlist[i]))
				{
					return false;
				}

				for (int j = 0; j < i - 1; j++)
				{
					if (Intersect.DoIntersect(this.Strecken[i], this.Strecken[j]))
					{
						if (this.Strecken[i].EndPoint.Equals(this.Strecken[0].StartPoint))
						return true; //Letzter Punkt ist Startpunkt
						else 
						return false;
					}
				}
			}
			return true; //?? darf offenes Polygon sein?
		}
	}
}

//Klasse Rechteck
public class Rectangle : Polygon
{
	private Point P;
	private double width, height;
	private double dy, dx;
	private int quad;

	public Rectangle (Point cpoint1, Point cpoint2) : base(new Point [5])
	{
		dy = cpoint2.Y - cpoint1.Y;
		dx = cpoint2.X - cpoint1.X;
		width = Math.Abs (dy);
		height = Math.Abs (dx);

		pointlist [0] = new Point (cpoint1.X, cpoint1.Y);
		pointlist [1] = new Point (cpoint1.X, cpoint2.Y);
		pointlist [2] = new Point (cpoint2.X, cpoint2.Y);
		pointlist [3] = new Point (cpoint2.X, cpoint1.Y);
		pointlist [4] = pointlist [0];

		if (dx > 0 && dy > 0) quad = 1;
		else if ( dx < 0 && dy > 0) quad = 2;
		else if ( dx < 0 && dy < 0) quad = 3;
		else if ( dx > 0 && dy < 0) quad = 4;
		else throw new Exception ("Eingabe ungültig! Kein Rechteck");
	}

	public Point UpperLeft
	{
		get {
			switch (quad)
			{
				case 0: P = null; break;
				case 1: P = pointlist[3]; break;
				case 2: P = pointlist[0]; break;
				case 3: P = pointlist[1]; break;
				case 4: P = pointlist[2]; break;
			}

			return P;
		}

	}

	public Point LowerRight
	{
		get {
			switch (quad)
			{
			case 0: P = null; break;
			case 1: P = pointlist[1]; break;
			case 2: P = pointlist[2]; break;
			case 3: P = pointlist[3]; break;
			case 4: P = pointlist[0]; break;
			}
			
			return P;
		}
	}

	public double Width
	{
		get { return width;}
	}

	public double Height
	{
		get { return height; }
	}

	public bool PointInRec (Point Pd)
	{
		bool iswithin;

		if (Pd.X >= this.LowerRight.X && Pd.X <= this.UpperLeft.X && Pd.Y >= this.UpperLeft.Y && Pd.Y <= this.LowerRight.Y)
			iswithin = true;
		else iswithin = false;

		return iswithin;
	}
}
using System;
using System.Collections;
using System.Collections.Generic;

public class Tree
{
	private int n;
	private Point [] punktliste;
	private bool IsY;
	private int a, b;

	public Tree (){}

	public Tree (Point [] punktliste)
	{
		n = punktliste.Length;
		this.punktliste = punktliste;
	}

	public Point [] PointList
	{
		get { return this.punktliste; }
		set { this.punktliste = value; }
	}

	public int Count
	{
		get { return this.n; }
	}

	public Node Root 
	{
		get { return Construction(0, n-1, true, true); }
	}

	private Node Construction (int A, int B, bool isy, bool isroot)
	{
		a = A; b = B;
		IsY = isy;

		if ( a <= b )
		{
			int m = (int) Math.Floor((b - a) / 2.0);	
			ArraySort ();
			Node N = new Node ();
			N.Value = punktliste[m+a];
			N.IsY = isy;

			int al = a;
			int bl = a + m - 1;
			int ar = a + m + 1 ;
			int br = b;

			if ( IsY )
			{
				N.Left = Construction (al, bl, false, false);
				N.Right = Construction (ar, br, false, false);

				return N;
			}
			else
			{
				N.Left = Construction (al, bl, true, false);
				N.Right = Construction (ar, br, true, false);
				
				return N;
			}
		}
		else return null;
	}

	private void ArraySort ()
	{
		if (IsY == true)
		{
			for (int j = a; j < b; j++)
			{
				for (int i = a; i < b; i++)
				{
					if (punktliste[i].Y > punktliste[i+1].Y)
					{
						Point temp = punktliste[i];
						punktliste[i] = punktliste [i+1];
						punktliste[i+1] = temp;
					}
					
				}
			}
		}
		
		else
		{
			for (int j = a; j < b; j++)
			{
				for (int i = a; i < b; i++)
				{
					if (punktliste[i].X > punktliste[i+1].X)
					{
						Point temp = punktliste[i];
						punktliste[i] = punktliste [i+1];
						punktliste[i+1] = temp;
					}
					
				}
			}
		}
	}
}

public class Node
{
	public Node ()
	{
	}
	
	public bool IsY { get; set; }
	
	public Point Value { get; set; }
	
	public Node Left { get; set; }
	
	public Node Right { get; set; }
}



public class TreeSearch
{
	private static List <Point> pointsinrange = new List <Point>();
	private static Rectangle rec;

	public static Point [] PointsInRange (Tree T, Rectangle R)
	{
        pointsinrange.Clear();
		rec = R;
		nodeSearch(T.Root);

		Point [] points = pointsinrange.ToArray();
		return points;
	}


	private static void nodeSearch (Node actNode)
	{
		Point P = actNode.Value;

		if (rec.PointInRec(P)) pointsinrange.Add (P);

		if (actNode.IsY == true)
		{
			if (P.Y >= rec.UpperLeft.Y && actNode.Left != null) nodeSearch(actNode.Left);
			if (P.Y <= rec.LowerRight.Y && actNode.Right != null) nodeSearch(actNode.Right);
		}

		else
		{
			if (P.X >= rec.LowerRight.X && actNode.Left != null) nodeSearch(actNode.Left);
			if (P.X <= rec.UpperLeft.X && actNode.Right != null) nodeSearch(actNode.Right);
		}
	}
}
using System;

//Klasse: Punkt in Polygon

public class PointInPolygon
{
	public static bool PointIsInPolygon(Polygon poly, Point pkt)
	{	
		int n = poly.N;
//		double maxX = 0;
//		foreach (Point o in poly.PointList)
//		{
//			if (maxX < o.X)
//				maxX = o.X;
//		}
//		maxX = maxX + 1000;
		double maxX = double.MaxValue;

	
		int j = n + 2; //Index des letzten Punktes der nicht auf der Teststrecke war (Initialisiert damit kein Punkt im Polygon angesprochen wird)
		int count = 0; //Zähler für Überquerungen/Schnitte des/mit dem Polygon
		bool lastAtTestline = false; //war vorhergehender Punkt auf der Teststrecke
		Point big = new Point (maxX, pkt.Y); //Punkt außerhalb des Polygons
		Line lt = new Line (pkt, big); //Teststrecke
	
		for (int i = 0; i <= n; i++)
		{
			//Wenn aktueller Punkt auf Testlinie (Differenz 1*10⁻¹3)
			if (Math.Abs (pkt.Y - poly.PointList[i].Y) < 1E-13 && pkt.X <= poly.PointList[i].X)
				lastAtTestline = true;
			//Wenn nicht
			else
			{
				if ( j != n + 2 ) //Falls vorher schon einmal ein Punkt NICHT auf der Testlinie war
				{
					//Falls letzter Punkt auf Testlinie
					if (lastAtTestline == true)
					{	//Falls der letzte Punkt, der nicht auf Teststrecke war, und dieser Punkt auf unterschiedlichen Seiten
						if (CounterClockWise.ccw (pkt, big, poly.PointList[i]) * CounterClockWise.ccw (pkt, big, poly.PointList[j]) <= 0)
							count = count + 1;
					}
					else
					{
						Line lp = new Line (poly.PointList[i], poly.PointList[j]);
						if (Intersect.DoIntersect(lt, lp))
							count = count + 1;
					}
				}
				lastAtTestline = false;
				j = i;
			}
		}
		return ((count % 2) == 1);
	}
}


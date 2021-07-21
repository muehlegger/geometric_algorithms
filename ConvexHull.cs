using System;


public static class ConvexHull
{
	public static Polygon GetConvexHull (Point[] punktliste)
	{
		int n = punktliste.Length;
		Point CP; //Punkt als Zwischenspeicher zum Kopieren
		Point [] hullList = new Point[n+1];
		Array.Copy (punktliste, hullList, n);

		double thetas, v, minangle;
		int m;

		int index = 0;

		// Suchen des Punktes mit kleinster Y-Koo
		for (int i = 1; i < n; i++)
		{
			if (punktliste[i].Y < punktliste[index].Y)
			{	
				index = i;
			}
		}

		hullList[0] = punktliste[index]; //Punkt mit kleinster Y-Koo an erste Stelle des Arrays
		hullList[n] = punktliste[index];
		hullList[index] = punktliste[0];
		index = 0; //Stelle bis wohin das neue Array mit PolygonPunkten aufgefüllt ist
		minangle = 0.0;
        m = 0; //speichert den Index des Elementes mit kleinstem Winkel vom aktuellen Pkt.

		do { //bis erster Punkt der Hülle wieder erreicht ist
			v = minangle; minangle = 360;
			for ( int i = index + 1; i < n + 1; i++)
			{
				if (index == 0 && i == n) break;
				thetas = theta.GetTheta(hullList[index], hullList[i]);
				if (thetas >= v && thetas < minangle)
				{
					minangle = thetas;
					m = i;
				}
			}
			index = index + 1;
			CP = hullList[index]; 
			hullList[index] = hullList[m];
			hullList[m] = CP;
		} while (hullList[index] != hullList[0]);


		Point [] convex = new Point [index+1];
		Array.Copy (hullList, convex, index+1);

		return new Polygon (convex);
	}
}


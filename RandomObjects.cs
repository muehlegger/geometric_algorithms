using System;

public static class RandomObjects
{
	public static Point [] getPunktwolke (int count)
	{
		Random rd = new Random();
		double rdX = 0;
		double rdY = 0;
		Point [] RandomPoints = new Point [count];

		for (int i = 0; i < count; i++)
		{
			rdX = rd.NextDouble() * 1000.0 + 50.0;
			rdY = rd.NextDouble() * 1000.0 + 50.0;
			RandomPoints[i] = new Point (rdX, rdY);
		}

		return RandomPoints;
	}

	public static Line [] getZufallsgeraden (int count)
	{
		Random rd = new Random();
		double rdX1, rdY1, rdX2, rdY2;
		Point P1, P2;
		Line [] RandomLines = new Line [count];

		for (int i = 0; i < count; i++)
		{
			rdX1 = rd.NextDouble() * 1000.0 + 100.0;
			rdY1 = rd.NextDouble() * 1000.0 + 100.0;
			rdX2 = (rd.NextDouble() * 2.0 - 1.0) * 400.0 + rdX1;
			rdY2 = (rd.NextDouble() * 2.0 - 1.0) * 400.0 + rdY1;
		
			P1 = new Point (rdX1, rdY1);
			P2 = new Point (rdX2, rdY2);

			RandomLines[i] = new Line (P1, P2);
		}

		return RandomLines;
	}
}
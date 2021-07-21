using System;
using System.Collections.Generic;

public static class SweepLine
{
	private static List <Point> breakpoints = new List<Point>();
	private static List <int> BPindex = new List<int>();


	//Sortieralgorithmus für Listen (Bubble-Sort)
	private static void BubbleSort (List <Point> breakpoints, List <int> BPindex)
	{
		for (int i = 0; i < breakpoints.Count - 1; i++)
		{
			for (int j = 0; j < breakpoints.Count - 1; j++)
			{
				if (breakpoints[j].X > breakpoints[j+1].X)
				{
					Point P = breakpoints[j];
					breakpoints[j] = breakpoints[j+1];
					breakpoints[j+1] = P;
					int Z = BPindex[j];
					BPindex[j] = BPindex[j+1];
					BPindex[j+1] = Z;
				}
			}
		}
	}


	public static Point [] LineIntersection (Line [] lines)
	{
		int n = lines.Length;
		Line [] segments = new Line [n];
		Array.Copy(lines, segments, n);

		List <int> Aindex = new List<int>();
		List <Line> actives = new List<Line>();

		Point newIP = new Point (0,0); 
		List <Point> intersections = new List<Point>();

        breakpoints.Clear();
        BPindex.Clear();

		for (int i = 0; i < n; i++)
		{
			//StartPoint.X darf nicht größer sein als EndPoint.X
			if (segments[i].EndPoint.X < segments[i].StartPoint.X)
			{
				Point temp = segments[i].StartPoint;
				segments[i].StartPoint = segments[i].EndPoint;
				segments[i].EndPoint = temp;
			}

			//Haltepunkte in breakpoints und deren Indizes in BPindex kopieren
			breakpoints.Add(segments[i].StartPoint);
			BPindex.Add (i);
			breakpoints.Add (segments[i].EndPoint);
			BPindex.Add (i);
		}

		//Listen sortieren
		SweepLine.BubbleSort(breakpoints, BPindex);
        int index = 0;
//--------------------------------------------alle Haltepunkte werden einzeln durchlaufen
		for (int i = 0; i < breakpoints.Count; i++)
		{
			index = BPindex[i];
			int Acount = actives.Count;

		//------------------------------------Haltepunkt ist SCHNITTPUNKT
			if (BPindex[i] == n + 10)
			{
				for (int j = 0; j < Acount - 1; j++)
				{
					int thisI = Aindex[j];
					double thisY = segments[thisI].StartPoint.Y + (breakpoints[i].X - segments[thisI].StartPoint.X) * 
						(segments[thisI].EndPoint.Y - segments[thisI].StartPoint.Y) / (segments[thisI].EndPoint.X - segments[thisI].StartPoint.X);
					if (Math.Abs (breakpoints[i].Y - thisY) < 1E-10)
					{
						//vertausche Elemente
						Line stk = actives[j];
						actives[j] = actives[j+1];
						actives[j+1] = stk;
						int save = Aindex[j];
						Aindex[j] = Aindex[j+1];
						Aindex[j+1] = save;

						//Auf Schnitt mit Vorgänger prüfen
						if (j > 0 && Intersect.DoIntersect(actives[j-1], actives[j]))
						{
							newIP = Intersect.Intersection(actives[j-1], actives[j]);
							if (intersections.Exists(delegate(Point p) {return Math.Abs(p.X - newIP.X) < 1E-10 && Math.Abs(p.Y - newIP.Y) < 1E-10;}))
							{
								break;
							}
							else
							{
								intersections.Add (newIP);
								breakpoints.Add (newIP);
								BPindex.Add(n+10);
								SweepLine.BubbleSort(breakpoints, BPindex);
							}
						}
						//Auf Schnitt mit Nachfolger prüfen
						if (j + 2 < Acount && Intersect.DoIntersect(actives[j+1], actives[j+2]))
						{
							newIP = Intersect.Intersection(actives[j+1], actives[j+2]);
							if (intersections.Exists(delegate(Point p) {return Math.Abs(p.X - newIP.X) < 1E-13 && Math.Abs(p.Y - newIP.Y) < 1E-10;}))
							{
								break;
							}
							else
							{
								intersections.Add (newIP);
								breakpoints.Add (newIP);
								BPindex.Add(n+10);
								SweepLine.BubbleSort(breakpoints, BPindex);
							}
						}
						break;
					}
				}
			}
		//------------------------------------Haltepunkt ist STARTPOINT
			else if (breakpoints[i].Equals(segments[index].StartPoint))
			{
				if (Acount == 0)
				{
					actives.Add (segments[index]);
					Aindex.Add (index);
					continue;
				}   
				
				for (int j = 0; j < Acount; j++)
				{
					int thisI = Aindex[j];
					double thisY = segments[thisI].StartPoint.Y + (breakpoints[i].X - segments[thisI].StartPoint.X) * 
						(segments[thisI].EndPoint.Y - segments[thisI].StartPoint.Y) / (segments[thisI].EndPoint.X - segments[thisI].StartPoint.X);
					if (breakpoints[i].Y < thisY)
					{
						actives.Insert (j, segments[index]);
						Aindex.Insert (j, index);

						//Auf Schnitt mit Nachfolger prüfen
						if (Intersect.DoIntersect(actives[j], actives[j+1]))
						{
							newIP = Intersect.Intersection(actives[j], actives[j+1]);
							if (intersections.Exists(delegate(Point p) {return Math.Abs(p.X - newIP.X) < 1E-10 && Math.Abs(p.Y - newIP.Y) < 1E-10;}))
							{
                                //break;
							}
							else
							{
								intersections.Add (newIP);
								breakpoints.Add (newIP);
								BPindex.Add(n+10);
								SweepLine.BubbleSort(breakpoints, BPindex);
							}
						}
						//Auf Schnitt mit Vorgänger prüfen
						if (j > 0 && Intersect.DoIntersect(actives[j-1], actives[j]))
						{
							newIP = Intersect.Intersection(actives[j-1], actives[j]);
							if (intersections.Exists(delegate(Point p) {return Math.Abs(p.X - newIP.X) < 1E-10 && Math.Abs(p.Y - newIP.Y) < 1E-10;}))
							{
                                //break;
							}
							else
							{
								intersections.Add (newIP);
								breakpoints.Add (newIP);
								BPindex.Add(n+10);
								SweepLine.BubbleSort(breakpoints, BPindex);
							}
						}
						break;
					}
					//falls Ende der Liste actives erreicht
					else if (j == Acount - 1)
					{
						actives.Add(segments[index]);
						Aindex.Add (index);

						//auf Schnitt mit Vorgänger prüfen (Vorgänger ist j)
						if (Intersect.DoIntersect(actives[j], actives[j+1]))
						{
							newIP = Intersect.Intersection(actives[j], actives[j+1]);
							if (intersections.Exists(delegate(Point p) {return Math.Abs(p.X - newIP.X) < 1E-10 && Math.Abs(p.Y - newIP.Y) < 1E-10;}))
							{
                                //break;
							}
							else
							{
								intersections.Add (newIP);
								breakpoints.Add (newIP);
								BPindex.Add(n+10);
								SweepLine.BubbleSort(breakpoints, BPindex);
							}
						}
						break;
					}		
				}
			}
			//continue; ??????
			//sonderfall: falls Haltepunkt StartPoint und EndPoint ?????

		//------------------------------------Haltepunkt ist ENDPOINT
//			else if (breakpoints[i].Equals(segments[index].EndPoint))
			else if (breakpoints[i].X == segments[index].EndPoint.X && breakpoints[i].Y == segments[index].EndPoint.Y)
			{
				for (int j = 0; j < Aindex.Count; j++)
				{
					if (Aindex[j] == index)
					{
						if (j == Aindex.Count - 1)
						{
							Aindex.RemoveAt(j);
							actives.RemoveAt(j);
							break;
						}
						else
						{
							Aindex.RemoveAt(j);
							actives.RemoveAt(j);
							// zwei neuen Nachbarn auf Schnitt testen
							if (j>0 && Intersect.DoIntersect(actives[j], actives[j-1]))
							{
								newIP = Intersect.Intersection(actives[j], actives[j-1]);
								if (intersections.Exists(delegate(Point p) {return Math.Abs(p.X - newIP.X) < 1E-10 && Math.Abs(p.Y - newIP.Y) < 1E-10;}))
								{
									break;
								}
								else
								{
									intersections.Add (newIP);
									breakpoints.Add (newIP);
									BPindex.Add(n+10);
									SweepLine.BubbleSort(breakpoints, BPindex);
								}
							}
							break;
						}
					}
				}
			}
		}
		Point [] IntersectionPoints = intersections.ToArray();
		return IntersectionPoints;
	}
}



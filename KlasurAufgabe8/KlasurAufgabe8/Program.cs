using System;

// Beispiel 8
public struct Vector2D
{
	public double x;
	public double y;

	public double Length()
	{
		return Math.Sqrt(x * x + y * y);
	}
}


public static double CalcActualPath(Vector2D[] path)
{
	double l = 0;
	for (int i = 0; i < path.Length; i++)
	{
		l += path[i].Length();
	}
	return l;

}

public static double CalcShortestPath(Vector2D[] path)
{
	Vector2D s;
	s.x = 0;
	s.y = 0;
	for (int i = 0; i < path.Length; i++)
	{
		s.x += path[i].x;
		s.y += path[i].y;
	}
	return s.Length();
}

public static double CalcActualPathToShortestRatio(Vector2D[] path)
{
	double actualPath = CalcActualPath(path);
	double shortestPath = CalcShortestPath(path);

	return actualPath / shortestPath;
}

public static bool TestKlausurBeispiel8()
{
	bool bCorrect = true;

	Vector2D up;
	Vector2D right;
	up.x = 0;
	up.y = 1;
	right.x = 1;
	right.y = 0;

	Vector2D[] path = new Vector2D[3];
	path[0] = up;
	path[1] = right;
	path[2] = right;

	bCorrect = bCorrect && (CalcActualPath(path) == 3);
	bCorrect = bCorrect && (CalcShortestPath(path) <= CalcActualPath(path));
	return bCorrect;
}


public static void Main()
{
	bool bCorrect = true;
	// Beispiel 3
	bCorrect = bCorrect && TestKlausurBeispiel3();
	// Beispiel 4

	// Beispiel 5
	KlausurBeispiel5();
	// Beispiel 6

	// Beispiel 7
	bCorrect = bCorrect && TestKlausurBeispiel7();
	// Beispiel 8
	bCorrect = bCorrect && TestKlausurBeispiel8();

	if(bCorrect)
		Console.WriteLine("Passed all tests!");
	else
		Console.WriteLine("Error detected!");
}
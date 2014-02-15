using System;

struct Vector2
{
	public Vector2 (float x, float y)
	{
		this.x = x;
		this.y = y;
	}

	// Membervariablen
	float x;
	float y;

	// Weitere Konstruktor zum skalieren d. Vectors
	public static Vector2 Scale (Vector2 vec, float skalar)
	{
		// Um einen Vector zu skalieren muss man x und y d. Vectors mit dem gewünschten Skalar multiplizieren
		vec.x = vec.x * skalar;
		vec.y *= skalar;

		return vec;
	}

	public static void Scale(ref Vector2 vec, float scalar)
	{
		vec.x *= scalar;
		vec.y *= scalar;
	}

	public void Scale(float scalar)
	{
		x *= scalar;
		y *= scalar;
	}
}

class Programm
{
	public static void Main ()
	{
		//Erstellen eines Objektes mit Konstruktor-Aufruf
		Vector2 vec = new Vector2(1f,0f);

		//Aufruf von "public static Vector2 Scale(Vector2 vec, float scalar)"
		Vector2 longVec = Vector2.Scale(vec, 2f);

		//Aufruf von "public static void Scale(ref Vector2 vec, float scalar)"
		Vector2.Scale(ref longVec, 0.5f);

		//Aufruf von "public void Scale(float scalar)"
		longVec.Scale(2f);
	}
}
/* 1310601027, fhs36118
 * Daniel Raudschus
 * ueoo bsp07
 * */

using System;

namespace bsp07
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* 7. (2P) Schreibe ein Programm, das den Body-Mass-Index (BMI) berechnet (Formel siehe Wikipedia).   
			 * Die benötigten Werte sollen als Fließkommazahl von der Tastatur eingelesen werden, der BMI-Wert soll am Bildschirm ausgegeben werden. 
			 * Was passiert, wenn für die Körpergröße den Wert 0 (bzw. 0,0) eingegeben wird? Verhindere dies mit einer geeigneten Abfrage.
			 * Verhindere ebenso die Eingabe unsinniger Werte, wie negatives Gewicht/Größe, oder auch unrealistisch große Werte. 
			 * Neben dem BMI-Wert soll auch eine Empfehlung abgegeben werden wie Iss etwas mehr! etc.
			 */

			// Usereingabe von Kilogramm (in KG) und Körpergrösse (in cm)
			Console.WriteLine ("Dieses Programm bestimmt ihren Body-Mass-Index \nGeben Sie Ihr Gewicht in Kilogramm ein:");
			double userWeigth = 1;  

			do 
			{
				if (userWeigth <= 0) {
					Console.WriteLine ("Bitte geben Sie einen Wert größer als Null ein.");
				}

				String weigth= Console.ReadLine();
				userWeigth = double.Parse(weigth);

			} while (userWeigth <= 0);

			Console.WriteLine ("Geben Sie Ihre Grösse in Metern ein:");
			double userLength = 1;

			do 
			{
				if (userLength <= 0) {
					Console.WriteLine ("Bitte geben Sie einen Wert größer als Null ein.");
				}

				String length = Console.ReadLine();
				userLength= double.Parse(length);

			} while (userLength <= 0);


			// Eingaben in Formel einsätzen Formel: BMI = m/l^2

			double bmi = userWeigth / (userLength * userLength);
			Console.WriteLine ("Ihr Body-Mass-Index ist " + bmi);

			// Textrückmeldung an user je nach BMI Wert
			// If Statment für bmi <= 18.5
			if (bmi <= 18.5) {
				Console.WriteLine ("Ihr BMI ist zu niedrig");
			}
			// If Statment für bmi = 18.5 - 25
			else if (bmi > 18.5 && bmi <= 25) {
				Console.WriteLine ("Ihr BMI ist zu im durchschnitt");
			} 
			// If Statment für bmi > 25
			else {
				Console.WriteLine ("Ihr BMI ist zu hoch");
			}

		}
	}
}

using System;

namespace ToRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            // Die maximale Breite eines Fensters ist 500 cm. const immer GROSSSCHREIBEN
            const double MAX_WIDTH = 500;
            // Die minimale Breite eines Fensters 25cm.
            const double MIN_WIDTH = 25;
            // Die maximale Höhe eines Festers ist 270cm.
            const double MAX_HEIGHT = 270;
            // Die minimale Höhe eines Fenster ist 30cm. 
            const double MIN_HEIGHT = 30;

            // Read in width.
            Console.WriteLine("Geben Sie die Breite des Fensters ein.");
            string sWidth = Console.ReadLine();
            // Convert to a number.
            double width = double.Parse(sWidth);
            // Verify / check width.
            if (width > MAX_WIDTH)
            {
                Console.WriteLine("Ungültige Größe: Fenster breiter als Maximalbreite.");
                return; // TODO Nachher besser mit Schleife bis gültige Eingabe.
            }
            if (width < MIN_WIDTH)
            {
                Console.WriteLine("Ungültige Größe: Fenster zu schmal.");
                return; //TODO
            }


            // Read, parse and check height.
            Console.WriteLine("Geben Sie die Höhe des Fensters ein.");
            string sHeight = Console.ReadLine();
            
            double height = double.Parse(sHeight);
            
            if (height > MAX_HEIGHT)
            {
                Console.WriteLine("Fenster zu hoch.");
                return;
            }
            if (height < MIN_HEIGHT)
            {
                Console.WriteLine("Fenster zu nieder.");
                return;
            }
            Console.WriteLine("Sie haben ein Fenster mit der Höhe " + height + " und der Breite " + width + " angegeben.");

            // Compute the area and the length.
            double length = 2 * (width + height);
            double area = width * height;

            // Print the results.
            Console.WriteLine("Die notwendige Holzlänge ist " + length + ".");
            Console.WriteLine("Die notwendige Glasfläche ist " + area + ".");
        }
    }
}
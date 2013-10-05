using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printUnsignedBinaryRepresentation
{
	class Program
	{
		static void Usage()
		{
			Console.WriteLine("Compute and print the binary representation of a decimal number.");
		}

		static void Main(string[] args)
		{
			Usage();

			// Read in decimal number.
			Console.WriteLine("Please enter a number!");
			string sDecimalNumber = Console.ReadLine();
			uint decimalNumber = uint.Parse(sDecimalNumber);

			// Implementation of the Algorithm for conversion to binary:
			uint z = decimalNumber;
			string binaryDigits = "";
			while (z != 0)
			{
				uint binaryDigit = z % 2;
				z = z / 2;

				binaryDigits = binaryDigit + binaryDigits;
			}

			// Print result.
			Console.WriteLine("The binary representation of " + decimalNumber + " is " + binaryDigits + ".");
		}
	}
}
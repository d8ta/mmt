// 1310601035, fhs36126
// Franz Rest
// ue03 bsp026

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
	static void PiApproximate(int Max)
	{
		Console.WriteLine("Brüche die PI bis zur 6ten Nachkommastelle ausgeben!");
		for (double i = 0; i < Max; i++)
		{
			for (double j = 0; j < Max; j++)
			{
				if((i/j >= 3.141592) && (i/j <= 3.141593))
					Console.WriteLine("{0} / {1} = {2,0:0.0000000}",i,j,i/j);
			}
		}
		Console.WriteLine("PI = " + Math.PI);
	}
	static void Main(string[] args)
	{
		PiApproximate(10000);
	}
}


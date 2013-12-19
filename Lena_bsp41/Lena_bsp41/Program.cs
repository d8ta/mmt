using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using Pgm;

class PgmCreatorDemo {
	static void Main(string[] args) { 


		// Funktionen für Übung 7
		LenaToBaboonSlide ();




		/*				* SOME TEST AND INTRODUCTORY CODE: **/
		// for the specification of PGM-Files, see: http://netpbm.sourceforge.net/doc/pgm.html


		// byte-array for storing the gray-color-values (.
		// the img has the size 256x256 pixel;
		// each pixel has a gray-color-value from 0-255 (0...black, 255...white).
		byte[,] imgData = new byte[256, 256];

		// fill the imgData-Array with the gray-color-values:
		for (int y = 0; y < imgData.GetLength(1); y++) {
			for (int x = 0; x < imgData.GetLength(0); x++) {
				// produce a gray-color gradient image:
				// top-left corner: black, bottom-right corner: white.
				// Note that x and y go from 0 to 255, so x/2 + y/2 cannot exceed the value 254.
				imgData[x, y] = (byte)(x / 2 + y / 2);
			}
		}

		byte[,] readDataAscii; // byte-array
		byte[,] readDataBinary;
		try {
			// write imgData to P2 file (ascii):
			PgmCreator.WritePgmFile("testASCII.pgm", imgData, PgmType.P2);
			// read from P2 file (ascii): 
			readDataAscii = PgmCreator.ReadPgmFile("testASCII.pgm");
			// write image data to P5 file (binary): 
			PgmCreator.WritePgmFile("testBinary.pgm", readDataAscii, PgmType.P5);
			// read P5 file (binary):
			readDataBinary = PgmCreator.ReadPgmFile("testBinary.pgm");

			//check if the image loaded from the P2-type file (ascii) is the same as from the P5-type file (binary):
			for (int y = 0; y < imgData.GetLength(1); y++) {
				for (int x = 0; x < imgData.GetLength(0); x++) {
					if (readDataAscii[x,y] != readDataBinary[x,y]) Console.WriteLine("DIFFERENCES IN WRITTEN AND READ FILE OCCURED!");
				}
			}
			Console.WriteLine("Success in testing two generated files of both types!");
		} catch (Exception e) {
			Console.WriteLine(e.Message);
		}

	}


	/*	 * Übungsfunktionen für Überblendungung * */

	// Horizontal
	static void LenaToBaboonSlide ()
	{
		byte[,] lenaImgData = PgmCreator.ReadPgmFile("/Users/danielraudschus/Documents/ImageProcessing-PGM-Files/lena.pgm");
		byte[,] Baboon = PgmCreator.ReadPgmFile("/Users/danielraudschus/Documents/ImageProcessing-PGM-Files/baboon.pgm");
		byte[,] LenaToBaboonSlide = new byte[512, 512];

		try
		{
			for (double i = 0; i < 10; i++) 
			{
				double alpha = i / 10;

				for (int x = 0; x < lenaImgData.GetLength(0); x++)
				{
					for (int y = 0; y < lenaImgData.GetLength(1); y++)
					{
						LenaToBaboonSlide[x,y] = (byte)((1 - alpha) * (int)lenaImgData[x,y] + ((alpha)) * (int)Baboon[x,y]);						 
					}
				}
				PgmCreator.WritePgmFile("/Users/danielraudschus/Documents/ImageProcessing-PGM-Files/LenaToBaboon" + (i+1) + ".pgm", LenaToBaboonSlide, PgmType.P5);

			}
			Console.WriteLine("Lena get baboooooned!");

		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}

}


/* Creator Program */

namespace Pgm {

	public enum PgmType { P2, P5 }

	public static class PgmCreator {
		#region PGM Reader
		/// <summary>
		/// Reads in a PGM file in P2 or P5 Format and returns a byte[,]-Array if everything works fine. Otherwise, exceptions are thrown.
		/// For the specification of PGM-Files, see: http://netpbm.sourceforge.net/doc/pgm.html
		///
		/// This Method was used and modified from http://www.cnblogs.com/lihongsheng0217/archive/2008/08/12/1266426.html 
		/// Original author: Mennan Tekbir(mtekbir[]gmail[]com). 
		/// Major modifications by Radomir Dinic and Gerhard Mitterlechner. License: GPL
		///
		/// IMPORTANT: 
		/// *) A comment line must be present ofter the type code (P2 or P5). 
		/// *) Also: class only handles gray-values <= 255 correctly! (according to spec. <= 65536 should be supported)
		/// *) Only newlines LF (ASCII 10) are used. Therefore, Windows users who create or modify the P2 PGM (=ASCII) files
		///    MANUALLY may run into problems, because Windows OS uses CR (ASCII 13) AND NL (ASCII 10) for a line break.
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public static byte[,] ReadPgmFile(string filename) {
			FileStream inputStream;
			BinaryReader pgmReader;

			try {
				inputStream = File.OpenRead(filename);  //missing: exception handling!
			} catch {
				throw new Exception("Could not open file: " + filename);
			}

			try {
				pgmReader = new BinaryReader(inputStream);	
			} catch {
				inputStream.Close();
				throw new System.Exception("Could not read from stream of file " + filename);
			}

			byte newLineAsciiCode = 10;  /*						 new line */
			byte hashAsciiCode = 35; /*						 the hash: '#' */
			byte spaceAsciiCode = 32; /*						 ascii code of the blank / space */

			// stores some header info of PGM-File temporarily.
			// WARNING: Here, the comment can be max. 999 characters long (plus the '#')!
			byte[] tempArray = new byte[1000]; 

			string tempString;  //variable for storing strings temporarily
			byte tempByte;   //variable for storing ascii-values temporarily

			/*						 Sample PGM : (the dimension of the image is arbitrary, but the max-color value must be 255! (more strict than in specification!))
             * 
             * 
             * P2
             * # Created by ...
             * 512 512
             * 255
             * [data]
             */

			//read PGM Type P2, P5
			tempArray[0] = pgmReader.ReadByte();  //must be the ASCII code of 'P'
			tempArray[1] = pgmReader.ReadByte(); //must be the ASCII code of '2' or '5'
			//make a string out of first read ASCII-Codes:
			string sType = System.Text.ASCIIEncoding.Default.GetString(tempArray, 0, 2); 

			//read until new line
			while (pgmReader.ReadByte() != newLineAsciiCode) { ;}

			//read comments if exist. Only one comment line is supported!!! Only length of max. 999 characters plus the '#'!
			int i = 0;
			tempByte = pgmReader.ReadByte();
			if (tempByte == hashAsciiCode) {
				//read comment line (must be there!)
				string sComments = readUntil(newLineAsciiCode, pgmReader);	
			}
			else {
				inputStream.Close();
				pgmReader.Close();
				throw new Exception("No comment found. Abortion. File " + filename + " closed.");
			}

			//read width
			tempString = readUntil(spaceAsciiCode, pgmReader);
			int width = Convert.ToInt32(tempString);

			//read height
			tempString = readUntil(newLineAsciiCode, pgmReader);
			int height = Convert.ToInt32(tempString);

			//read the maximal gray-scale color value (e.g., 255. Must be < 65536 according to the specification.)
			//WARNING: this programm only allows a max color value of 255!!!

			tempString = readUntil(newLineAsciiCode, pgmReader);
			int maxColor = Convert.ToInt32(tempString);

			//read image data
			byte[] pgmDataBuffer = new byte[width * height];
			if (sType == "P5") {
				//If file is binary, read every byte
				try {
					byte[] readBytes = pgmReader.ReadBytes(pgmDataBuffer.Length); //store each color-value in the array of already readBytes
					Array.Copy(readBytes, pgmDataBuffer, readBytes.Length); //copy the content to the final pgmDataBuffer
				}
				catch (Exception e) {
					throw new Exception("Error reading binary data from P5 file! " + e.Message);
				}
				finally {
					pgmReader.Close();
					inputStream.Close();
				}
			}
			else if (sType == "P2") {
				//if file is text-based every pixel is distinguished by "space" and it has up to 3 chars (max grey-value of 255!!!)
				try {
					tempByte = pgmReader.ReadByte();
					int k = 0;
					while (pgmReader.BaseStream.Position != pgmReader.BaseStream.Length) {
						//read all non-newline or non-whitespace character
						i = 0;
						while (tempByte != newLineAsciiCode && tempByte != spaceAsciiCode) {
							tempArray[i] = tempByte;
							i++;
							tempByte = pgmReader.ReadByte();
						}
						// convert the non-newline/non-whitespace characters to a string
						tempString = System.Text.ASCIIEncoding.Default.GetString(tempArray, 0, i);

						//tempString contains now the string representation of every pixel. 
						// Copy it to buffer of image data.
						pgmDataBuffer[k] = Convert.ToByte(tempString);
						k++;

						tempByte = pgmReader.ReadByte();
						if (pgmReader.BaseStream.Position != pgmReader.BaseStream.Length) {
							if (tempByte == newLineAsciiCode || tempByte == spaceAsciiCode) {
								tempByte = pgmReader.ReadByte(); //read next character (must be a non-newline/non-blank)
							}
						}
					}
				}
				catch (EndOfStreamException e) {
					//if premature end of stream is reached...
					throw new Exception("Unexcpected end of stream reading P2 file! " + e.Message);
				}
				catch (Exception e) {
					throw new Exception("Some unexpexted exception reading P2 file!" + e.Message);
				}
				finally {
					pgmReader.Close();
					inputStream.Close();
				}
			}
			return CreateTwodimensionalArray(pgmDataBuffer, width, height);
		}


		private static string readUntil(byte separator, BinaryReader pgmReader) {
			byte[] tempArray = new byte[1000];
			int i = 0;
			byte tempByte = pgmReader.ReadByte();
			while (tempByte != separator) {
				tempArray[i] = tempByte;
				i++;
				tempByte = pgmReader.ReadByte();
			}
			//make a string out of tempArray
			return System.Text.ASCIIEncoding.Default.GetString(tempArray, 0, i);
		}


		private static byte[,] CreateTwodimensionalArray(byte[] pgmDataBuffer, int width, int height) {
			byte[,] temp = new byte[width, height];
			for (int y = 0; y < height; y++) {
				for (int x = 0; x < width; x++)  {
					temp[x, y] = pgmDataBuffer[y * width + x];
				}
			}
			return temp;
		}

		#endregion

		#region PGM Writer
		/// <summary>
		/// Write a given byte[,] to Pgm-File or throws an exception on an error.
		/// Formats:
		/// P2: ASCII-Format
		/// P5: Binary-Format
		/// </summary>
		/// <param name="filename">filename or path</param>
		/// <param name="imgData">array with image-data</param>
		/// <param name="type">Type P2 or P5</param>
		public static void WritePgmFile(string filename, byte[,] imgData, PgmType type) {
			switch (type) {
			case PgmType.P2:
				WritePgmFileASCII(filename, imgData, type);
				break;
			case PgmType.P5:
				WritePgmFileBinary(filename, imgData, type);
				break;
			default:
				throw new Exception("Wrong type!");
			}
		}

		private static void WritePgmFileASCII(string filename, byte[,] imgData, PgmType type) {
			StreamWriter writer;
			try {
				writer = new StreamWriter(filename);
			} catch (Exception e) {
				throw new Exception("Could not open file " + filename + " for writing." + e.Message);
			}
			string head = buildPgmHeader(imgData.GetLength(0), imgData.GetLength(1), type);
			writer.Write(head);

			for (int y = 0; y < imgData.GetLength(1); y++) {
				for (int x = 0; x < imgData.GetLength(0); x++) {
					string data = imgData[x, y].ToString() + " ";
					writer.Write(data);
				}
				writer.Write('\n');
			}
			writer.Close();
		}

		private static void WritePgmFileBinary(string filename, byte[,] imgData, PgmType type) {
			FileStream outputStream;
			try {
				outputStream = File.Create(filename);
			}
			catch (Exception e) {
				throw new Exception("Could not open file " + filename + " for writing. " + e.Message);
			}

			BinaryWriter pgmWriter;
			try {
				pgmWriter = new BinaryWriter(outputStream);
			}
			catch (Exception e) {
				outputStream.Close();
				throw new Exception("Could not open output stream from file. " + e.Message);
			}

			string PGMInfo = buildPgmHeader(imgData.GetLength(0), imgData.GetLength(1), type);
			byte[] PGMInfoBuffer = System.Text.ASCIIEncoding.Default.GetBytes(PGMInfo);
			pgmWriter.Write(PGMInfoBuffer);

			byte[] temp = createOneDimensionalTempArray(imgData);

			pgmWriter.Write(temp);
			pgmWriter.Close();
		}

		private static string buildPgmHeader(int width, int height, PgmType type) {
			string header = string.Empty;
			switch (type) {
			case PgmType.P2:
				header += "P2\n";
				break;
			case PgmType.P5:
				header += "P5\n";
				break;
			default:
				throw new Exception("Wrong type!");
			}
			header += "# MMT\n";
			header += width + " " + height + "\n";
			header += "255\n";  //warning: this is hardcoded, should allow a value up to 65535 according to specification!
			return header;
		}

		private static byte[] createOneDimensionalTempArray(byte[,] imgData) {
			int w = imgData.GetLength(0);
			int h = imgData.GetLength(1);

			byte[] temp = new byte[w * h];

			for (int y = 0; y < h; y++) {
				for (int x = 0; x < w; x++) {
					temp[y * w + x] = imgData[x, y];
				}
			}
			return temp;
		}
		#endregion
	}
}

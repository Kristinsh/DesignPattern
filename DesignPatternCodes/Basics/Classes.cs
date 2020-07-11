using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.Basics
{
	class Classes
	{
		static void Main()     //Main
		{
			Point point = new Point();  //Creates an instance of an Object (Class)
			point.x = 5;            //Vi setter til at x verdien i point objektet = 5
			point.y = 3;                               //Vi setter til at y verdien i point objekter = 3

			System.Console.WriteLine(point.x);         //Skriver ut i terminal vinduet 5
			System.Console.WriteLine(point.y);       //Skriver ut i terminal vinduet 3
		}

	} 

	class Point
    {
		public int x;   //Declare properties  Kalles for Fields
		public int y;   //Declare properties.  Kalles for Fields
	}

}



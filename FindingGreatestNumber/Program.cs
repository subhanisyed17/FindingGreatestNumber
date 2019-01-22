// Exercise 3
// Input 3 numbers from the user (x,y,z) and find the greatest of them.


using System;

namespace FindingGreatestNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the numbers which need to be compared seperated by commas");
			string[] NumberstobeCompared = Console.ReadLine().Split(',');
			try
			{
				int greatestNumber = 0;
				for (int i = 0; i < NumberstobeCompared.Length; i++)
				{
					int x = int.Parse(NumberstobeCompared[i]);
					if (x > greatestNumber)
						greatestNumber = x;
				}
				Console.WriteLine("Greatest number entered is {0}", greatestNumber);
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
			Console.ReadKey(true);
		}
	}
}

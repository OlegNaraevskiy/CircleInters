using System;

namespace CircleInters
{
	class Program
	{
		static void Main(string[] args)
		{
			Calcs calc = new Calcs();

			int[] testA = new int[] { 1, 5, 2, 1, 4, 0 };

			int[] A = new int[] { 1, 5, 2 };

			int n = 100000;
			const int max_int = 2147483647;
			Random rand = new Random();

			int[] arr = new int[n];

			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(0, max_int);
			}


			var result = calc.GetOccurrences(arr);

			Console.WriteLine(result);
			Console.ReadKey();
			
		}
	}
}

/*===================================================================
 * Copyright (c) 2021 Oleg Naraevskiy                   Date: 12.2021
 * Version IDE: MS VS 2019
 * Designed by: Oleg Naraevskiy / noa.oleg96@gmail.com      [12.2021]
 *===================================================================*/

namespace CircleInters
{
	public class Calcs
	{
		public int GetOccurrences(int[] a)
		{
			int result = 0;

			int[] startPoints = new int[a.Length];
			int[] endPoints = new int[a.Length];

			int size = a.Length - 1;

			for (int i = 0; i < a.Length; i++)
			{
				int start = i > a[i] ? i - a[i] : 0;
				int end = size - i > a[i] ? i + a[i] : size;
				startPoints[start] = startPoints[start] + 1;
				endPoints[end] = endPoints[end] + 1;
			}

			int j = 0;
			for (int i = 0; i < a.Length; i++)
			{
				if (startPoints[i] > 0)
				{
					result += j * startPoints[i];
					result += startPoints[i] * (startPoints[i] - 1) / 2;

					if (result > 10000000)
					{
						return -1;
					}

					j += startPoints[i]; 
				}
				j -= endPoints[i];
			}

			return result;
		}
	}
}

// https://adventofcode.com/2020/day/1

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Day1
{
	class Program
	{
		static void Main(string[] args)
		{
			var inputs = File.ReadLines("input.txt")
				.Select(int.Parse)
				.ToList();

			var results = new List<int>
			{
				GetNumbersWithSumX(inputs, 2020, 2).Aggregate((a, x) => a * x),
				GetNumbersWithSumX(inputs, 2020, 3).Aggregate((a, x) => a * x),
			};

			using var f = new StreamWriter("output.txt");
			results.ForEach(x => f.WriteLine(x));
		}

		private static List<int> GetNumbersWithSumX(List<int> inputs, int sum, int quantityToSum)
		{
			var partial = new int[quantityToSum];
			return GetNumbersWithSumX(inputs, partial, sum, quantityToSum - 1, quantityToSum - 1, 0);
		}

		private static List<int> GetNumbersWithSumX(List<int> inputs, int[] partial, int sum, int initial, int remaining, int start)
		{
			for (int i = start; i < inputs.Count; i++)
			{
				partial[remaining] = inputs[i];
				if (remaining != 0)
				{
					var result = GetNumbersWithSumX(inputs, partial, sum, initial, remaining - 1, i + 1);
					if (result != null)
						return result;
				}
				else
				{
					if(partial.Sum() == sum)
						return partial.ToList();
				}
			}

			return null;
		}
	}
}

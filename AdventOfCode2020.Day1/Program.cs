// https://adventofcode.com/2020/day/1

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
				ProductOnSum20202Numbers(inputs),
				ProductOnSum20203Numbers(inputs)
			};

			using var f = new StreamWriter("output.txt");
			results.ForEach(x => f.WriteLine(x));
		}

		private static int ProductOnSum20202Numbers(List<int> inputs)
		{
			for (int i = 0; i < inputs.Count(); i++)
			{
				for (int j = i + 1; j < inputs.Count() - 1; j++)
				{
					if (inputs[i] + inputs[j] == 2020)
						return inputs[i] * inputs[j];
				}
			}

			throw new Exception("BOOBOO");
		}

		private static int ProductOnSum20203Numbers(List<int> inputs)
		{
			for (int i = 0; i < inputs.Count; i++)
			{
				for (int j = i + 1; j < inputs.Count - 1; j++)
				{
					for (int k = j + 1; k < inputs.Count - 2; k++)
					{
						if (inputs[i] + inputs[j] + inputs[k] == 2020)
							return inputs[i] * inputs[j] * inputs[k];
					}
				}
			}

			throw new Exception("BOOBOO");
		}
	}
}

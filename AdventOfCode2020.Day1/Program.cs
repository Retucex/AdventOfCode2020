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

			OutputProductOnSum20202Numbers(inputs);
			OutputProductOnSum20203Numbers(inputs);
		}

		private static void OutputProductOnSum20202Numbers(List<int> inputs)
		{
			for (int i = 0; i < inputs.Count(); i++)
			{
				for (int j = i + 1; j < inputs.Count() - 1; j++)
				{
					if (inputs[i] + inputs[j] == 2020)
						Console.WriteLine(inputs[i] * inputs[j]);
				}
			}
		}

		private static void OutputProductOnSum20203Numbers(List<int> lines)
		{
			for (int i = 0; i < lines.Count; i++)
			{
				for (int j = i + 1; j < lines.Count - 1; j++)
				{
					for (int k = j + 1; k < lines.Count - 2; k++)
					{
						if (lines[i] + lines[j] + lines[k] == 2020)
							Console.WriteLine(lines[i] * lines[j] * lines[k]);
					}
				}
			}
		}
	}
}

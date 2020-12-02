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
				SumNumbers.GetNumbersWithSumX(inputs, 2020, 2).Aggregate((a, x) => a * x),
				SumNumbers.GetNumbersWithSumX(inputs, 2020, 3).Aggregate((a, x) => a * x),
			};

			using var f = new StreamWriter("output.txt");
			results.ForEach(x => f.WriteLine(x));
		}
	}
}

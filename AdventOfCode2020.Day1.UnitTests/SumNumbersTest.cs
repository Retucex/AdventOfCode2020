using System;
using System.IO;
using System.Linq;
using Xunit;

namespace AdventOfCode2020.Day1.UnitTests
{
	public class SumNumbersTest
	{
		[Theory]
		[InlineData(2, 388075)]
		[InlineData(3, 293450526)]
		public void Test1(int numbersToSum, int expected)
		{
			var inputs = File.ReadLines("input.txt")
				.Select(int.Parse)
				.ToList();

			var result = SumNumbers.GetNumbersWithSumX(inputs, 2020, numbersToSum).Aggregate((a, x) => a * x);

			Assert.Equal(expected, result);
		}
	}
}

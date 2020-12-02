using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day1
{
	public class SumNumbers
	{
		public static List<int> GetNumbersWithSumX(List<int> inputs, int sum, int quantityToSum)
		{
			var partial = new int[quantityToSum];
			return GetNumbersWithSumX(inputs, partial, sum, 0);
		}

		private static List<int> GetNumbersWithSumX(List<int> inputs, int[] partial, int sum, int resultIndex)
		{
			for (int i = resultIndex; i < inputs.Count; i++)
			{
				partial[resultIndex] = inputs[i];
				if (resultIndex == partial.Length - 1)
				{
					if (partial.Sum() == sum)
						return partial.ToList();
				}
				else
				{
					var result = GetNumbersWithSumX(inputs, partial, sum, resultIndex + 1);
					if (result != null)
						return result;
				}
			}

			return null;
		}
	}
}
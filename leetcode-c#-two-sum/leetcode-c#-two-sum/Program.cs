﻿namespace leetcode_c__two_sum
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int[] nums = { 2, 7, 11, 15 };
			int target = 9;
			int[] result = new Program().TwoSum(nums, target);
			Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
		}

		public int[] TwoSum(int[] nums, int target)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[j] == target - nums[i])
					{
						return new int[] { i, j };
					}
				}
			}
			return new int[0] { };
		}
	}
}

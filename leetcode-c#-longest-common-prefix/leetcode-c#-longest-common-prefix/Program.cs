namespace leetcode_c__longest_common_prefix
{
	internal class Program
	{
		static void Main(string[] args)
		{ 
			string LongestCommonPrefix(string[] strs)
		{
			if (strs == null || strs.Length == 0) return "";
			string prefix = strs[0];
			for (int i = 1; i < strs.Length; i++)
			{
				while (strs[i].IndexOf(prefix) != 0)
				{
					prefix = prefix.Substring(0, prefix.Length - 1);

				}

			}
			return prefix;
		} }



			
	}
	
    }


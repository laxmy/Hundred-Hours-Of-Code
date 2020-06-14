using System;
using System.Collections.Generic;

namespace Hundred_Hours_Of_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution sol = new Solution();
            int[] nums = new int[]{1,2,4,8};
            IList<int> result = sol.LargestDivisibleSubset(nums);
            for(int i=0;i<result.Count;i++)
             Console.WriteLine(result[i]);
        }
    }
}

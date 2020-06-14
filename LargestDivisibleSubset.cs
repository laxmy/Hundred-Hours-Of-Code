using System;
using System.Collections.Generic;

public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        //dp[i] = max divisor count for nums[i]
      
        int[] divCount = new int[nums.Length];
        int []prev = new int[nums.Length]; 
        List<int> maxSubset = new List<int>();
     
        if(nums.Length == 0)
            return maxSubset;
        
        Array.Sort(nums);
        for(int i = 0; i < nums.Length; i++) 
        {
             divCount[i] = 1; 
             prev[i] = -1; 
        }
           
       // index at which last increment happened 
        int max_ind = 0; 
                
        for(int i=1;i<nums.Length;i++)
        {
            for(int j=0;j<i;j++)
            {
                if(nums[i]%nums[j]==0 && divCount[i]<divCount[j]+1)
                {
                    divCount[i]=divCount[j]+1;
                    prev[i] = j;             
                }
            }
            if (divCount[i] > divCount[max_ind]) 
                max_ind = i; 
        }
        int k = max_ind; 
        while (k >= 0)  
        { 
           maxSubset.Add(nums[k]);
           k =prev[k];
        } 
     return maxSubset;
    }
}

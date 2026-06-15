public class Solution 
{
    public int LengthOfLIS(int[] nums) 
    {
        int[] LIS = new int[nums.Length];
        Array.Fill(LIS, 1);
        int maxLIS = 1;

        for (int i = nums.Length - 2; i >= 0; i--) 
        {
            for (int j = i + 1; j < nums.Length; j++) 
            {
                if (nums[i] < nums[j]) 
                {
                    LIS[i] = Math.Max(LIS[i], LIS[j] + 1);
                    maxLIS = Math.Max(maxLIS, LIS[i]);
                }
            }
        }
        
        return maxLIS;
    }
}

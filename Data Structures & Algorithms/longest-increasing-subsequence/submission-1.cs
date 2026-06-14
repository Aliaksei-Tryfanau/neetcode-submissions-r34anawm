public class Solution 
{
    public int LengthOfLIS(int[] nums) 
    {
        int[] LIS = new int[nums.Length];

        for (int i = 0; i < LIS.Length; i++) 
        {
            LIS[i] = 1;
        }

        for (int i = nums.Length - 2; i >= 0; i--) 
        {
            for (int j = i + 1; j < nums.Length; j++) 
            {
                if (nums[i] < nums[j]) 
                {
                    LIS[i] = Math.Max(LIS[i], LIS[j] + 1);
                }
            }
        }
        
        return LIS.Max();
    }
}

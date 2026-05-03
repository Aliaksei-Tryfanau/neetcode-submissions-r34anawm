public class Solution 
{
    public int Jump(int[] nums) 
    {
        //bottom up
        // int n = nums.Length;
        // int[] dp = new int[n];
        // Array.Fill(dp, 1000000);
        // dp[n - 1] = 0;

        // for (int i = n - 2; i >= 0; i--) 
        // {
        //     int end = Math.Min(nums.Length, i + nums[i] + 1);

        //     for (int j = i + 1; j < end; j++) 
        //     {
        //         dp[i] = Math.Min(dp[i], 1 + dp[j]);
        //     }
        // }
        
        // return dp[0];

        int res = 0;
        int l = 0;
        int r = 0;

        while (r < nums.Length - 1) 
        {
            int farthest = 0;

            for (int i = l; i <= r; i++)
            {
                farthest = Math.Max(farthest, i + nums[i]);
            }

            l = r + 1;
            r = farthest;
            res++;
        }
        
        return res;
    }
}

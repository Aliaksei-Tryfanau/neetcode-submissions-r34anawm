public class Solution 
{
    public int Rob(int[] nums) 
    {
        // int rob1 = 0;
        // int rob2 = 0;

        // foreach (int num in nums) 
        // {
        //     int temp = Math.Max(num + rob1, rob2);  //2, 9, 10, 11, 16
        //     rob1 = rob2;                            //0, 2, 9,  10, 11
        //     rob2 = temp;                            //2, 9, 10, 11, 16
        // }

        // return rob2;

        if (nums.Length == 0) 
        {
            return 0;
        }

        if (nums.Length == 1) 
        {
            return nums[0];
        }

        int[] dp = new int[nums.Length];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < nums.Length; i++) 
        {
            dp[i] = Math.Max(dp[i - 1], nums[i] + dp[i - 2]);
        }

        return dp[nums.Length - 1];
    }
}

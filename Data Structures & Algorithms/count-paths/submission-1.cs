public class Solution 
{
    public int UniquePaths(int m, int n) 
    {
        int[,] dp = new int[m + 1, n + 1];
        dp[m - 1, n - 1] = 1;

        for (int i = m - 1; i >= 0; i--) 
        {
            for (int j = n - 1; j >= 0; j--) 
            {
                dp[i, j] += dp[i + 1, j] + dp[i, j + 1];
            }
        }

        return dp[0, 0];

        // int[] dp = new int[n];
        // Array.Fill(dp, 1);

        // for (int i = m - 2; i >= 0; i--) 
        // {
        //     for (int j = n - 2; j >= 0; j--) 
        //     {
        //         dp[j] += dp[j + 1];
        //     }
        // }

        // return dp[0];
    }
}

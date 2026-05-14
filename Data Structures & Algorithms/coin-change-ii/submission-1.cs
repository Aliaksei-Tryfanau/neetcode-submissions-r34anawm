public class Solution 
{
    public int Change(int amount, int[] coins) 
    {
        int n = coins.Length;
        Array.Sort(coins);
        int[,] dp = new int[n + 1, amount + 1];

        for (int i = 0; i <= n; i++) 
        {
            dp[i, 0] = 1;
        }

        for (int coinIndex = n - 1; coinIndex >= 0; coinIndex--)
         {
            for (int a = 0; a <= amount; a++) 
            {
                if (a >= coins[coinIndex]) 
                {
                    dp[coinIndex, a] = dp[coinIndex + 1, a];
                    dp[coinIndex, a] += dp[coinIndex, a - coins[coinIndex]];
                }
            }
        }

        return dp[0, amount];
    }
}

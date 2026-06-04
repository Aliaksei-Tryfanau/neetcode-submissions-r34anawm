public class Solution 
{
    // public int Change(int amount, int[] coins) 
    // {
    //     int n = coins.Length;
    //     Array.Sort(coins);
    //     int[,] dp = new int[n + 1, amount + 1];

    //     for (int i = 0; i <= n; i++) 
    //     {
    //         dp[i, 0] = 1;
    //     }

    //     for (int a = 0; a <= amount; a++) 
    //     {
    //         for (int coinIndex = n - 1; coinIndex >= 0; coinIndex--)
    //         {
    //             if (a >= coins[coinIndex]) 
    //             {
    //                 dp[coinIndex, a] = dp[coinIndex + 1, a];
    //                 dp[coinIndex, a] += dp[coinIndex, a - coins[coinIndex]];
    //             }
    //         }   
    //     }
        
    //     return dp[0, amount];
    // }

    public int Change(int amount, int[] coins) 
    {
        int[] dp = new int[amount + 1];
        dp[0] = 1;

        for (int i = coins.Length - 1; i >= 0; i--) 
        {
            for (int a = 1; a <= amount; a++) 
            {
                dp[a] += (coins[i] <= a ? dp[a - coins[i]] : 0);
            }
        }
        return dp[amount];
    }
}

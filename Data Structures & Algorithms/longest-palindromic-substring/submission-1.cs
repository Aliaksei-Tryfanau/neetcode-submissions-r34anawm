public class Solution 
{
    public string LongestPalindrome(string s) 
    {
        // int resIdx = 0;
        // int resLen = 0;
        // int n = s.Length;

        // bool[,] dp = new bool[n, n];

        // for (int i = n - 1; i >= 0; i--) 
        // {
        //     for (int j = i; j < n; j++) 
        //     {
        //         if (s[i] == s[j] && (j - i <= 2 || dp[i + 1, j - 1])) 
        //         {
        //             dp[i, j] = true;
        //             if (resLen < (j - i + 1)) 
        //             {
        //                 resIdx = i;
        //                 resLen = j - i + 1;
        //             }
        //         }
        //     }
        // }

        // return s.Substring(resIdx, resLen);

        int resLen = 0;
        int resIdx = 0;

        for (int i = 0; i < s.Length; i++) 
        {
            // odd length
            int l = i;
            int r = i;

            while (l >= 0 && r < s.Length && s[l] == s[r]) 
            {
                if (r - l + 1 > resLen) 
                {
                    resIdx = l;
                    resLen = r - l + 1;
                }

                l--;
                r++;
            }

            // even length
            l = i;
            r = i + 1;
            while (l >= 0 && r < s.Length && s[l] == s[r]) 
            {
                if (r - l + 1 > resLen)
                {
                    resIdx = l;
                    resLen = r - l + 1;
                }
                
                l--;
                r++;
            }
        }

        return s.Substring(resIdx, resLen);
    }
}

public class Solution 
{
    public int LongestConsecutive(int[] nums) 
    {
        HashSet<int> numSet = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in numSet) 
        {
            if (!numSet.Contains(num - 1)) 
            {
                int length = 1;

                while (numSet.Contains(num + length)) 
                {
                    length++;
                }

                longest = Math.Max(longest, length);
            }
        }

        return longest;

        // Dictionary<int, int> mp = new Dictionary<int, int>();
        // int res = 0;

        // foreach (int num in nums) 
        // {
        //     if (!mp.ContainsKey(num)) 
        //     {
        //         mp[num] = (mp.ContainsKey(num - 1) ? mp[num - 1] : 0) +
        //                   (mp.ContainsKey(num + 1) ? mp[num + 1] : 0) + 1;

        //         mp[num - (mp.ContainsKey(num - 1) ? mp[num - 1] : 0)] = mp[num];
        //         mp[num + (mp.ContainsKey(num + 1) ? mp[num + 1] : 0)] = mp[num];

        //         res = Math.Max(res, mp[num]);
        //     }
        // }
        // return res;
    }
}

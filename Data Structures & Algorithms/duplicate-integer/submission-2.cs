public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        // HashSet<int> seen = new HashSet<int>();

        // foreach(int num in nums)
        // {
        //     if(seen.Contains(num))
        //     {
        //         return true;
        //     }
            
        //     seen.Add(num);
        // }

        // return false;

        return new HashSet<int>(nums).Count < nums.Length;
    }
}
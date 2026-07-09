public class Solution 
{
    public int FindDuplicate(int[] nums) 
    {
        // foreach (int num in nums) 
        // {
        //     int idx = Math.Abs(num) - 1;

        //     if (nums[idx] < 0) 
        //     {
        //         return Math.Abs(num);
        //     }

        //     nums[idx] *= -1;
        // }
        
        // return -1;

        int slow = 0;
        int fast = 0;

        while (true) 
        {
            slow = nums[slow];
            fast = nums[nums[fast]];

            if (slow == fast) 
            {
                break;
            }
        }

        int slow2 = 0;

        while (true) 
        {
            slow = nums[slow];
            slow2 = nums[slow2];

            if (slow == slow2) 
            {
                return slow;
            }
        }
    }
}

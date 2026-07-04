public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        // int l = 0;
        // int r = nums.Length - 1;

        // while (l <= r) 
        // {
        //     int mid = (l + r) / 2;
        //     if (target == nums[mid]) 
        //     {
        //         return mid;
        //     }

        //     if (nums[l] <= nums[mid]) 
        //     {
        //         //check if we're in left section
        //         if (target > nums[mid] || target < nums[l]) 
        //         {
        //             l = mid + 1;
        //         } 
        //         else 
        //         {
        //             r = mid - 1;
        //         }
        //     } 
        //     else 
        //     {
        //         //check if we're in right section
        //         if (target < nums[mid] || target > nums[r]) 
        //         {
        //             r = mid - 1;
        //         } 
        //         else 
        //         {
        //             l = mid + 1;
        //         }
        //     }
        // }
        
        // return -1;

        int l = 0; 
        int r = nums.Length - 1;

        while (l < r) 
        {
            int m = (l + r) / 2;

            if (nums[m] > nums[r]) 
            {
                l = m + 1;
            } 
            else 
            {
                r = m;
            }
        }

        int pivot = l;
        l = 0;
        r = nums.Length - 1;

        if (target >= nums[pivot] && target <= nums[r]) 
        {
            l = pivot;
        } 
        else 
        {
            r = pivot - 1;
        }

        while (l <= r) 
        {
            int m = (l + r) / 2;

            if (nums[m] == target) 
            {
                return m;
            } 
            else if (nums[m] < target) 
            {
                l = m + 1;
            } 
            else 
            {
                r = m - 1;
            }
        }

        return -1;
    }
}

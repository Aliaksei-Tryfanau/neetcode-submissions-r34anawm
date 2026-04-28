public class Solution 
{
    // List<List<int>> res = new List<List<int>>();

    // public List<List<int>> CombinationSum(int[] nums, int target) 
    // {
    //     backtrack(0, new List<int>(), 0, nums, target);
    //     return res;
    // }

    // public void backtrack(int i, List<int> cur, int total, int[] nums, int target) 
    // {
    //     if(total == target) 
    //     {
    //         res.Add(cur.ToList());
    //         return;
    //     }

    //     if(total > target || i >= nums.Length) 
    //     {
    //         return;
    //     }

    //     cur.Add(nums[i]);
    //     backtrack(i, cur, total + nums[i], nums, target);
    //     cur.Remove(cur.Last());
    //     backtrack(i + 1, cur, total, nums, target);
    // }

    List<List<int>> res;

    public List<List<int>> CombinationSum(int[] nums, int target) 
    {
        res = new List<List<int>>();
        Array.Sort(nums);
        dfs(0, new List<int>(), 0, nums, target);

        return res;
    }

    private void dfs(int i, List<int> cur, int total, int[] nums, int target)
     {
        if (total == target) 
        {
            res.Add(new List<int>(cur));
            return;
        }

        for (int j = i; j < nums.Length; j++) 
        {
            if (total + nums[j] > target) 
            {
                return;
            }
            
            cur.Add(nums[j]);
            dfs(j, cur, total + nums[j], nums, target);
            cur.RemoveAt(cur.Count - 1);
        }
    }
}

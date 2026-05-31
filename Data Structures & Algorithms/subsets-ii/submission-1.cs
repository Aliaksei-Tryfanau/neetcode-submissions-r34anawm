public class Solution 
{
    private List<List<int>> res = new List<List<int>>();

    public List<List<int>> SubsetsWithDup(int[] nums) 
    {
        Array.Sort(nums);
        Backtrack(0, new List<int>(), nums);
        return res;
    }

    private void Backtrack(int i, List<int> subset, int[] nums)
     {
        res.Add(new List<int>(subset));

        for (int j = i; j < nums.Length; j++) 
        {
            if (j > i && nums[j] == nums[j - 1]) 
            {
                continue;
            }
            
            subset.Add(nums[j]);
            Backtrack(j + 1, subset, nums);
            subset.RemoveAt(subset.Count - 1);
        }
    }

    // public List<List<int>> SubsetsWithDup(int[] nums) 
    // {
    //     Array.Sort(nums);
    //     var res = new List<List<int>> { new List<int>() };
    //     int prevIdx = 0;
    //     int idx = 0;

    //     for (int i = 0; i < nums.Length; i++) 
    //     {
    //         idx = (i >= 1 && nums[i] == nums[i - 1]) ? prevIdx : 0;
    //         prevIdx = res.Count;
            
    //         for (int j = idx; j < prevIdx; j++) 
    //         {
    //             var tmp = new List<int>(res[j]);
    //             tmp.Add(nums[i]);
    //             res.Add(tmp);
    //         }
    //     }

    //     return res;
    // }
}

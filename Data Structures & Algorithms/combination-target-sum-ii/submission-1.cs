public class Solution 
{
    // private List<List<int>> res;

    // public List<List<int>> CombinationSum2(int[] candidates, int target) 
    // {
    //     res = new List<List<int>>();
    //     Array.Sort(candidates);
    //     Dfs(candidates, target, 0, new List<int>(), 0);

    //     return res;
    // }

    // private void Dfs(int[] candidates, int target, int i, List<int> cur, int total) 
    // {
    //     if (total == target) 
    //     {
    //         res.Add(new List<int>(cur));
    //         return;
    //     }

    //     if (total > target || i == candidates.Length) 
    //     {
    //         return;
    //     }

    //     cur.Add(candidates[i]);
    //     Dfs(candidates, target, i + 1, cur, total + candidates[i]);
    //     cur.RemoveAt(cur.Count - 1);

    //     while (i + 1 < candidates.Length && candidates[i] == candidates[i + 1]) 
    //     {
    //         i++;
    //     }
        
    //     Dfs(candidates, target, i + 1, cur, total);
    // }

    private static List<List<int>> res = new List<List<int>>();

    public List<List<int>> CombinationSum2(int[] candidates, int target) 
    {
        res.Clear();
        Array.Sort(candidates);

        dfs(0, new List<int>(), 0, candidates, target);
        return res;
    }

    private void dfs(int idx, List<int> path, int cur, int[] candidates, int target) 
    {
        if (cur == target) 
        {
            res.Add(new List<int>(path));
            return;
        }

        for (int i = idx; i < candidates.Length; i++) 
        {
            if (i > idx && candidates[i] == candidates[i - 1]) 
            {
                continue;
            }
            
            if (cur + candidates[i] > target) 
            {
                break;
            }

            path.Add(candidates[i]);
            dfs(i + 1, path, cur + candidates[i], candidates, target);
            path.RemoveAt(path.Count - 1);
        }
    }
}

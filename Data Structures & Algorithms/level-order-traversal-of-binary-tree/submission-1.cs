/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
 
public class Solution 
{
    List<List<int>> res = new List<List<int>>();

    public List<List<int>> LevelOrder(TreeNode root) 
    {
        Dfs(root, 0);
        return res;
    }

    private void Dfs(TreeNode node, int depth) 
    {
        if (node == null) 
        {
            return;
        }

        if (res.Count == depth) 
        {
            res.Add(new List<int>());
        }

        res[depth].Add(node.val);
        Dfs(node.left, depth + 1);
        Dfs(node.right, depth + 1);
    }
}

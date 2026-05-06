public class Solution 
{
    public int Trap(int[] height) 
    {
        if (height == null || height.Length == 0)
        {
            return 0;
        }

        int res = 0;
        int leftIndex = 0;
        int rightIndex = height.Length - 1;
        int leftMax = height[leftIndex];
        int rightMax = height[rightIndex];

        while(leftIndex < rightIndex)
        {
            if(leftMax < rightMax)
            {
                leftIndex++;
                leftMax = Math.Max(leftMax, height[leftIndex]);
                res += leftMax - height[leftIndex];
            }
            else
            {
                rightIndex--;
                rightMax = Math.Max(rightMax, height[rightIndex]);
                res += rightMax - height[rightIndex];
            }
        } 

        return res;
    }
}

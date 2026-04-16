public class Solution 
{
    public int Rob(int[] nums) 
    {
        int rob1 = 0;
        int rob2 = 0;

        foreach (int num in nums) 
        {
            int temp = Math.Max(num + rob1, rob2);  //2, 9, 10, 11, 16
            rob1 = rob2;                            //0, 2, 9,  10, 11
            rob2 = temp;                            //2, 9, 10, 11, 16
        }

        return rob2;
    }
}

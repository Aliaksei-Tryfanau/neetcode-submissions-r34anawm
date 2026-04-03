public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        int startIndex = 0;
        int endIndex = numbers.Length - 1;

        while(startIndex < endIndex)
        {
            int sum = numbers[startIndex] + numbers[endIndex];

            if(sum == target)
            {
                return new int[] { startIndex + 1, endIndex + 1 };
            }

            if(sum > target)
            {
                endIndex--;
            }
            else
            {
                startIndex++;
            }
        }

        return new int[0];
    }
}

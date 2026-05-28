public class Solution 
{
    public int[] DailyTemperatures(int[] temperatures) 
    {
        int[] res = new int[temperatures.Length];
        Stack<(int temp, int index)> stack = new Stack<(int, int)>(); // pair: [temp, index]

        for (int i = 0; i < temperatures.Length; i++) 
        {
            int t = temperatures[i];
            while (stack.Count > 0 && t > stack.Peek().temp) 
            {
                var pair = stack.Pop();
                res[pair.index] = i - pair.index;
            }

            stack.Push((t, i));
        }
        
        return res;
    }
}

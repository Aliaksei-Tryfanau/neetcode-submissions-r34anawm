public class Solution 
{
    public int CarFleet(int target, int[] position, int[] speed) 
    {
        //stack approach
        // int[][] pair = new int[position.Length][];

        // for (int i = 0; i < position.Length; i++) 
        // {
        //     pair[i] = new int[] { position[i], speed[i] };
        // }

        // Array.Sort(pair, (a, b) => b[0].CompareTo(a[0]));
        // Stack<double> stack = new Stack<double>();

        // foreach (var p in pair) 
        // {
        //     stack.Push((double)(target - p[0]) / p[1]);

        //     if (stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1)) 
        //     {
        //         stack.Pop();
        //     }
        // }
        
        // return stack.Count;

        int n = position.Length;
        int[][] pair = new int[n][];

        for (int i = 0; i < n; i++) 
        {
            pair[i] = new int[] { position[i], speed[i] };
        }

        Array.Sort(pair, (a, b) => b[0].CompareTo(a[0]));

        int fleets = 1;
        double prevTime = (double)(target - pair[0][0]) / pair[0][1];

        for (int i = 1; i < n; i++) 
        {
            double currTime = (double)(target - pair[i][0]) / pair[i][1];

            if (currTime > prevTime) 
            {
                fleets++;
                prevTime = currTime;
            }
        }
        
        return fleets;
    }
}

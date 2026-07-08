public class Solution 
{
    public int CanCompleteCircuit(int[] gas, int[] cost) 
    {
        //greedy
        // if (gas.Sum() < cost.Sum()) 
        // {
        //     return -1;
        // }

        // int total = 0;
        // int res = 0;

        // for (int i = 0; i < gas.Length; i++) 
        // {
        //     total += (gas[i] - cost[i]);

        //     if (total < 0) 
        //     {
        //         total = 0;
        //         res = i + 1;
        //     }
        // }

        // return res;

        int start = 0;
        int tank = 0;
        int total = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            int diff = gas[i] - cost[i];

            tank += diff;
            total += diff;

            if (tank < 0)
            {
                start = i + 1;
                tank = 0;
            }
        }

        return total >= 0 ? start : -1;
    }
}

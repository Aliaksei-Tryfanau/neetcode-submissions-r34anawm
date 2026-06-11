public class Solution 
{
    public int CarFleet(int target, int[] position, int[] speed) 
    {
        int n = position.Length;
        (int position, int speed)[] pair = new (int, int)[n];

        for (int i = 0; i < n; i++) 
        {
            pair[i] = (position[i], speed[i]);
        }

        Array.Sort(pair, (a, b) => (b.position).CompareTo(a.position));

        int fleets = 1;
        double prevTime = (double)(target - pair[0].position) / pair[0].speed;

        for (int i = 1; i < n; i++) 
        {
            double currTime = (double)(target - pair[i].position) / pair[i].speed;

            if (currTime > prevTime) 
            {
                fleets++;
                prevTime = currTime;
            }
        }
        
        return fleets;
    }
}

public class Solution 
{
    public double MyPow(double x, int n) 
    {
        if (x == 0) 
        {
            return 0;
        }

        if (n == 0) 
        {
            return 1;
        }

        // double res = 1;

        // for (int i = 0; i < Math.Abs(n); i++) 
        // {
        //     res *= x;
        // }
        
        // return n >= 0 ? res : 1 / res;

        double res = Helper(x, Math.Abs((long) n));
        return (n >= 0) ? res : 1 / res;
    }

    private double Helper(double x, long n) 
    {
        if (n == 0) 
        {
            return 1;
        }

        double half = Helper(x, n / 2);

        return (n % 2 == 0) ? half * half : x * half * half;
    }

    //O(log n)
}

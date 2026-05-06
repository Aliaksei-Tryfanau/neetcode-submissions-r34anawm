public class Solution 
{
    public int[] MaxSlidingWindow(int[] nums, int k) 
    {
        PriorityQueue<int , int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        int[] output = new int[nums.Length - k + 1];
        int idx = 0;

        for (int i = 0; i < nums.Length; i++) 
        {
            pq.Enqueue(i, nums[i]);

            if (i >= k - 1) 
            {
                while (pq.Peek() <= i - k) 
                {
                    pq.Dequeue();
                }

                output[idx] = nums[pq.Peek()];
                idx++;
            }
        }

        return output;

        // int n = nums.Length;
        // int[] output = new int[n - k + 1];
        // var q = new LinkedList<int>();
        // int l = 0, r = 0;

        // while (r < n) 
        // {
        //     while (q.Count > 0 && nums[q.Last.Value] < nums[r]) 
        //     {
        //         q.RemoveLast();
        //     }

        //     q.AddLast(r);

        //     if (l > q.First.Value) 
        //     {
        //         q.RemoveFirst();
        //     }

        //     if ((r + 1) >= k) 
        //     {
        //         output[l] = nums[q.First.Value];
        //         l++;
        //     }
            
        //     r++;
        // }

        // return output;
    }
}

public class Solution 
{
    //priority queue (n * log n)
    public int[] MaxSlidingWindow(int[] nums, int k) 
    {
        PriorityQueue<(int val, int idx), int> pq = new PriorityQueue<(int val, int idx), int>(
            Comparer<int>.Create((a, b) => b.CompareTo(a))
        );

        int[] output = new int[nums.Length - k + 1];
        int idx = 0;

        for (int i = 0; i < nums.Length; i++) 
        {
            pq.Enqueue((nums[i], i), nums[i]);

            if (i >= k - 1) 
            {
                while (pq.Peek().idx <= i - k) 
                {
                    pq.Dequeue();
                }

                output[idx++] = pq.Peek().val;
            }
        }

        return output;
    }

    // public int[] MaxSlidingWindow(int[] nums, int k) 
    // {
    //     int n = nums.Length;
    //     int[] output = new int[n - k + 1];
    //     var q = new LinkedList<int>();
    //     int l = 0, r = 0;

    //     while (r < n) 
    //     {
    //         while (q.Count > 0 && nums[q.Last.Value] < nums[r]) 
    //         {
    //             q.RemoveLast();
    //         }

    //         q.AddLast(r);

    //         if (l > q.First.Value) 
    //         {
    //             q.RemoveFirst();
    //         }

    //         if ((r + 1) >= k) 
    //         {
    //             output[l] = nums[q.First.Value];
    //             l++;
    //         }
            
    //         r++;
    //     }

    //     return output;
    // }
}

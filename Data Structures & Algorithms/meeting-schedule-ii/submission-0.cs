/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {
         if (intervals.Count == 0) return 0;
         intervals.Sort((i1,i2)=>i1.start.CompareTo(i2.start));
         PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
         pq.Enqueue(intervals[0].end, intervals[0].end);
         
         for(int i=1;i<intervals.Count();i++)
         {
            if(intervals[i].start >= pq.Peek())
            {
             pq.Dequeue();
            }
            pq.Enqueue(intervals[i].end, intervals[i].end);
         }
   return pq.Count;
    }
}

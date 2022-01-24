using System;

namespace LeetCode
{
    public class MeetingRoomTwoSolution
    {
        public int MinMeetingRooms(int[][] intervals) {
            Array.Sort(intervals, (a, b) =>
            {
                return a[0] - b[0];
            });

            return 0;
        }
    }
}
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class MeetingRoomsTwoSolution
    {
        public int MinMeetingRooms(int[][] intervals) {
            Array.Sort(intervals, (left, right) =>
            {
                return left[0] - right[0];
            });
            List<int[]> meetingRoomsHolder = new List<int[]>();
            meetingRoomsHolder.Add(intervals[0]);
            for (int i = 1; i < intervals.Length; i++)
            {
                int[] current = intervals[i];
                if (current[0] >= meetingRoomsHolder[0][1])
                {
                    meetingRoomsHolder[0][1] = current[1];
                }
                else
                {
                    meetingRoomsHolder.Add(current);
                }
                
                meetingRoomsHolder.Sort((left, right) =>
                {
                    return left[1] - right[1];
                });
            }

            return meetingRoomsHolder.Count;
        }
    }
}
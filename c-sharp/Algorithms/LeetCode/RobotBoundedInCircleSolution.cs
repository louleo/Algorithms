using System.Collections.Generic;

namespace LeetCode
{
    public class RobotBoundedInCircleSolution
    {
        public bool IsRobotBounded(string instructions)
        {
            /*
             * two conditions that robot bounded
             * 1. not at the origin location
             * 2. no the same direction as the original when not at the original location
             */
            int[][] directions = new[]
            {
                new[] {0, 1}, //N
                new[] {1, 0}, //E
                new[] {0, -1}, //S
                new[] {-1, 0} //W
            };


            int currentDirectionIndex = 0;
            int[] currentLocation = new[] {0, 0};
            foreach (var ins in instructions)
            {
                switch (ins)
                {
                    case 'L':
                        currentDirectionIndex -= 1;
                        if (currentDirectionIndex < 0)
                        {
                            currentDirectionIndex += 4;
                        }
                        break;
                    case 'R':
                        currentDirectionIndex += 1;
                        if (currentDirectionIndex >= 4)
                        {
                            currentDirectionIndex -= 4;
                        }
                        break;
                    case 'G':
                        currentLocation[0] += directions[currentDirectionIndex][0];
                        currentLocation[1] += directions[currentDirectionIndex][1];
                        break;
                }
            }

            return (currentLocation[0] == 0 && currentLocation[1] == 0) || (currentDirectionIndex != 0);


        }
    }
}
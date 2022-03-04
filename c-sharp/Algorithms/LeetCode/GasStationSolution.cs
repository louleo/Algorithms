namespace LeetCode
{
    public class GasStationSolution
    {
        public int CanCompleteCircuit(int[] gas, int[] cost) {

            int len = gas.Length;
            int i = 0;
            while(i < len)
            {
                int startIndex = 0;
                int gasSum = 0;
                int costSum = 0;
                while (startIndex < len)
                {
                    int j = (i + startIndex) % len;
                    costSum += cost[j];
                    gasSum += gas[j];
                    
                    if (costSum > gasSum)
                    {
                        break;
                    }
                    startIndex++;

                } 

                if (startIndex == len)
                {
                    return i;
                }
                else
                {
                    i += startIndex + 1;
                }
            }

            return -1;
        }
        
    }
}
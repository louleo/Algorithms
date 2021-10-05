using System.Collections.Generic;
namespace LeetCode
{
    public class FindAllNumbersDisappearedInAnArraySolution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            return FindDisappearedNumberInternal(nums);
        }


        private IList<int> FindDisappearedNumberInternal(int[] nums)
        {
            List<int> resultsList = new List<int>();
            int[] countNums = new int[nums.Length + 1];

            foreach (var item in nums)
            {
                countNums[item] += 1;
            }

            for (int i = 1; i < countNums.Length; i++)
            {
                if (countNums[i] == 0)
                {
                    resultsList.Add(i);
                }
            }

            return resultsList;
        }
    }
}
namespace LeetCode
{
    /*
     * Write a function to find the longest common prefix string amongst an array of strings.
     * If there is no common prefix, return an empty string "".
     */
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var result = "";
            if (strs.Length == 0)
            {
                return result;
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            char currentChar;
            for (int i = 0; i < strs[0].Length; i++)
            {
                currentChar = strs[0][i];
                foreach (var str in strs)
                {
                    if (str.Length <= i || str[i] != currentChar)
                    {
                        return result;
                    }
                }

                result += currentChar;
            }

            return result;
        }
    }
}
namespace LeetCode
{
    public class ReverseWordsInAStringSolution
    {
        public string ReverseWords(string s)
        {
            string[] strArr = s.Split(" ");
            string result = "";
            foreach (var str in strArr)
            {
                if (str.Contains(" ") || str.Length == 0)
                {
                    continue;
                }

                if (result.Length == 0)
                {
                    result = str;
                }
                else
                {
                    result = (str + " " + result);
                }
            }
            return result;
        }
    }
}
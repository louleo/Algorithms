namespace LeetCode.BinarySearch
{
    public class FirstBadVersionSolution
    {
        public int FirstBadVersion(int n)
        {
            return FirstBadVersionInternal(1, n);
        }

        public int FirstBadVersionInternal(int left, int right)
        {

            if (left == right)
            {
                return left;
            }
            
            int mid = left + ((right - left) / 2);

            if (IsBadVersion(mid))
            {
                return FirstBadVersionInternal(left, mid);
            }
            else
            {
                return FirstBadVersionInternal(mid + 1, right);
            }
        }

        protected bool IsBadVersion(int version)
        {
            return false;
        }
    }
}
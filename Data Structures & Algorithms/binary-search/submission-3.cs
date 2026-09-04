public class Solution
{
    public int Search(int[] nums, int target)
    {
        if (nums[0] > target || nums[nums.Length - 1] < target)
            return -1;

        if (nums.Length == 1)
            return nums[0] == target ? 0 : -1;

        int l = 0;
        int r = nums.Length - 1;

        while (l <= r)
        {
            int m = l + (r - l) / 2;

            if (nums[m] == target)
            {
                return m;
            }
            else if (nums[m] > target)
            {
                r = m - 1;
            }
            else
            {
                l = m + 1;
            }
        }

        return -1;
    }
}

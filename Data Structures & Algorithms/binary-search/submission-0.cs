public class Solution
{
    public int Search(int[] nums, int target)
    {
        if (target < nums[0] || target > nums[nums.Length - 1])
            return -1;

        if (nums.Length == 1)
        {
            return nums[0] == target ? 0 : -1;
        }

        int targetIndex = -1;

        int l = 0;
        int r = nums.Length - 1;


        while (l <= r)
        {
            int m = (l + r) / 2;

            if (nums[m] == target) return m;

            if (target < nums[m])
                r = m - 1;
            if (target > nums[m])
                l = m + 1;
        }

        return -1;
    }
}

public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        var list = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (list.Contains(nums[i])) return true;

            list.Add(nums[i]);
        }

        return false;
    }
}
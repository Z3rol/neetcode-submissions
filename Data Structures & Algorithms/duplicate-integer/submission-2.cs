public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        var appearedNums = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (appearedNums.Contains(nums[i])) return true;
            appearedNums.Add(nums[i]);
        }

        return false;
    }
}
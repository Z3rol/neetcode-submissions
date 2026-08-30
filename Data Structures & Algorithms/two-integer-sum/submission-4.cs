public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var numToIndex = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numToIndex.TryGetValue(complement, out int index))
                return [index, i];

            numToIndex[nums[i]] = i;
        }

        return [0, 0];
    }
}

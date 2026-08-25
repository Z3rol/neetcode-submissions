public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);

        int maxSequence = 0;

        for (int i = 0; i < nums.Length; i++)
            set.Add(nums[i]);

        for (int i = 0; i < nums.Length; i++)
        {
            if (!set.Contains(nums[i] - 1))
            {
                int currentSequence = 1;

                int currentNum = nums[i];
                while (set.Contains(currentNum + 1))
                {
                    currentSequence++;
                    currentNum++;
                }

                maxSequence = Math.Max(maxSequence, currentSequence);
            }
        }

        return maxSequence;
    }
}

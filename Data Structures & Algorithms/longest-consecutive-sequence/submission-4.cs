public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);

        int maxSequence = 0;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currentSequence = 1;

                int currentNum = num;
                while(set.Contains(currentNum + 1))
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

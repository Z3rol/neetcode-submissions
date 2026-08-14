public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var frequency = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!frequency.ContainsKey(nums[i]))
            {
                frequency[nums[i]] = 0;
            }
            
            frequency[nums[i]]++;
        }

        var sortedFrequency = frequency.OrderByDescending(n => n.Value).ToDictionary(n => n.Key, n => n.Value);

        var result = new int[k];

        int j = 0;

        foreach (var n in sortedFrequency)
        {
            result[j] = n.Key;
            j++;

            if (j == k) break;
        }

        return result;
    }
}
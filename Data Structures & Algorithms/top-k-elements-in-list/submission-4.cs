public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var numToFrequency = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            numToFrequency.TryAdd(nums[i], 0);
            numToFrequency[nums[i]]++;
        }

        var buckets = new List<int>[nums.Length + 1];

        foreach (var pair in numToFrequency)
        {
            int number = pair.Key;
            int frequency = pair.Value;

            if (buckets[frequency] == null)
                buckets[frequency] = new List<int>();

            buckets[frequency].Add(number);
        }

        var result = new int[k];
        int j = 0;

        for (int i = buckets.Length - 1; j < k; i--)
        {
            if (buckets[i] == null) continue;

            foreach (var num in buckets[i])
            {
                result[j++] = num;
            }
        }

        return result;
    }
}

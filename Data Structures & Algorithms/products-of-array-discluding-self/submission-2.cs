public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;

        int[] prefix = new int[n];
        prefix[0] = 1;

        for (int i = 1; i < n; i++)
        {
            prefix[i] = nums[i - 1] * prefix[i - 1];
        }

        int[] sufix = new int[n];
        sufix[n - 1] = 1;

        for (int i = n - 2; i >= 0; i--)
        {
            sufix[i] = nums[i + 1] * sufix[i + 1];
        }

        int[] result = new int[n];

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = prefix[i] * sufix[i];
        }

        return result;
    }
}

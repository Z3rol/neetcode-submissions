public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int l = 0;
        int r = numbers.Length - 1;

        while (l < r)
        {
            int val = numbers[l] + numbers[r];

            if (val == target)
            {
                return [l + 1, r + 1];
            }
            else if (val > target)
            {
                r--;
            }
            else
            {
                l++;
            }
        }

        return [0,0];
    }
}

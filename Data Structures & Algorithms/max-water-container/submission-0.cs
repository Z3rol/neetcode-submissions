public class Solution
{
    public int MaxArea(int[] heights)
    {
        var result = 0;

        int l = 0;
        int r = heights.Length - 1;

        while (l < r)
        {
            int currentAmount = Math.Min(heights[l], heights[r]) * (r - l);

            if (currentAmount > result) result = currentAmount;

            if (heights[l] <= heights[r]) l++;
            else r--;
        }

        return result;
    }
}

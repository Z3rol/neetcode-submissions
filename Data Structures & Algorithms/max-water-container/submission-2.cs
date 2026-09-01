public class Solution 
{
    public int MaxArea(int[] heights) 
    {
        int maxArea = 0;

        int l = 0;
        int r = heights.Length - 1;

        while (l < r)
        {
            int currentArea = Math.Min(heights[l], heights[r]) * (r - l);

            maxArea = Math.Max(maxArea, currentArea);

            if (heights[l] < heights[r])
            {
                l++;
                while (l < r && heights[l] <= heights[l - 1]) l++;
            }
            else
            {
                r--;
                while (l < r && heights[r] <= heights[r + 1]) r--;
            }
        }

        return maxArea;
    }
}

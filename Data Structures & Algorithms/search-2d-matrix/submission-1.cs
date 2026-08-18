public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int l = 0;
        int r = (rows * cols) - 1;

        while (l <= r)
        {
            int m = l + (r - l) / 2;

            int mNum = matrix[m / cols][m % cols];

            if (mNum == target)
            {
                return true;
            }
            else if (mNum < target)
            {
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }

        return false;
    }
}
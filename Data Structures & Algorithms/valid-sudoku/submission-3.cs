public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                char val = board[r][c];
                if (val == '.')
                    continue;

                int boxIdx = (r / 3) * 3 + (c / 3);

                if (rows[r].Contains(val) ||
                    cols[c].Contains(val) ||
                    boxes[boxIdx].Contains(val))
                {
                    return false;
                }

                rows[r].Add(val);
                cols[c].Add(val);
                boxes[boxIdx].Add(val);
            }
        }

        return true;
    }
}

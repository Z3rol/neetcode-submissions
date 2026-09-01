public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 1) return 1;

        var substring = new HashSet<char>();

        int longestSubstring = 0;

        int l = 0;

        for (int r = 0; r < s.Length; r++)
        {
            while (substring.Contains(s[r]))
            {
                substring.Remove(s[l]);
                l++;
            }

            substring.Add(s[r]);
            longestSubstring = Math.Max(longestSubstring, substring.Count);
        }

        return longestSubstring;
    }
}

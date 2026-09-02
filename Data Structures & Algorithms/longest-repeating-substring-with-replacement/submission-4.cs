public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int[] freq = new int[26];

        int longestWindow = 0;

        int l = 0;

        for (int r = 0; r < s.Length; r++)
        {
            freq[s[r] - 'A']++;

            int currentWindow = r - l + 1;

            int maxFreq = freq.Max();

            if (currentWindow - maxFreq > k)
            {
                freq[s[l] - 'A']--;
                l++;
            }

            longestWindow = Math.Max(longestWindow, r - l + 1);
        }

        return longestWindow;
    }
}

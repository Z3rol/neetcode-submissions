public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        var frequency = new int[26];

        int maxLength = 0;

        int l = 0;

        for (int r = 0; r < s.Length; r++)
        {
            frequency[s[r] - 'A']++;

            int maxFreq = frequency.Max();

            int currentWindowSize = r - l + 1;

            if (currentWindowSize - maxFreq > k)
            {
                frequency[s[l] - 'A']--;
                l++;
            }

            maxLength = Math.Max(maxLength, r - l + 1);
        }

        return maxLength;
    }
}

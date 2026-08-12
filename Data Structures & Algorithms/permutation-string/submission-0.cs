public class Solution
{
    private bool Matches(int[] s1Count, int[] s2Count)
    {
        for (int i = 0; i < 26; i++)
        {
            if (s1Count[i] != s2Count[i]) 
                return false;
        }
        return true;
    }

    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;

        var s1Count = new int[26];
        foreach (char c in s1) s1Count[c - 'a']++;

        var s2Count = new int[26];

        int l = 0;
        int r = s1.Length - 1;

        for (int i = l; i <= r; i++) s2Count[s2[i] - 'a']++;

        while (r < s2.Length)
        {
            if (Matches(s1Count, s2Count)) return true;

            s2Count[s2[l] - 'a']--;
            l++;

            r++;
            if (r < s2.Length) s2Count[s2[r] - 'a']++;
        }

        return false;
    }
}

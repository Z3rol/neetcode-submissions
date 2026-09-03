public class Solution
{
    public bool Matches(int[] count1, int[] count2)
    {
        for (int i = 0; i < 26; i++)
        {
            if (count1[i] != count2[i]) return false;
        }

        return true;
    }
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;

        int[] s1Count = new int[26];
        foreach (char c in s1)
        {
            s1Count[c - 'a']++;
        }

        int[] s2Count = new int[26];

        int l = 0;
        int r = s1.Length - 1;
        
        for (int i = l; i <= r; i++)
        {
            s2Count[s2[i] - 'a']++;
        }

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

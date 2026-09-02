public class Solution
{
    public string Sort(string s)
    {
        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }

    public bool CheckInclusion(string s1, string s2)
    {
        string s1Sorted = Sort(s1);

        int l = 0;
        int r = s1.Length - 1;
        
        while (r < s2.Length)
        {
            string substring = s2.Substring(l, r - l + 1);
            string substringSorted = Sort(substring);

            if (s1Sorted == substringSorted) return true;

            l++;
            r++;
        }

        return false;
    }
}

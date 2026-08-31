public class Solution
{
    public bool IsPalindrome(string s)
    {
        int l = 0;
        int r = s.Length - 1;

        while (l < r)
        {
            while (!char.IsLetterOrDigit(s[l]) && l < r) l++;
            while (!char.IsLetterOrDigit(s[r]) && l < r) r--;

            if (char.ToLower(s[l++]) != char.ToLower(s[r--])) return false;
        }

        return true;
    }
}

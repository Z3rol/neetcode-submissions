public class Solution
{
    public string Encode(IList<string> strs)
    {
        var sb = new StringBuilder();

        foreach (string s in strs)
        {
            sb.Append(s.Length).Append('#').Append(s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        var result = new List<string>();

        int i = 0;
        while (i < s.Length)
        {
            int j = i;
            while (s[j] != '#') j++;

            int length = int.Parse(s.Substring(i, j - i));

            i = j + 1;
            j = i + length;

            result.Add(s.Substring(i, length));

            i = j;
        }

        return result;
    }
}
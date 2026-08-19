public class Solution
{
    public string SortString(string s)
    {
        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }

    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var anagramGroups = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            string sortedStr = SortString(strs[i]);
            
            if (!anagramGroups.ContainsKey(sortedStr))
            {
                anagramGroups.Add(sortedStr, new List<string>());
            }

            anagramGroups[sortedStr].Add(strs[i]);
        }

        return new List<List<string>>(anagramGroups.Values);
    }
}
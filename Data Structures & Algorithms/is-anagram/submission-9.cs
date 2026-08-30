public class Solution
        {
            public bool IsAnagram(string s, string t)
            {
                if (s.Length != t.Length) return false;

                var lettersCount = new Dictionary<char, int>();

                for (int i = 0; i < s.Length; i++)
                {
                    if (!lettersCount.ContainsKey(s[i]))
                        lettersCount[s[i]] = 0;
                    lettersCount[s[i]]++;
                }

                for (int i = 0; i < s.Length; i++)
                {
                    if (!lettersCount.ContainsKey(t[i]))
                        return false;
                    lettersCount[t[i]]--;
                }

                foreach (var count in lettersCount.Values)
                {
                    if (count != 0) return false;
                }

                return true;
            }
        }
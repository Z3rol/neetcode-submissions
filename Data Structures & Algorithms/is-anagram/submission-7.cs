public class Solution
        {
            public bool IsAnagram(string s, string t)
            {
                if (s.Length != t.Length) return false;

                var lettersCount = new Dictionary<char, int>();

                var sChars = s.ToCharArray();
                var tChars = t.ToCharArray();

                for (int i = 0; i < sChars.Length; i++)
                {
                    if (!lettersCount.ContainsKey(sChars[i]))
                        lettersCount[sChars[i]] = 0;

                    lettersCount[sChars[i]]++;
                }

                for (int i = 0; i < tChars.Length; i++)
                {
                    if (!lettersCount.ContainsKey(tChars[i]))
                        return false;

                    lettersCount[tChars[i]]--;
                }

                foreach(var count in lettersCount.Values)
                {
                    if (count != 0) return false;
                }

                return true;
            }
        }
public class Solution
        {
            public bool IsAnagram(string s, string t)
            {
                if (s.Length != t.Length) return false;
                
                var appearedLetters = new List<char>();

                var sChars = s.ToCharArray();

                for (int i = 0; i < sChars.Length; i++)
                {
                    appearedLetters.Add(sChars[i]);
                }

                var tChars = t.ToCharArray();

                for (int i = 0; i < tChars.Length; i++)
                {
                    if (!appearedLetters.Contains(tChars[i]))
                        return false;

                    appearedLetters.Remove(tChars[i]);
                }

                if (appearedLetters.Count != 0) return false;

                return true;
            }
        }
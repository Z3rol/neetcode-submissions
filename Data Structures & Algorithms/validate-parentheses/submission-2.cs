public class Solution
{
    public bool IsValid(string s)
    {
        var parentheses = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if ("([{".Contains(s[i])) parentheses.Push(s[i]);
            else
            {
                if (parentheses.Count() == 0) return false;
                
                var lastParenhhese = parentheses.Peek();

                if (lastParenhhese == '(' && s[i] != ')'
                    || lastParenhhese == '[' && s[i] != ']'
                    || lastParenhhese == '{' && s[i] != '}')
                {
                    return false;
                }

                parentheses.Pop();
            }
        }

        if (parentheses.Count() != 0) return false;

        return true;
    }
}
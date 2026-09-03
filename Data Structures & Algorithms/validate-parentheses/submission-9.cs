public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0) return false;

        var stack = new Stack<char>();

        foreach (char c in s)
        {
            if ("})]".Contains(c))
            {
                if (stack.Count == 0) return false;

                char lastParenthese = stack.Pop();

                if (lastParenthese == '{' && c != '}' ||
                    lastParenthese == '[' && c != ']' ||
                    lastParenthese == '(' && c != ')') return false;
                
            }
            else
            {
                stack.Push(c);
            }
        }

        if (stack.Count == 0)
            return true;
        else
            return false;
    }
}

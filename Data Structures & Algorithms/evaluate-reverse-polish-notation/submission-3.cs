public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        for (int i = 0; i < tokens.Length; i++)
        {
            if ("+-*/".Contains(tokens[i]))
            {
                int secondVal = stack.Pop();
                int firstVal = stack.Pop();
                int result = 0;

                switch (tokens[i])
                {
                    case "+":
                        result = firstVal + secondVal;
                    break;

                    case "-":
                        result = firstVal - secondVal;
                    break;

                    case "*":
                        result = firstVal * secondVal;
                    break;

                    case "/":
                        result = firstVal / secondVal;
                    break;
                }

                stack.Push(result);
            }
            else
            {
                stack.Push(int.Parse(tokens[i]));
            }
        }

        return stack.Pop();
    }
}

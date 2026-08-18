public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        int n = position.Length;

        Array.Sort(position, speed);

        var stack = new Stack<double>();

        for (int i = n - 1; i >= 0; i--)
        {
            double timeToArrive = (double)(target - position[i]) / speed[i];

            if (stack.Count == 0 || timeToArrive > stack.Peek())
            {
                stack.Push(timeToArrive);
            }
        }

        return stack.Count();
    }
}

public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int k = 1;

        int l = 1;
        int r = piles.Max();

        while (l <= r)
        {
            int m = l + (r - l) / 2;
            
            int totalTime = 0;
            foreach (int pile in piles)
            {
                totalTime += (int) Math.Ceiling((double) pile / m);
            }

            if (totalTime <= h)
            {
                k = m;
                r = m - 1;
            }
            else
            {
                l = m + 1;
            }
        }

        return k;
    }
}

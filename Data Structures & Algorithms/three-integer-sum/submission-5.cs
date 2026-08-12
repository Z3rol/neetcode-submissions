public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);

        var result = new List<List<int>>();

        int l, r;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i != 0 && nums[i] == nums[i - 1]) continue;
            
            l = i + 1;
            r = nums.Length - 1;

            while (l < r)
            {
                int currentSum = nums[i] + nums[l] + nums[r];

                if (currentSum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[l], nums[r] } );

                    l++;
                    r--;

                    while (l < r && nums[l] == nums[l - 1]) l++;
                    while (l < r && nums[r] == nums[r + 1]) r--;
                }
                else if (currentSum < 0) l++;
                else r--;
            }
        }

        return result;
    }
}

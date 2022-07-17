namespace LeetCode
{
    public class RunningSumof1dArray
    {
        public int[] RunningSum(int[] nums)
        {
            int[] sums = new int[nums.Length];
            sums[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sums[i] = sums[i - 1] + nums[i];
            }
            return sums;
        }
    }
}
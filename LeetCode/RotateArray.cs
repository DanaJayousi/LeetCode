namespace LeetCode
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int[] res = (int[])nums.Clone();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[(k + i) % nums.Length] = res[i];
            }
        }
    }
}
namespace LeetCode
{
    public class TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int int1 = 0;
            int int2 = numbers.Length - 1;
            int[] res = new int[2];
            while (true)
            {
                int int3 = numbers[int1] + numbers[int2];
                if (int3 == target)
                {
                    res[0] = int1 + 1;
                    res[1] = int2 + 1;
                    break;
                }
                else if (int3 < target)
                {
                    int1++;
                }
                else
                {
                    int2--;
                }
            }
            return res;
        }
    }
}
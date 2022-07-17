namespace LeetCode
{
    public class MedianofTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            float value = 0;
            if (nums1.Length == 0)
            {
                if (nums2.Length % 2 == 1)
                {
                    value = nums2[(nums2.Length - 1) / 2];
                }
                else
                {
                    value = (nums2[nums2.Length / 2] + nums2[(nums2.Length / 2) - 1]);
                    value /= 2;

                }
                return value;
            }
            if (nums2.Length == 0)
            {
                if (nums1.Length % 2 == 1)
                {
                    value = nums1[(nums1.Length - 1) / 2];
                }
                else
                {
                    value = (nums1[nums1.Length / 2] + nums1[(nums1.Length / 2) - 1]);
                    value /= 2;

                }
                return value;
            }
            int i = 0;
            int j = 0;
            int[] arr = new int[nums1.Length + nums2.Length];

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] > nums2[j])
                {
                    arr[i + j] = nums2[j];
                    j++;
                }
                else
                {
                    arr[i + j] = nums1[i];
                    i++;
                }
                if (i == nums1.Length)
                {
                    while (j < nums2.Length)
                    {
                        arr[i + j] = nums2[j];
                        j++;
                    }
                }
                else if (j == nums2.Length)
                {
                    while (i < nums1.Length)
                    {
                        arr[i + j] = nums1[i];
                        i++;
                    }
                }

            }
            if (arr.Length % 2 == 1)
            {
                value = arr[arr.Length / 2];
            }
            else
            {
                value = (arr[arr.Length / 2] + arr[(arr.Length / 2) - 1]);
                value /= 2;
            }
            return value;
        }
    }
}
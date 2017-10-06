using System;

namespace algorithms
{
    // Merge the arrays then find the median trivially.
    public class Solution004
    {
        public static void Main(string[] args)
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };
            double answer = new Solution004().FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine(answer);
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // Merge the sorted arrays to newly sorted array.
            int[] arr = new int[nums1.Length + nums2.Length];
            int i = 0, j = 0, k = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    arr[k] = nums1[i];
                    i++;
                }
                else
                {
                    arr[k] = nums2[j];
                    j++;
                }
                k++;
            }
            while (i < nums1.Length)
            {
                arr[k] = nums1[i];
                k++;
                i++;
            }
            while (j < nums2.Length)
            {
                arr[k] = nums2[j];
                k++;
                j++;
            }
            return GetArrayMedian(arr);
        }


        // Find the median of the merged arrays.
        private double GetArrayMedian(int[] arr)
        {
            int len = arr.Length;
            int mid = len / 2;
            if (len % 2 == 0)
            {
                return (double)(arr[mid] + arr[mid - 1]) / 2;
            }
            else
            {
                return arr[mid];
            }
        }
    }
}
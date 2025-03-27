using System.Drawing;

namespace 最长连续递增子数组
{
    /// <summary>
    /// 波科实际面试算法题。
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] nums = { 1, 3, 5, 4, 7,8,1,2,3,4,9,10,2 };

            var longestIncreasingSubarray = FindLongestIncreasingSubarray(nums);

            foreach (int num in longestIncreasingSubarray)
            {
                Console.WriteLine(num);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ReadLine();
        }


        public static int[] FindLongestIncreasingSubarray(int[] nums)
        {
            int start = 0;
            int maxLength = 0;
            int length = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    length++;
                }
                else
                {
                    if (length > maxLength)
                    {
                        maxLength = length;
                        start = i - length;
                    }
                    length = 1;
                }
            }
            if (length > maxLength)
            {
                maxLength = length;
                start = nums.Length - length;
            }
            int[] result = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                result[i] = nums[start + i];
            }
            return result;
        }


        public static int[] FindLongestIncreasingSubarrayLXW(int[] nums)
        {
            int maxLength = 1;
            int start = 0;
            int length = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i-1])
                {
                    length++;
                }
                else
                {
                    if(length > maxLength)
                    {
                        maxLength = length;
                        start = i-length;
                    }
                    length = 1;
                }
            }
            if (length > maxLength)
            {
                maxLength = length;
                start = nums.Length - length;
            }
            int[] result = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                result[i] = nums[start + i];
            }
            return result;
        }
    }
}

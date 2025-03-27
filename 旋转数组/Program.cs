
namespace 旋转数组
{
    /// <summary>
    /// 题目 1: 旋转数组
    //描述：
    //给定一个数组 nums 和一个整数 k，你需要将数组中的元素向右旋转 k 步。例如，[1, 2, 3, 4, 5, 6, 7] 和 k = 3 时，旋转后的数组应为[5, 6, 7, 1, 2, 3, 4]。
    
    //要求：
    //不能使用额外的空间（即只能在原数组上操作，不能使用额外的数组）。
    
    //你可以假设 k 是非负整数。
//  输入: nums = [1,2,3,4,5,6,7], k = 3
//  输出: [5, 6, 7, 1, 2, 3, 4]
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 }; //[5,6,7,1,2,3,4]。
            int k = 3;
            var rotatedNums = GetRotatedNums(nums, k);
            Console.WriteLine(nums.Length);
            foreach(var item in rotatedNums)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }


        /// <summary>
        /// 借助了额外空间 （bad）
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        private static int[] GetRotatedNums(int[] nums, int k)
        {
            if(k%nums.Length == 0)
            {
                return nums;
            }
            int realRotate = k % nums.Length;
            int[] newNums = new int[nums.Length];
            for (int i = 0; i<nums.Length; i++) 
            {
                if(i < realRotate)
                {
                    newNums[i] = nums[nums.Length - realRotate + i];
                }
                else
                {
                    newNums[i] = nums[i - realRotate];
                }
            }

            return newNums;
        }

        /// <summary>
        /// 不借助，原地旋转
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        private static int[] GetRotatedNums2(int[] nums, int k)
        {
            if (k % nums.Length == 0)
            {
                return nums;
            }
            int realRotate = k % nums.Length;
            //步骤1，反转整个数组
            var reversedNums = nums.Reverse();  //1,2,3,4,5,6,7 ===>7,6,5,4,3,2,1
            for(int i =0;i< realRotate; i++)
            {
                
            }

            return null;
        }


        ///实现反转数组
        private static int[] GetReversedNums(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
                right--;
            }
            return nums;
        }
    }
}

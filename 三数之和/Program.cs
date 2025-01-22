namespace 三数之和
{

    //给你一个整数数组 nums ，判断是否存在三元组[nums[i], nums[j], nums[k]] 满足 i != j、i != k 且 j != k ，
    //同时还满足 nums[i] + nums[j] + nums[k] == 0 。请你返回所有和为 0 且不重复的三元组。
    //注意：答案中不可以包含重复的三元组。
    internal class Program
    {
        //输入：nums = [-1,0,1,2,-1,-4]
        //输出：[[-1,-1,2],[-1,0,1]]
        //解释：
        //nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0 。
        //nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0 。
        //nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0 。
        //不同的三元组是[-1, 0, 1] 和[-1, -1, 2] 。
        //注意，输出的顺序和三元组的顺序并不重要。
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var result = ThreeSum(nums);

            // 打印结果
            foreach (var triplet in result)
            {
                Console.WriteLine($"[{string.Join(", ", triplet)}]");
            }

            Console.Read();
        }

        static int []nums = { -1, 0, 1, 2, -1, 4 };

        /// <summary>
        /// 算法逻辑
        //排序数组：先对数组进行排序，这样可以简化查找过程。
        //遍历数组：对于每个元素，使用双指针法寻找满足和为 0 的三元组。
        //去重：跳过重复的数字，避免重复的三元组。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums); // 排序数组

            for (int i = 0; i < nums.Length - 2; i++)
            {
                // 跳过重复的数字
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        // 找到三元组
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        // 跳过重复的数字
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;

                        // 移动指针
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++; // 增加和
                    }
                    else
                    {
                        right--; // 减少和
                    }
                }
            }

            return result;
        }
    }
}

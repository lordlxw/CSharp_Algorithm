using System.Diagnostics;

namespace 数元素
{

    //LeetCode 1426 题：数元素解题全解析
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int num = CalcNumbersInRules官方(number1);
            stopwatch.Stop();
            // 获取微秒
            double microseconds = stopwatch.ElapsedTicks / (Stopwatch.Frequency / 1000000.0);
            Console.WriteLine($"数元素的结果是{num},耗时{microseconds}");
           
            Console.Read();
        }


        static int[] number1 = { 1, 1, 2, 3, 4, 5, 1, 4, 76, 7, 6, 6, 77, 88, 19, 76 };


        static int[] number2 = { 1, 1, 3, 3, 5, 5, 7, 7 };


        public static int CalcNumbersInRules官方(int[] numbers)
        {
            // 使用 HashSet 来存储数组元素，查找效率更高
            HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

            // 初始化计数器
            int count = 0;

            // 遍历数组中的每个元素
            foreach (int number in numbers)
            {
                // 判断 number + 1 是否在 uniqueNumbers 中
                if (uniqueNumbers.Contains(number + 1))
                {
                    count++;
                }
            }

            return count;
        }

        public static int CalcNumbersInRules(int[] numbers)
        {
            List<int> result = new List<int>();
            result.Add(0);
            foreach (int number in numbers)
            {
                if(numbers.Where(o=>o==number+1).Any())
                {
                    result[0] += 1;
                }
            }
            if(result.Count==0)
            {
                return 0;
            }else
            {
                int calcNum = 0;
                foreach (var item in result)
                {
                    calcNum += item;
                }
                return calcNum;
            }
           
            
        }
    }


    
    //一、题目剖析给定一个整数数组 arr，这里有着独特的计数规则：对于元素 x，唯有当 x + 1 也在数组 arr 中时，这个 x 才能被记为 1 个数。
    //特别要注意的是，若数组 arr 中有重复的数，每个重复的数都要单独依据此规则进行计算。比如，示例 1 中输入 arr = [1, 2, 3]，输出为2。
    //这是因为1对应的2在数组中，2对应的3也在数组中，所以1和2都满足计数条件，可被计算。
    //而在示例 2 中，输入arr = [1, 1, 3, 3, 5, 5, 7, 7]，输出是0。原因在于数组中不存在2、4、6、8，致使1、3、5、7均不符合计数条件。
    //同时，题目还给出了约束：1 <= arr.length <= 1000，0 <= arr[i] <= 1000。
}

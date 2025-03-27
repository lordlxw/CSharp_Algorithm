namespace 下一个排列
{
    internal class Program
    {
        //来源：LeetCode第31题
        //难度：中等
        //实现获取==下一个排列==的函数，算法需要将给定数字序列重新排列成字典序中下一个更大的排列（即，组合出下一个更大的整数）。
        //如果不存在下一个更大的排列，则将数字重新排列成最小的排列（即升序排列）。
        //必须原地修改，只允许使用额外常数空间。

        //地址：https://mp.weixin.qq.com/s/24gfNui5Ul1acC7LdiySow
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static int[] numbers = {1,2,3};   //123=>132=>213=>231=>312=>321=>123

        public int[] GetNextArray(int[] numbers)
        {
            //判断 如果数组从前往后是倒序排列，就说明是最大的了。
            Array.Sort(numbers);
            List<int> list = new List<int>();
            list=numbers.ToList();


            return numbers;
        }
    }
}

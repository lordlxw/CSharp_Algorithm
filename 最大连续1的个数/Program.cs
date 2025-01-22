namespace 最大连续1的个数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var temp = GetMaxOneLength官方(num);
            Console.WriteLine($"最多连续的1为{temp}个");
            Console.Read();
        }
        static int[] num = { 1, 0,1,1,0,1,1,1,1,1,0,0,1,0 };    //1、0、2、1、0、5、4、3、2、1、0、0、1、0
        //问题背景在给定的二进制数组nums中，我们的目标是找到最长的连续1的序列。
        //与以往不同的是，这次我们允许翻转最多一个0，使其变为1。
        //这意味着我们可以改变数组中的一个0，以期望获得更长的连续1序列。
        //输入输出要求输入：一个二进制数组nums。输出：一个整数，表示在最多翻转一个0的情况下，数组中连续1的最大个数。
        //    示例示例1：输入：nums = [1, 0, 1, 1, 0] 输出：4
        //    解释：翻转第一个0可以得到最长的连续1。翻转后，最大连续1的个数为4。


        public static int GetMaxOneLength(int[] num)
        {
            List<int> oneList = new List<int>();   
            for(int i=0; i<num.Length; i++) 
            {
                int tempLength = 0;
                int tempNum = num[i];
                int tempIndex = i;
                while(tempNum != 0)
                {
                    tempNum = num[++tempIndex];
                    tempLength++;
                    
                }
                oneList.Add(tempLength);

            }

            List<int> countNum = new();
            for (int j = 0; j < oneList.Count; j++)
            {
               if(j==0)
                {

                }
            }
            return num.Length;
        }

        public static int GetMaxOneLength官方(int[] num)
        {
            int left = 0;    // 左指针
            int right = 0;   // 右指针
            int maxLength = 0;  // 最大连续1的长度
            int zeroCount = 0;  // 窗口内的0的个数

            while (right < num.Length)
            {
                // 如果当前元素是0，增加零的计数
                if (num[right] == 0)
                {
                    zeroCount++;
                }

                // 当零的个数超过1时，移动左指针，缩小窗口
                while (zeroCount > 1)
                {
                    if (num[left] == 0)
                    {
                        zeroCount--;
                    }
                    left++;
                }

                // 计算当前窗口的长度，并更新最大长度
                maxLength = Math.Max(maxLength, right - left + 1);

                // 移动右指针扩大窗口
                right++;
            }

            return maxLength;
        }

    }
}

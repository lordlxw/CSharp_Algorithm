namespace LRU_最近最少使用_缓存
{
    /// <summary>
    /// 输入
//["LRUCache", "put", "put", "get", "put", "get", "put", "get", "get", "get"]
//[[2], [1, 1], [2, 2], [1], [3, 3], [2], [4, 4], [1], [3], [4]]
//输出
//[null, null, null, 1, null, -1, null, -1, 3, 4]

//解释
//LRUCache lRUCache = new LRUCache(2);
//    lRUCache.put(1, 1); // 缓存是 {1=1}
//lRUCache.put(2, 2); // 缓存是 {1=1, 2=2}
//lRUCache.get(1);    // 返回 1
//lRUCache.put(3, 3); // 该操作会使得关键字 2 作废，缓存是 {1=1, 3=3}
//lRUCache.get(2);    // 返回 -1 (未找到)
//lRUCache.put(4, 4); // 该操作会使得关键字 1 作废，缓存是 {4=4, 3=3}
//lRUCache.get(1);    // 返回 -1 (未找到)
//lRUCache.get(3);    // 返回 3
//lRUCache.get(4);    // 返回 4
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            LRUCache lRUCache = new LRUCache(2);
            lRUCache.Put(1, 1);
            lRUCache.Put(2, 2);
            lRUCache.Get(1);
            lRUCache.Put(3,3);
            lRUCache.Get(2);
            lRUCache.Put(4,4);
            lRUCache.Get(1);
            lRUCache.Get(3);
            lRUCache.Get(4);

        }
    }


    public class LRUCache
    {
        public int Capacity { get; set; }
        Dictionary<int, int> keyValuePairs = new();
        public LRUCache(int capacity)
        {
            Capacity = capacity;
        }

        public int Get(int key)
        {
            LinkedListNode
               
        }

        public void Put(int key, int value)
        {
            if(keyValuePairs.ContainsKey(key))
            {
                keyValuePairs.Remove(key);
                keyValuePairs.TryAdd(key, value);
            }else
            {
                keyValuePairs.TryAdd(key, value);

            }
        }
    }
}

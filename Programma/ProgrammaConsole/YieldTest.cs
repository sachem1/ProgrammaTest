using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Programma
{
    public class YieldTest
    {
        static List<int> dataList = new List<int>();
        public static void InitLargeData()
        {

            for (int i = 0; i < 100; i++)
            {
                dataList.Add(i);
            }
        }


        public static IEnumerable<int> NormalReturn()
        {
            var total = new List<int>();
            for (int i = 0; i < dataList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("1-----" + i);
                    total.Add(i);
                }
            }
            return total;
        }
        /// <summary>
        /// 频繁的单个网络请求可以有效,不必全部查询到了,再去处理
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<int> YieldReturn()
        {
            var total = new List<int>();
            for (int i = 0; i < dataList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("2-----"+i);
                    yield return i;
                }
                total.Add(i);
            }
        }
        public override string ToString()
        {
            return "123";
        }
    }
}

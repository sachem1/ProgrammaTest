using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Programma
{
    public class YieldTest
    {
        static List<int> dataList = new List<int>();
        public  void LargeDataTest()
        {
            
            for (int i = 0; i < 10000; i++)
            {
                dataList.Add(i);
            }
        }


        public static IEnumerable<int> NormalReturn()
        {
            var total = new List<int>();
            for (int i = 0; i <dataList.Count ; i++)
            {
                if (i == 6543)
                {
                    return total;
                }
               total.Add(i);
            }

            Console.WriteLine($"结果是:{total.Count}");
            return null;
        }

        public static IEnumerable<int> YieldReturn()
        {
            for (int i = 0; i < dataList.Count; i++)
            {
                if (i == 6543)
                {
                   yield return i;
                }
            }
        }
        public override string ToString()
        {
            return "123";
        }
    }
}

using System;
using System.Diagnostics;
using Programma;

namespace ProgrammaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            YieldTest.InitLargeData();
            Test1();
            //Test2();
            Console.ReadLine();
        }

        private static void Test1()
        {
            Stopwatch _watch = new Stopwatch();
            _watch.Start();
            foreach (var item in YieldTest.NormalReturn())
            {
                Console.WriteLine($"变量值1:{item}");
            }
            long times = _watch.ElapsedMilliseconds;

            _watch.Restart();
            foreach (var item in YieldTest.YieldReturn())
            {
                Console.WriteLine($"变量值2:{item}");
            }
            Console.WriteLine($"1花费:{times}");
            Console.WriteLine($"2花费:{_watch.ElapsedMilliseconds}");
        }

        private static void Test2()
        {
            Stopwatch _watch = new Stopwatch();
            _watch.Start();
            foreach (var item in YieldTest.YieldReturn())
            {
                Console.WriteLine($"变量值1:{item}");
            }
            long times = _watch.ElapsedMilliseconds;

            _watch.Restart();
            foreach (var item in YieldTest.NormalReturn())
            {
                Console.WriteLine($"变量值2:{item}");
            }
            Console.WriteLine($"1花费:{times}");
            Console.WriteLine($"2花费:{_watch.ElapsedMilliseconds}");
        }
    }
}

using System;
using System.Collections.Generic;

namespace m_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] array = { 1, 2, 3, 4 };

            Console.WriteLine("遍历:");
            Action<int> action = delegate (int item)
             { Console.WriteLine(item); };
            //输出
            Array.ForEach(array, action);

            int temp_max=int.MinValue;
            //求最大值
            Action<int> action1 = a =>
            {
                if (a > temp_max) { temp_max = a; }
                
            };
            Array.ForEach(array, action1);
            Console.WriteLine("max=" + temp_max);
            

            int temp_min=int.MaxValue;
            //求最小值
            Action<int> action2 = a =>
            {
                if (a < temp_min) { temp_min = a; }
                
            };
            Array.ForEach(array, action2);
            Console.WriteLine("min=" + temp_min);

            int temp_sum=0;
            //求和
            Action<int> action3 = a => { temp_sum += a; };
            Array.ForEach(array, action3);
            Console.WriteLine("sum=" + temp_sum);




        }
    }
}

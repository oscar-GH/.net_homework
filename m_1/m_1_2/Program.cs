using System;

namespace m_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] Arr_test = { 3, 7, 9, 13, 16, 23,28, 33, 37 };
            OutputMaxEle(Arr_test);
            OutputMinEle(Arr_test);
            GetSum(Arr_test);
            GetAve(Arr_test);
        }


        public static void OutputMaxEle(int[] Arr)
        {
            int temp_max=Arr[0];
            foreach(int element in Arr)
            {
                if(element>temp_max)//比较大小
                {
                    temp_max = element;
                }
            }
            Console.WriteLine("Max Element is " + temp_max);
        }

        public static void OutputMinEle(int[] Arr)
        {
            int temp_min = Arr[0];
            foreach(int element in Arr)
            {
                if(element<temp_min)//比较大小
                {
                    temp_min = element;
                }
            }
            Console.WriteLine("Min Element is " + temp_min);
        }

        public static void GetSum(int [] Arr)
        {
            int temp_sum=0;
            foreach(int element in Arr)//求和
            {
                temp_sum += element;
            }
            Console.WriteLine("Sum is " + temp_sum);
        }

        public static void GetAve(int[] Arr)
        {
            int temp_sum = 0;
            double Average = 0;
            foreach (int element in Arr)//求和
            {
                temp_sum += element;
            }
            Average = temp_sum / Arr.Length;//求平均值
            Console.WriteLine("Average Value is " + Average);

        }


    }
}

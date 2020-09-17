using System;

namespace m_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            Console.WriteLine("please input an integer number:");
            string inputString;
            double inputNumber;
            inputString = Console.ReadLine();
            inputNumber = Double.Parse(inputString);
            Console.WriteLine("factor(s):");
            Output(inputNumber, 2);
            Console.WriteLine("fin!");
        }

        public static void Output(double dividend, int divisor )
        {
            double temp = dividend;
            
            if(dividend%divisor==0)//如果能够整除
            {
                Console.WriteLine(" " + divisor);
                temp = dividend / divisor;
                if (temp!=1) { Output(temp, divisor); }//当此时商！=1时，则递归
            }
            else
            {
                //进入到下一个因子
                divisor++;
                Output(temp, divisor);
            }
            
        }




    }
}

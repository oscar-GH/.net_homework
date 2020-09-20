using System;
using System.Collections.Generic;

namespace m_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Creating 10 Forms!");
            Random rm = new Random();
           // rm.Next(3, 4);
            List<BaseForm> baseForm = new List<BaseForm>();
            double Propotion_sum=0;
            for(int i=0;i<10;i++)
            {
                FormFactory temp = new FormFactory();
                BaseForm BF_temp = null;

                bool UNdone = true;//判断是否已生成1个合法形状

                while (UNdone) { 

                 BF_temp=temp.CreateForm(rm.Next(3, 4));


                if(BF_temp.IsLegalForm())
                {
                    baseForm.Add(BF_temp);
                        UNdone = false;
                    Propotion_sum += baseForm[i].ReturnPropotion();
                }
                //baseForm.Add(FormFactory.CreateForm(rm.Next(3, 4)));
                //Propotion_sum += baseForm[i].ReturnPropotion();
                }

            }
            Console.WriteLine("面积之和：" + Propotion_sum);

        }
    }
   public abstract class BaseForm
    {
        public int n;
        public double propotion;


        abstract public bool IsLegalForm();//判断形状是否合法
        abstract public void Propotion();//面积
        //abstract public void SetSide();
        abstract public double ReturnPropotion();//返回面积

    }

    class Triangle : BaseForm
    {
        new public int n = 3;
        public int side1, side2, side3;


        public Triangle(int n1, int n2, int n3)
        {
            side1 = n1;
            side2 = n2;
            side3 = n3;
        }
        override public bool IsLegalForm()
        {
            int dif1 = side1 + side2 - side3;
            int dif2 = side1 + side3 - side2;
            int dif3 = side2 + side3 - side1;
            if (side1 > 0 && side2 > 0 && side3 > 0 && dif1 > 0 && dif2 > 0 && dif3 > 0) { return true; }
            else { return false; }
        }

        public override void Propotion()
        {
            //throw new NotImplementedException();

            double p = (side1 + side2 + side3) / 2;

            propotion = System.Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public override double ReturnPropotion()
        {
            double p = (side1 + side2 + side3) / 2;

            propotion = System.Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            return propotion;
            //throw new NotImplementedException();
        }
    }


    class Rectangle : BaseForm
    {
        new public int n = 4;
        public int length, height;
        public Rectangle(int n1, int n2)
        {
            height = n1;
            length = n2;
        }
        public override bool IsLegalForm()
        {
            //throw new NotImplementedException();
            if (height > 0 && length > 0) { return true; }
            else { return false; }
        }
        public override void Propotion()
        {
            //throw new NotImplementedException();
            propotion = height * length;
        }

        public override double ReturnPropotion()
        {
            // throw new NotImplementedException();
            propotion = height * length;
            return propotion;
        }
    }

    class Square : Rectangle
    {
        public Square(int n1, int n2) : base(n1, n2)
        {
            height = n1;
            length = n2;
        }
        public override bool IsLegalForm()
        {
            //return base.IsLegalForm();
            if (height == length) { return true; }
            else { return false; }
        }


    }






    public class FormFactory
    {
        public  BaseForm CreateForm(int n)
        {
           BaseForm BF = null;
            switch(n)
            {
                case 3://三角形
                    Random N3_1 = new Random();
                    Random N3_2 = new Random();
                    Random N3_3 = new Random();
                     BF = new Triangle(N3_1.Next(1,10),N3_2.Next(1,10),N3_3.Next(1,10));
                    break;
                case 4://长方形
                    Random N4_1 = new Random();
                    Random N4_2 = new Random();
                     BF = new Rectangle(N4_1.Next(1,10),N4_2.Next(1,10));
                    break;
                default:
                    BF = null;
                    break;

            }

            return BF; 
        }
    }
}

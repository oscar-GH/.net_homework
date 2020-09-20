using System;

namespace m_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }

    abstract class BaseForm
    {
        public int n;
        public double propotion;

       
        abstract public bool IsLegalForm();
        abstract public void Propotion();
        //abstract public void SetSide();
        abstract public double ReturnPropotion();

    }

    class Triangle:BaseForm
    {
         new public int n = 3;
         public int side1,side2,side3;

        
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

            propotion = System.Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)); return propotion;
            //throw new NotImplementedException();
        }
    }


    class Rectangle:BaseForm
    {
        new public int n = 4;
        public int length, height;
        public Rectangle(int n1,int n2) 
        {
            height = n1;
            length = n2;
        }
        public override bool IsLegalForm()
        {
            //throw new NotImplementedException();
            if (height > 0 && length > 0) { return true; }
            else{ return false;}
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

    class Square:Rectangle
    {
        public Square(int n1,int n2):base(n1,n2)
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
}

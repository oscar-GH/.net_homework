using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace m_4_2
{
   public class OrderDetails
    {
        //private int pid;//Product Id
        public int PID
        {
            get;
            set;
        }
       // private string Pname;//Product name
        public string PName
        {
            get;
            set;
        }

        //客户

        //private string customer;
        //public string Customer
        //{
        //    get { return customer; }
        //    set { customer = value; }
        //}

       // private int price;//单价
        public int Price
        {
            get;
            set;
        }
        //private int quantity;//数量
        public int Quantity
        {
            get;
            set;
        }
        public int Total_Price_Detail
        {
            get { return Price * Quantity; }
        }//该类商品总价
        public override bool Equals(object obj)
        {
            //return base.Equals(obj);
            if (obj == null) { return false; }
            if ((obj.GetType().Equals(this.GetType())) == false) { return false; }
            OrderDetails temp = null;
            temp = (OrderDetails)obj;
            return this.PID.Equals(temp.PID) && this.PName.Equals(temp.PName) && this.Price.Equals(temp.Price) && this.Quantity.Equals(temp.Quantity);

        }
        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return this.PID.GetHashCode() + this.PName.GetHashCode() + this.Price.GetHashCode() + this.Quantity.GetHashCode();
        }
        public OrderDetails(int id_p, string name_p, int price_p, int quantity_p)
        {
            PID = id_p;
            PName = name_p;
            Price = price_p;
            Quantity = quantity_p;
        }
        public override string ToString()
        {
            //return base.ToString();
            return "商品ID:" + PID + " - 商品名:" + PName + " - 单价:" + Price + " - 数量:" + Quantity + " - 总价:" + Total_Price_Detail;
        }
    }
}

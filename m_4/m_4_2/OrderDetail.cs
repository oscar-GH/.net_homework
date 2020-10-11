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
        private int pid;//Product Id
        public int PID
        {
            get
            {
                return pid;
            }
            set
            {
                pid = value;
            }
        }
        private string Pname;//Product name
        public string PName
        {
            get { return Pname; }
            set { Pname = value; }
        }

        //客户

        //private string customer;
        //public string Customer
        //{
        //    get { return customer; }
        //    set { customer = value; }
        //}

        private int price;//单价
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private int quantity;//数量
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int Total_Price_Detail
        {
            get { return price * quantity; }
        }//该类商品总价
        public override bool Equals(object obj)
        {
            //return base.Equals(obj);
            if (obj == null) { return false; }
            if ((obj.GetType().Equals(this.GetType())) == false) { return false; }
            OrderDetails temp = null;
            temp = (OrderDetails)obj;
            return this.pid.Equals(temp.pid) && this.Pname.Equals(temp.Pname) && this.price.Equals(temp.price) && this.quantity.Equals(temp.quantity);

        }
        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return this.pid.GetHashCode() + this.Pname.GetHashCode() + this.price.GetHashCode() + this.quantity.GetHashCode();
        }
        public OrderDetails(int id_p, string name_p, int price_p, int quantity_p)
        {
            pid = id_p;
            Pname = name_p;
            price = price_p;
            quantity = quantity_p;
        }
        public override string ToString()
        {
            //return base.ToString();
            return "商品ID:" + pid + " - 商品名:" + Pname + " - 单价:" + price + " - 数量:" + quantity + " - 总价:" + Total_Price_Detail;
        }
    }
}

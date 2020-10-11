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
    [Serializable]
    public class Order
    {
        //private int order_id;
        public int Order_ID
        {
            get;
            set;
        }
        //private string customer;
        public string Customer
        {
            get;
            set;
        }
        //private int total_price;
        public int Total_Price
        {
            get;
            set;
        }
       // private List<OrderDetails> detailList;
        public List<OrderDetails> detailList
        {
            get;
            set;
        }
        //{
        //    get
        //    {
        //        return this.detaillist;
        //    }
        //    set
        //    {
        //        this.detaillist = value;
        //    }
        //}
        public override bool Equals(object obj)
        {
            //return base.Equals(obj);
            // Order m = obj as Order;
            // return m!=null && 
            if (obj == null) { return false; }
            if ((obj.GetType().Equals(this.GetType())) == false) { return false; }
            Order temp = null;
            temp = (Order)obj;
            return this.Order_ID.Equals(temp.Order_ID) && this.Customer.Equals(temp.Customer) && this.Total_Price.Equals(temp.Total_Price);
        }
        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return this.Order_ID.GetHashCode() + this.Customer.GetHashCode() + this.Total_Price.GetHashCode();
        }
        public Order(int id_o, string customer_o, int price_o, List<OrderDetails> DList)
        {
            Order_ID = id_o;
            Customer = customer_o;
            Total_Price = price_o;
            detailList = DList;
        }
        public override string ToString()
        {
            //return base.ToString();
            return "订单号:" + Order_ID + " - 客户:" + Customer + " - 总金额:" + Total_Price;
        }





    }
}

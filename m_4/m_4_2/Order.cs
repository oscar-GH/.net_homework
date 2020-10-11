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
        private int order_id;
        public int Order_ID
        {
            get
            {
                return order_id;
            }
            set
            {
                order_id = value;
            }
        }
        private string customer;
        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        private int total_price;
        public int Total_Price
        {
            get { return total_price; }
            set { total_price = value; }
        }
        private List<OrderDetails> detailList;
        public List<OrderDetails> DetailList
        {
            get
            {
                return this.detailList;
            }
            set
            {
                this.detailList = value;
            }
        }
        public override bool Equals(object obj)
        {
            //return base.Equals(obj);
            // Order m = obj as Order;
            // return m!=null && 
            if (obj == null) { return false; }
            if ((obj.GetType().Equals(this.GetType())) == false) { return false; }
            Order temp = null;
            temp = (Order)obj;
            return this.order_id.Equals(temp.order_id) && this.customer.Equals(temp.customer) && this.total_price.Equals(temp.total_price);
        }
        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return this.order_id.GetHashCode() + this.customer.GetHashCode() + this.total_price.GetHashCode();
        }
        public Order(int id_o, string customer_o, int price_o, List<OrderDetails> DList)
        {
            order_id = id_o;
            customer = customer_o;
            total_price = price_o;
            detailList = DList;
        }
        public override string ToString()
        {
            //return base.ToString();
            return "订单号:" + order_id + " - 客户:" + customer + " - 总金额:" + total_price;
        }





    }
}

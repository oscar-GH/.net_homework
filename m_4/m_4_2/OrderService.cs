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
    public class OrderService
    {
        private List<Order> orderList;
        public List<Order> OrderList
        {
            get { return orderList; }
            set { orderList = value; }
        }

        public OrderService(List<Order> OL)
        {
            orderList = OL;
        }

        public void AddToOrder(Order order, OrderDetails orderDetails)
        {
            bool isOrderExist = false;
            foreach (Order O in OrderList)
            {
                if (O.Equals(order)) { isOrderExist = true; }
            }

            if (isOrderExist)
            {
                bool first_time = true;
                foreach (OrderDetails OD in order.DetailList)
                {
                    if (OD.Equals(orderDetails)) { first_time = false; }
                }
                if (first_time)
                {
                    order.DetailList.Add(orderDetails);
                    Console.WriteLine("添加成功");
                }
                else { Console.WriteLine("此订单已有该商品"); }
            }
            else { Console.WriteLine("不存在此订单"); }

        }

        public void DeleteFromOrder(Order order, OrderDetails orderDetails)
        {
            bool isOrderExist = false;
            foreach (Order O in OrderList)
            {
                if (O.Equals(order)) { isOrderExist = true; }
            }

            if (isOrderExist)
            {
                bool belongsTo = false;
                foreach (OrderDetails OD in order.DetailList)
                {
                    if (OD.Equals(orderDetails)) { belongsTo = true; }
                }
                if (belongsTo)
                {
                    order.DetailList.Remove(orderDetails);
                    Console.WriteLine("成功删除");
                }
                else { Console.WriteLine("删除失败：该商品不属于此订单"); }
            }
            else { Console.WriteLine("不存在此订单"); }
        }

        public void ModifyDetail(Order order, string customer = "-1", string Pname = "-1", int Pid = -1, int quantity = -1)//客户名，商品对应的数量
        {
            bool isOrderExist = false;
            foreach (Order O in OrderList)
            {
                if (O.Equals(order)) { isOrderExist = true; }
            }

            if (isOrderExist)
            {
                if (customer != "-1")
                {
                    order.Customer = customer;
                    Console.WriteLine("成功修改客户信息");

                }


                if (Pname != "-1" && Pid != -1 && quantity != -1)
                {
                    bool isDone = false;
                    foreach (OrderDetails OD in order.DetailList)
                    {
                        if (OD.PName == Pname && OD.PID == Pid)
                        {
                            OD.Quantity = quantity;
                            isDone = true;

                        }
                    }
                    if (isDone) { Console.WriteLine("成功修改商品数量"); }
                    else { Console.WriteLine("订单中没有此商品"); }

                }


            }
            else { Console.WriteLine("不存在此订单"); }

        }


        public List<Order> QueryOrder_Equal(int O_id = -1, string O_customer = "-1", int O_price = -1)
        {
            var op_id = from n in OrderList
                        where n.Order_ID == O_id
                        orderby n.Total_Price
                        select n;

            var op_customer = from n in OrderList
                              where n.Customer == O_customer
                              orderby n.Total_Price
                              select n;
            var op_price = from n in OrderList
                           where n.Total_Price == O_price
                           orderby n.Total_Price
                           select n;

            var op_id_customer = from n in OrderList
                                 where n.Customer == O_customer && n.Order_ID == O_id
                                 orderby n.Total_Price
                                 select n;

            var op_id_price = from n in OrderList
                              where n.Order_ID == O_id && n.Total_Price == O_price
                              orderby n.Total_Price
                              select n;

            var op_price_customer = from n in OrderList
                                    where n.Customer == O_customer && n.Total_Price == O_price
                                    orderby n.Total_Price
                                    select n;

            var op_id_price_customer = from n in OrderList
                                       where n.Customer == O_customer && n.Order_ID == O_id && n.Total_Price == O_price
                                       orderby n.Total_Price
                                       select n;



            if ((O_id != -1) && (O_customer == "-1") && (O_price == -1))
            {
                List<Order> list = op_id.ToList();
                return list;
            }
            else if ((O_id == -1) && (O_customer != "-1") && (O_price == -1))
            {
                List<Order> list = op_customer.ToList();
                return list;
            }
            else if ((O_id == -1) && (O_customer == "-1") && (O_price != -1))
            {
                List<Order> list = op_id_price.ToList();
                return list;
            }
            else if ((O_id != -1) && (O_customer != "-1") && (O_price == -1))
            {
                List<Order> list = op_id_customer.ToList();
                return list;
            }
            else if ((O_id != -1) && (O_customer == "-1") && (O_price != -1))
            {
                List<Order> list = op_id_price.ToList();
                return list;
            }
            else if ((O_id == -1) && (O_customer != "-1") && (O_price != -1))
            {
                List<Order> list = op_price_customer.ToList();
                return list;
            }
            else if ((O_id != -1) && (O_customer != "-1") && (O_price != -1))
            {
                List<Order> list = op_id_price_customer.ToList();
                return list;
            }
            else { return null; }




        }

        public void Sort_OrderId()
        {
            var op = from n in OrderList
                     orderby n.Order_ID
                     select n;
            foreach (var x in op)
            {
                Console.WriteLine(x);
            }
        }

        public void Print()
        {
            foreach (var x in this.OrderList)
            {
                foreach (var y in x.DetailList)
                {
                    Console.WriteLine(y.ToString());
                }
            }
        }

        public void Export()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("s.temp", FileMode.Create)) { binaryFormatter.Serialize(fs, OrderList); }
        }

        public void Import()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("s.temp", FileMode.Open)) { List<Order> oList2 = (List<Order>)binaryFormatter.Deserialize(fs); }
        }

    }
}

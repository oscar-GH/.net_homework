using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
//using System.Text;

namespace m_3_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // OrderDetails od1(1,p1,11,2);
            OrderDetails p1 = new OrderDetails(1, "p1", 10, 2);
            OrderDetails p2 = new OrderDetails(2, "p2", 20, 1);

            List<OrderDetails> Dlist1 = new List<OrderDetails>();
            Dlist1.Add(p1);
            Dlist1.Add(p2);
            
            Order order1 = new Order(1, "c1", 0, Dlist1);
            
            List<Order> Olist1 = new List<Order>();
            Olist1.Add(order1);
            
            OrderService OS1 = new OrderService(Olist1);

            string s1=OS1.OrderList[0].ToString();
            Console.WriteLine(s1);
            Console.WriteLine(OS1.OrderList[0].DetailList[1].ToString());
            
            OS1.Sort_OrderId();

            OrderDetails p3 = new OrderDetails(3, "p3", 30, 3);
            OS1.AddToOrder(order1, p3);
            OS1.AddToOrder(order1, p3);
            
            OS1.Print();

            OS1.DeleteFromOrder(order1, p3);
            OS1.Print();

            OS1.ModifyDetail(order1, "co1", "-1", -1, -1);
            Console.WriteLine(OS1.OrderList[0].ToString());


            Console.WriteLine(OS1.QueryOrder_Equal(1, "-1", -1)[0].ToString());

            OS1.Sort_OrderId();

            Console.WriteLine("1");


        }

       [Serializable]
        class Order
        {
            private int order_id;
            public int Order_ID{
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
            public Order(int id_o,string customer_o,int price_o,List<OrderDetails> DList)
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

        class OrderDetails//=product
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
            public OrderDetails(int id_p,string name_p,int price_p,int quantity_p)
            {
                pid = id_p;
                Pname = name_p;
                price = price_p;
                quantity = quantity_p;
            }
            public override string ToString()
            {
                //return base.ToString();
                return "商品ID:"+pid + " - 商品名:" + Pname + " - 单价:" + price + " - 数量:" + quantity + " - 总价:" + Total_Price_Detail;
            }


        }

        class OrderService
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
            
            public void AddToOrder(Order order,OrderDetails orderDetails)
            {
                bool isOrderExist = false;
                foreach(Order O in OrderList)
                {
                    if (O.Equals(order)) { isOrderExist = true; }
                }

              if(isOrderExist)
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

            public void DeleteFromOrder(Order order,OrderDetails orderDetails)
            {
                bool isOrderExist = false;
                foreach(Order O in OrderList)
                {
                    if (O.Equals(order)) { isOrderExist = true; }
                }

                if(isOrderExist)
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

            public void ModifyDetail(Order order,string customer="-1",string Pname="-1",int Pid=-1,int quantity=-1)//客户名，商品对应的数量
            {
                bool isOrderExist = false;
                foreach(Order O in OrderList)
                {
                    if (O.Equals(order)) { isOrderExist = true; }
                }

                if(isOrderExist)
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


            public List<Order> QueryOrder_Equal(int O_id=-1,string O_customer="-1",int O_price=-1)
            {
                var op_id = from n in OrderList
                            where n.Order_ID == O_id
                            orderby n.Total_Price
                            select n;

                var op_customer = from n in OrderList
                         where n.Customer==O_customer
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

                

                if((O_id!=-1)&&(O_customer=="-1")&&(O_price==-1))
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
                foreach(var x in op)
                {
                    Console.WriteLine(x);
                }
            }

            public void Print()
            {
                foreach(var x in this.OrderList)
                {
                    foreach(var y in x.DetailList)
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
}

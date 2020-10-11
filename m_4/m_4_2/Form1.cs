using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace m_4_2
{
    public partial class Form4_2 : Form
    {
        OrderService OrderService;
        
        public Form4_2()
        {
            InitializeComponent();
           
            
            OrderDetails p1 = new OrderDetails(1, "p1", 10, 2);
            OrderDetails p2 = new OrderDetails(2, "p2", 20, 1);

            List<OrderDetails> Dlist1 = new List<OrderDetails>();
            Dlist1.Add(p1);
            Dlist1.Add(p2);

            Order order1 = new Order(1, "c1", 0, Dlist1);

            List<Order> Olist1 = new List<Order>();
            Olist1.Add(order1);

             OrderService = new OrderService(Olist1);
        }

         
     
        
        private void Form4_2_TextChanged(object sender, EventArgs e)
        {
            textBox_total_price.ForeColor = Color.Black;
            textBox_customer.ForeColor = Color.Black;
            textBox_Order_id.ForeColor = Color.Black;
        }

        private void button_Query_order_Click(object sender, EventArgs e)
        {
            int id;
            string customer;
            int price;
            if (textBox_Order_id.Text == "") { id = -1; }
            else { id = Convert.ToInt32(textBox_Order_id.Text); }
            if (textBox_customer.Text == "") { customer = "-1"; }
            else { customer = textBox_customer.Text; }
            if (textBox_total_price.Text == "") { price = -1; }
            else { price = Convert.ToInt32(textBox_total_price.Text); }
            
            bindingSource1.DataSource = OrderService.QueryOrder_Equal(id,customer,price);
            bindingSource1.ResetBindings(false);
        }

        private void Form4_2_Load(object sender, EventArgs e)
        {
            //ORDER_ID = -1;
            //ORDER_CUSTOMER = "-1";
            // ORDER_PRICE = -1;

            //list<orderdetails> pro_list = new list<orderdetails>();
            //order order_ex = new order(-1, "-1", -1, pro_list);
            //order_ex.order_id = -1;
            //order_ex.customer = "-1";
            //order_ex.total_price = -1;
            //textbox_order_id.databindings.add("text", order_ex, "order_id");
            //textbox_customer.databindings.add("text", order_ex, "customer");
            //textbox_total_price.databindings.add("text", order_ex, "total_price");

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }


    

   

   

}

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
        public Form4_2()
        {
            InitializeComponent();
        }

        public int ORDER_ID;
        public string ORDER_CUSTOMER;
        public int ORDER_PRICE;
        public List<OrderDetails> PRODUCTL_LIST = new List<OrderDetails>();
        
        private void Form4_2_TextChanged(object sender, EventArgs e)
        {
            textBox_total_price.ForeColor = Color.Black;
            textBox_customer.ForeColor = Color.Black;
            textBox_Order_id.ForeColor = Color.Black;
        }

        private void button_Query_order_Click(object sender, EventArgs e)
        {

        }

        private void Form4_2_Load(object sender, EventArgs e)
        {
            ORDER_ID = -1;
            ORDER_CUSTOMER = "-1";
            ORDER_PRICE = -1;
            textBox_Order_id.DataBindings.Add("Text", this, "ORDER_ID");
            textBox_customer.DataBindings.Add("Text", this, "ORDER_CUSTOMER");
            textBox_total_price.DataBindings.Add("Text", this, "ORDER_PRICE");
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }


    

   

   

}

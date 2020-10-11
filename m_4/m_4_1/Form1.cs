using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace m_4_1
{
    public partial class Form4_1 : Form
    {
        public Form4_1()
        {
            InitializeComponent();
        }

        private void button_op_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            int N = Convert.ToInt32(textBox_n.Text);
            double LENG = Convert.ToDouble(textBox_leng.Text);
            double TH1 = Convert.ToDouble(textBox_th1.Text)*Math.PI/180;
            double TH2 = Convert.ToDouble(textBox_th2.Text)*Math.PI/180;
            double PER1 = Convert.ToDouble(textBox_per1.Text);
            double PER2 = Convert.ToDouble(textBox_per2.Text);

            drawCayleyTree(N, 200, 310, LENG, -Math.PI / 2,TH1,TH2,PER1,PER2);
        }
        private Graphics graphics;

        //double th1 = 30 * Math.PI / 180;
       // double th2 = 20 * Math.PI / 180;
       // double per1 = 0.6;
       // double per2 = 0.7;
        

        void drawCayleyTree(int n,double x0,double y0,double leng,double th,double th1,double th2,double per1,double per2)
        {
            
            if (n == 0) return;
            
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            //drawLine(x0, y0, x1, y1);
            switch(comboBox_penColor.Text)
            {
                case "Red":
                    graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "Yellow":
                    graphics.DrawLine(Pens.Yellow, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "Blue":
                    graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "Green":
                    graphics.DrawLine(Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                default:
                    graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;

            }

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1,th1,th2,per1,per2);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2,th1,th2,per1,per2);

        }

        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
        }

    }
}

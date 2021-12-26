using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Random rd = new Random();
        private void T1_Tick(object sender, EventArgs e)
        {
            int solY1 = Y1.Left;
            int r = rd.Next(solY1, solY1 + 60);
            Y1.Left = r;
            if(Y1.Left+70>=600)
            {
                T1.Enabled = false;
                T1.Stop();
                sonuclar.Items.Add("yarışmacı 1");
            }
           


        }    

        
        private void T2_Tick(object sender, EventArgs e)
        {
            int solY2 = Y2.Left;
            int r = rd.Next(solY2, solY2 + 60);
            Y2.Left = r;
            if(solY2+70>=600)
            {
                T2.Enabled = false;
                T2.Stop();
                sonuclar.Items.Add("yarışmacı 2");
            }
             




        }
       
        private void T3_Tick(object sender, EventArgs e)
        {
            int solY3 = Y3.Left;
            int r = rd.Next(solY3, solY3 + 60);
            Y3.Left = r;
            if (solY3 + 70 >= 600)
            {
                T3.Enabled = false;
                T3.Stop();
                sonuclar.Items.Add("yarışmacı 3");
            }
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            T1.Enabled = true;
            T1.Start();
            T2.Enabled = true;
            T2.Start();
            T3.Enabled = true;
            T3.Start();
        }
    }
}

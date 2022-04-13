using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Form1 : Form
    {


        Form2 form2 = new Form2();
        Database db = new Database();

        
        public Form1()
        {
            InitializeComponent();
            //tabPage2.Parent = null;
            //if (db.a == 1)
            //{
            //    tabPage2.Parent = tabControl1;
            //}
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Enabled = true;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }
    }
}

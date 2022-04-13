using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {

        Database db = new Database();
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AJR95T9\SQLEXPRESS; Initial Catalog=Hospital;Integrated Security=true ");
        //Form1 form1 = new Form1();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = textBox1.Text;
            String passUser = textBox2.Text;

            DataTable table = new DataTable();
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            
            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE Логин = @uL AND Пароль = @uP", db.getconnection());
            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count>0)
            {
                DialogResult result = MessageBox.Show("Вход выполнен успешно! Вам открыт доступ к системе.");
                if (result == DialogResult.OK)
                {
                    Close();
                    
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль! Повторите вход, иначе доступ к системе будет закрыт.");
            }


        }
    }
}

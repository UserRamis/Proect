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
    public partial class FormAuthorization : Form
    {
        MainForm form1 = new MainForm();
        Database db = new Database();
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AJR95T9\SQLEXPRESS; Initial Catalog=Hospital;Integrated Security=true ");
        

        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = textBox1Login.Text;
            String passUser = textBox2Password.Text;
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
                    form1.Show();
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль! Повторите вход, иначе доступ к системе будет закрыт.");
                textBox1Login.Clear();
                textBox2Password.Clear();




            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

       
    }
}

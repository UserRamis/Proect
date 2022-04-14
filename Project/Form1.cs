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
using System.Data.OleDb;

namespace Project
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlCommandBuilder sqlBuilder = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;

        private bool newRowAdding = false;



        
        public Form1()
        {
    
            InitializeComponent();

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
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AJR95T9\SQLEXPRESS; Initial Catalog=Hospital;Integrated Security=true ");

            sqlConnection.Open();

            LoadData();


        }

        
    
    
    private void LoadData()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [Delete] FROM Employee", sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "Employee");

                dataGridView1.DataSource = dataSet.Tables["Employee"];

                for(int i=0; i<dataGridView1.Rows.Count;i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[10, i] = linkCell;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ReloadData()
        {
            try
            {
                dataSet.Tables["Employee"].Clear();

                sqlDataAdapter.Fill(dataSet, "Employee");

                dataGridView1.DataSource = dataSet.Tables["Employee"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[10, i] = linkCell;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex==10)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

                    if(task=="Delete")
                    {
                        if(MessageBox.Show("Удалить эту строку?","Удаление",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;

                            dataGridView1.Rows.RemoveAt(rowIndex);

                            dataSet.Tables["Employee"].Rows[rowIndex].Delete();

                            sqlDataAdapter.Update(dataSet, "Employee");


                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView1.Rows.Count - 2;

                        DataRow row = dataSet.Tables["Employee"].NewRow();

                        row["Код сотрудника"] = dataGridView1.Rows[rowIndex].Cells["Код сотрудника"].Value;
                        row["ФИО сотрудника"] = dataGridView1.Rows[rowIndex].Cells["ФИО сотрудника"].Value;
                        row["Должность сотрудника"] = dataGridView1.Rows[rowIndex].Cells["Должность сотрудника"].Value;
                        row["Пол"] = dataGridView1.Rows[rowIndex].Cells["Пол"].Value;
                        row["Место жительства"] = dataGridView1.Rows[rowIndex].Cells["Место жительства"].Value;
                        row["Паспортные данные"] = dataGridView1.Rows[rowIndex].Cells["Паспортные данные"].Value;
                        row["Образование"] = dataGridView1.Rows[rowIndex].Cells["Образование"].Value;
                        row["Опыт работы(лет)"] = dataGridView1.Rows[rowIndex].Cells["Опыт работы(лет)"].Value;
                        row["Электронная почта"] = dataGridView1.Rows[rowIndex].Cells["Электронная почта"].Value;
                        row["Номер телефона"] = dataGridView1.Rows[rowIndex].Cells["Номер телефона"].Value;


                        dataSet.Tables["Employee"].Rows.Add(row);

                        dataSet.Tables["Employee"].Rows.RemoveAt(dataSet.Tables["Employee"].Rows.Count - 1);

                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                        dataGridView1.Rows[e.RowIndex].Cells[10].Value = "Delete";

                        sqlDataAdapter.Update(dataSet, "Employee");

                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {

                    }

                    ReloadData();



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if(newRowAdding==false)
                {
                    newRowAdding = true;

                    int lastRow = dataGridView1.Rows.Count - 2;

                    DataGridViewRow row = dataGridView1.Rows[lastRow];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[10, lastRow] = linkCell;

                    row.Cells["Delete"].Value = "Insert";


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}

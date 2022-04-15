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
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AJR95T9\SQLEXPRESS; Initial Catalog=Hospital;Integrated Security=true ");

            sqlConnection.Open();

            LoadData1();


        }

        
    
    
    private void LoadData1()
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



        private void ReloadData1()
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
            ReloadData1();
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

                    ReloadData1();



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
            //ДРУГОЙЙЙЙЙЙЙЙЙЙЙЙЙЙЙЙЙЙЙЙЙЙЙЙ
        private void button2_Click_1(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AJR95T9\SQLEXPRESS; Initial Catalog=Hospital;Integrated Security=true ");

            sqlConnection.Open();

            LoadData2();
        }

        private void LoadData2()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [Delete] FROM Patients", sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "Patients");

                dataGridView2.DataSource = dataSet.Tables["Patients"];

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView2[12, i] = linkCell;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 12)
                {
                    string task = dataGridView2.Rows[e.RowIndex].Cells[12].Value.ToString();

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;

                            dataGridView2.Rows.RemoveAt(rowIndex);

                            dataSet.Tables["Patients"].Rows[rowIndex].Delete();

                            sqlDataAdapter.Update(dataSet, "Patients");


                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView2.Rows.Count - 2;

                        DataRow row1 = dataSet.Tables["Patients"].NewRow();

                        row1["ID пациента"] = dataGridView2.Rows[rowIndex].Cells["ID пациента"].Value;
                        row1["ФИО"] = dataGridView2.Rows[rowIndex].Cells["ФИО"].Value;
                        row1["Возраст"] = dataGridView2.Rows[rowIndex].Cells["Возраст"].Value;
                        row1["Группа крови"] = dataGridView2.Rows[rowIndex].Cells["Группа крови"].Value;
                        row1["Адрес"] = dataGridView2.Rows[rowIndex].Cells["Адрес"].Value;
                        row1["Паспортные данные"] = dataGridView2.Rows[rowIndex].Cells["Паспортные данные"].Value;
                        row1["Болезнь"] = dataGridView2.Rows[rowIndex].Cells["Болезнь"].Value;
                        row1["СНИЛС"] = dataGridView2.Rows[rowIndex].Cells["СНИЛС"].Value;
                        row1["Номер палаты"] = dataGridView2.Rows[rowIndex].Cells["Номер палаты"].Value;
                        row1["Лечащий врач"] = dataGridView2.Rows[rowIndex].Cells["Лечащий врач"].Value;
                        row1["№ Участка"] = dataGridView2.Rows[rowIndex].Cells["№ Участка"].Value;
                        row1["Дата поступления в стационар"] = dataGridView2.Rows[rowIndex].Cells["Дата поступления в стационар"].Value;


                        dataSet.Tables["Patients"].Rows.Add(row1);

                        dataSet.Tables["Patients"].Rows.RemoveAt(dataSet.Tables["Patients"].Rows.Count - 1);

                        dataGridView2.Rows.RemoveAt(dataGridView2.Rows.Count - 2);

                        dataGridView2.Rows[e.RowIndex].Cells[12].Value = "Delete";

                        sqlDataAdapter.Update(dataSet, "Patients");

                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {

                    }

                    ReloadData2();



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ReloadData2();
        }

        private void ReloadData2()
        {
            try
            {
                dataSet.Tables["Patients"].Clear();

                sqlDataAdapter.Fill(dataSet, "Patients");

                dataGridView2.DataSource = dataSet.Tables["Patients"];

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView2[12, i] = linkCell;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;

                    int lastRow = dataGridView2.Rows.Count - 2;

                    DataGridViewRow row = dataGridView2.Rows[lastRow];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView2[12, lastRow] = linkCell;

                    row.Cells["Delete"].Value = "Insert";


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReloadData2();
        }
    }
}

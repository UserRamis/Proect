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
using System.IO;
using System.Drawing.Printing;

namespace Project
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlCommandBuilder sqlBuilder = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;

        private bool newRowAdding = false;

        private string result = "";


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
            //datagridview2
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

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage6);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (StreamWriter w = File.AppendText(@"Жалобная книга.txt"))
            {
                w.WriteLine("ФИО: "+textBox1.Text + "\n"+ "Жалоба: "+ textBox2.Text);
            }

            SqlConnection sqlConnection123 = new SqlConnection(@"Data Source=DESKTOP-AJR95T9\SQLEXPRESS; Initial Catalog=Hospital;Integrated Security=true ");
            sqlConnection123.Open();
            SqlCommand command123 = new SqlCommand($"INSERT INTO [Complaint book] (ФИО, Жалоба) VALUES (@ФИО, @Жалоба)", sqlConnection123);

            command123.Parameters.AddWithValue("ФИО", textBox1.Text);
            command123.Parameters.AddWithValue("Жалоба", textBox2.Text);
           
            MessageBox.Show("Успешно! Данные сохранены в базе данных и в файле", command123.ExecuteNonQuery().ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            result = textBox1.Text;
            result += textBox2.Text;
            // объект для печати
            PrintDocument printDocument = new PrintDocument();
            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;
            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();
            // установка объекта печати для его настройки
            printDialog.Document = printDocument;
            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }
    
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection12 = new SqlConnection(@"Data Source=DESKTOP-AJR95T9\SQLEXPRESS; Initial Catalog=Hospital;Integrated Security=true ");
            sqlConnection12.Open();
            SqlCommand command12 = new SqlCommand($"INSERT INTO [Record] (ФИО, Возраст, СНИЛС, Адрес, Симптомы) VALUES (@ФИО, @Возраст, @СНИЛС, @Адрес, @Симптомы)",sqlConnection12);
           
            command12.Parameters.AddWithValue("ФИО", textBox3.Text);
            command12.Parameters.AddWithValue("Возраст", textBox4.Text);
            command12.Parameters.AddWithValue("СНИЛС", textBox5.Text);
            command12.Parameters.AddWithValue("Адрес", textBox6.Text);
            command12.Parameters.AddWithValue("Симптомы", textBox7.Text);

            MessageBox.Show("Успешно! Данные сохранены в базе данных и в файле",command12.ExecuteNonQuery().ToString());

            using (StreamWriter w1 = File.AppendText(@"Записи на прием.txt"))
            {
                w1.WriteLine("ФИО: " + textBox3.Text + "\n" + "Возраст: " + textBox4.Text+"\nСНИЛС: "+ textBox5.Text + "\nАдрес: " + textBox6.Text + "\nСимптомы: " + textBox7.Text);
            }

            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();


        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            result = textBox3.Text;
            result += textBox4.Text;
            result += textBox5.Text;
            result += textBox6.Text;
            result += textBox7.Text;

            PrintDocument printDocument = new PrintDocument();
            
            printDocument.PrintPage += PrintPageHandler;
            
            PrintDialog printDialog = new PrintDialog();
            
            printDialog.Document = printDocument;
            
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); 
        }

        private void buttoncomplaintbook_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage6);
        }
    }
}

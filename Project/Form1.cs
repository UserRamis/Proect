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
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;

namespace Project
{
    public partial class MainForm : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlCommandBuilder sqlBuilder = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;

        private bool newRowAdding = false;

        private string result = "";

        PrintDocument printDocument = new PrintDocument();

        PrintDialog printDialog = new PrintDialog();


        public MainForm()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1Date.Interval = 10;
            timer1Date.Enabled = true;
            timer1Date.Start();






        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3Date.Text = DateTime.Now.ToLongDateString();
            label4Time.Text = DateTime.Now.ToLongTimeString();
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

                dataGridViewEmployee.DataSource = dataSet.Tables["Employee"];

                for (int i = 0; i < dataGridViewEmployee.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridViewEmployee[10, i] = linkCell;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            foreach (DataGridViewColumn column in dataGridViewEmployee.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                checkBoxEmployee.Text = "Включить сортировку";
            }



        }



        private void ReloadData1()
        {
            try
            {
                dataSet.Tables["Employee"].Clear();

                sqlDataAdapter.Fill(dataSet, "Employee");

                dataGridViewEmployee.DataSource = dataSet.Tables["Employee"];

                for (int i = 0; i < dataGridViewEmployee.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridViewEmployee[10, i] = linkCell;
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
                if (e.ColumnIndex == 10)
                {
                    string task = dataGridViewEmployee.Rows[e.RowIndex].Cells[10].Value.ToString();

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;

                            dataGridViewEmployee.Rows.RemoveAt(rowIndex);

                            dataSet.Tables["Employee"].Rows[rowIndex].Delete();

                            sqlDataAdapter.Update(dataSet, "Employee");


                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridViewEmployee.Rows.Count - 2;

                        DataRow row = dataSet.Tables["Employee"].NewRow();

                        row["Код сотрудника"] = dataGridViewEmployee.Rows[rowIndex].Cells["Код сотрудника"].Value;
                        row["ФИО сотрудника"] = dataGridViewEmployee.Rows[rowIndex].Cells["ФИО сотрудника"].Value;
                        row["Должность сотрудника"] = dataGridViewEmployee.Rows[rowIndex].Cells["Должность сотрудника"].Value;
                        row["Пол"] = dataGridViewEmployee.Rows[rowIndex].Cells["Пол"].Value;
                        row["Место жительства"] = dataGridViewEmployee.Rows[rowIndex].Cells["Место жительства"].Value;
                        row["Паспортные данные"] = dataGridViewEmployee.Rows[rowIndex].Cells["Паспортные данные"].Value;
                        row["Образование"] = dataGridViewEmployee.Rows[rowIndex].Cells["Образование"].Value;
                        row["Опыт работы(лет)"] = dataGridViewEmployee.Rows[rowIndex].Cells["Опыт работы(лет)"].Value;
                        row["Электронная почта"] = dataGridViewEmployee.Rows[rowIndex].Cells["Электронная почта"].Value;
                        row["Номер телефона"] = dataGridViewEmployee.Rows[rowIndex].Cells["Номер телефона"].Value;


                        dataSet.Tables["Employee"].Rows.Add(row);

                        dataSet.Tables["Employee"].Rows.RemoveAt(dataSet.Tables["Employee"].Rows.Count - 1);

                        dataGridViewEmployee.Rows.RemoveAt(dataGridViewEmployee.Rows.Count - 2);

                        dataGridViewEmployee.Rows[e.RowIndex].Cells[10].Value = "Delete";

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
                if (newRowAdding == false)
                {
                    newRowAdding = true;

                    int lastRow = dataGridViewEmployee.Rows.Count - 2;

                    DataGridViewRow row = dataGridViewEmployee.Rows[lastRow];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridViewEmployee[10, lastRow] = linkCell;

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

                dataGridViewPatients.DataSource = dataSet.Tables["Patients"];

                for (int i = 0; i < dataGridViewPatients.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridViewPatients[12, i] = linkCell;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataGridViewColumn column in dataGridViewPatients.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                checkBoxPatients.Text = "Включить сортировку";
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 12)
                {
                    string task = dataGridViewPatients.Rows[e.RowIndex].Cells[12].Value.ToString();

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;

                            dataGridViewPatients.Rows.RemoveAt(rowIndex);

                            dataSet.Tables["Patients"].Rows[rowIndex].Delete();

                            sqlDataAdapter.Update(dataSet, "Patients");
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridViewPatients.Rows.Count - 2;

                        DataRow row1 = dataSet.Tables["Patients"].NewRow();

                        row1["ID пациента"] = dataGridViewPatients.Rows[rowIndex].Cells["ID пациента"].Value;
                        row1["ФИО"] = dataGridViewPatients.Rows[rowIndex].Cells["ФИО"].Value;
                        row1["Возраст"] = dataGridViewPatients.Rows[rowIndex].Cells["Возраст"].Value;
                        row1["Группа крови"] = dataGridViewPatients.Rows[rowIndex].Cells["Группа крови"].Value;
                        row1["Адрес"] = dataGridViewPatients.Rows[rowIndex].Cells["Адрес"].Value;
                        row1["Паспортные данные"] = dataGridViewPatients.Rows[rowIndex].Cells["Паспортные данные"].Value;
                        row1["Болезнь"] = dataGridViewPatients.Rows[rowIndex].Cells["Болезнь"].Value;
                        row1["СНИЛС"] = dataGridViewPatients.Rows[rowIndex].Cells["СНИЛС"].Value;
                        row1["Номер палаты"] = dataGridViewPatients.Rows[rowIndex].Cells["Номер палаты"].Value;
                        row1["Лечащий врач"] = dataGridViewPatients.Rows[rowIndex].Cells["Лечащий врач"].Value;
                        row1["№ Участка"] = dataGridViewPatients.Rows[rowIndex].Cells["№ Участка"].Value;
                        row1["Дата поступления в стационар"] = dataGridViewPatients.Rows[rowIndex].Cells["Дата поступления в стационар"].Value;


                        dataSet.Tables["Patients"].Rows.Add(row1);

                        dataSet.Tables["Patients"].Rows.RemoveAt(dataSet.Tables["Patients"].Rows.Count - 1);

                        dataGridViewPatients.Rows.RemoveAt(dataGridViewPatients.Rows.Count - 2);

                        dataGridViewPatients.Rows[e.RowIndex].Cells[12].Value = "Delete";

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

                dataGridViewPatients.DataSource = dataSet.Tables["Patients"];

                for (int i = 0; i < dataGridViewPatients.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridViewPatients[12, i] = linkCell;
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

                    int lastRow = dataGridViewPatients.Rows.Count - 2;

                    DataGridViewRow row = dataGridViewPatients.Rows[lastRow];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridViewPatients[12, lastRow] = linkCell;

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
            tabControl1.SelectTab(tabPage6complaintbook);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (StreamWriter w = File.AppendText(@"Жалобная книга.txt"))
            {
                w.WriteLine("ФИО: " + textBox1bookFIO.Text + "\n" + "Жалоба: " + textBox2writecomplaint.Text);
            }

            SqlConnection sqlConnection123 = new SqlConnection(@"Data Source=DESKTOP-AJR95T9\SQLEXPRESS; Initial Catalog=Hospital;Integrated Security=true ");
            sqlConnection123.Open();
            SqlCommand command123 = new SqlCommand($"INSERT INTO [Complaint book] (ФИО, Жалоба) VALUES (@ФИО, @Жалоба)", sqlConnection123);

            command123.Parameters.AddWithValue("ФИО", textBox1bookFIO.Text);
            command123.Parameters.AddWithValue("Жалоба", textBox2writecomplaint.Text);

            MessageBox.Show("Успешно! Данные сохранены в базе данных и в файле", command123.ExecuteNonQuery().ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            result = textBox1bookFIO.Text;
            result += textBox2writecomplaint.Text;
            // объект для печати

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;
            // диалог настройки печати

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
            SqlCommand command12 = new SqlCommand($"INSERT INTO [Record] (ФИО, Возраст, СНИЛС, Адрес, Симптомы) VALUES (@ФИО, @Возраст, @СНИЛС, @Адрес, @Симптомы)", sqlConnection12);

            command12.Parameters.AddWithValue("ФИО", textBox3FIO.Text);
            command12.Parameters.AddWithValue("Возраст", textBox4age.Text);
            command12.Parameters.AddWithValue("СНИЛС", textBox5snils.Text);
            command12.Parameters.AddWithValue("Адрес", textBox6addres.Text);
            command12.Parameters.AddWithValue("Симптомы", textBox7symptoms.Text);

            MessageBox.Show("Успешно! Данные сохранены в базе данных и в файле", command12.ExecuteNonQuery().ToString());

            using (StreamWriter w1 = File.AppendText(@"Записи на прием.txt"))
            {
                w1.WriteLine("ФИО: " + textBox3FIO.Text + "\n" + "Возраст: " + textBox4age.Text + "\nСНИЛС: " + textBox5snils.Text + "\nАдрес: " + textBox6addres.Text + "\nСимптомы: " + textBox7symptoms.Text);
            }

            textBox3FIO.Clear();
            textBox4age.Clear();
            textBox5snils.Clear();
            textBox6addres.Clear();
            textBox7symptoms.Clear();


        }

        private void button9_Click(object sender, EventArgs e)
        {

            result = textBox3FIO.Text;
            result += textBox4age.Text;
            result += textBox5snils.Text;
            result += textBox6addres.Text;
            result += textBox7symptoms.Text;



            printDocument.PrintPage += PrintPageHandler;



            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }

        private void buttoncomplaintbook_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage6complaintbook);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check1 = (CheckBox)sender;
            if (check1.Checked == true)
            {
                foreach (DataGridViewColumn column in dataGridViewEmployee.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                    checkBoxEmployee.Text = "Выключить сортировку";
                }
            }
            if (check1.Checked == false)
            {
                foreach (DataGridViewColumn column in dataGridViewEmployee.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                LoadData1();

            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check2 = (CheckBox)sender;
            if (check2.Checked == true)
            {
                foreach (DataGridViewColumn column in dataGridViewPatients.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                    checkBoxPatients.Text = "Выключить сортировку";
                }
            }
            if (check2.Checked == false)
            {
                foreach (DataGridViewColumn column in dataGridViewPatients.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                LoadData2();

            }
        }

        private void pictureBoxOtkaz_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void pictureBoxFizra_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void pictureBoxMED_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void pictureBoxMRT_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void pictureBoxOtkaz2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }
    }

    
}




//@"C:\Users\user9\Desktop\inform.DOCX";
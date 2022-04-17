
namespace Project
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1Main = new System.Windows.Forms.TabPage();
            this.label6Time = new System.Windows.Forms.Label();
            this.label5Date = new System.Windows.Forms.Label();
            this.label4Time = new System.Windows.Forms.Label();
            this.label3Date = new System.Windows.Forms.Label();
            this.label2Telephone = new System.Windows.Forms.Label();
            this.label1Hospital = new System.Windows.Forms.Label();
            this.buttoncomplaintbook = new System.Windows.Forms.Button();
            this.pictureBoxHosp = new System.Windows.Forms.PictureBox();
            this.pictureBox1Hospital = new System.Windows.Forms.PictureBox();
            this.tabPage2Employee = new System.Windows.Forms.TabPage();
            this.button6updateEmployee = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.tabPage3WorkLoad = new System.Windows.Forms.TabPage();
            this.pictureBox4Timetable = new System.Windows.Forms.PictureBox();
            this.pictureBox3Diagrams = new System.Windows.Forms.PictureBox();
            this.label7announcement = new System.Windows.Forms.Label();
            this.tabPage4Patients = new System.Windows.Forms.TabPage();
            this.button3unloadpatients = new System.Windows.Forms.Button();
            this.buttonunload1 = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.tabPage5Record = new System.Windows.Forms.TabPage();
            this.label15announcementreception = new System.Windows.Forms.Label();
            this.button9Printreception = new System.Windows.Forms.Button();
            this.button8savereception = new System.Windows.Forms.Button();
            this.textBox7symptoms = new System.Windows.Forms.TextBox();
            this.textBox6addres = new System.Windows.Forms.TextBox();
            this.textBox5snils = new System.Windows.Forms.TextBox();
            this.textBox4age = new System.Windows.Forms.TextBox();
            this.textBox3FIO = new System.Windows.Forms.TextBox();
            this.label14symptoms = new System.Windows.Forms.Label();
            this.label13addres = new System.Windows.Forms.Label();
            this.label12SNILS = new System.Windows.Forms.Label();
            this.label11Age = new System.Windows.Forms.Label();
            this.label10FIO = new System.Windows.Forms.Label();
            this.tabPage6complaintbook = new System.Windows.Forms.TabPage();
            this.button7printwritecomplaint = new System.Windows.Forms.Button();
            this.button4savewritecomplaint = new System.Windows.Forms.Button();
            this.label9writecomplaint = new System.Windows.Forms.Label();
            this.textBox2writecomplaint = new System.Windows.Forms.TextBox();
            this.textBox1bookFIO = new System.Windows.Forms.TextBox();
            this.label8bookFIO = new System.Windows.Forms.Label();
            this.timer1Date = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHosp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Hospital)).BeginInit();
            this.tabPage2Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.tabPage3WorkLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4Timetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3Diagrams)).BeginInit();
            this.tabPage4Patients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.tabPage5Record.SuspendLayout();
            this.tabPage6complaintbook.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1Main);
            this.tabControl1.Controls.Add(this.tabPage2Employee);
            this.tabControl1.Controls.Add(this.tabPage3WorkLoad);
            this.tabControl1.Controls.Add(this.tabPage4Patients);
            this.tabControl1.Controls.Add(this.tabPage5Record);
            this.tabControl1.Controls.Add(this.tabPage6complaintbook);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(130, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1270, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1Main
            // 
            this.tabPage1Main.BackColor = System.Drawing.Color.SlateGray;
            this.tabPage1Main.Controls.Add(this.label6Time);
            this.tabPage1Main.Controls.Add(this.label5Date);
            this.tabPage1Main.Controls.Add(this.label4Time);
            this.tabPage1Main.Controls.Add(this.label3Date);
            this.tabPage1Main.Controls.Add(this.label2Telephone);
            this.tabPage1Main.Controls.Add(this.label1Hospital);
            this.tabPage1Main.Controls.Add(this.buttoncomplaintbook);
            this.tabPage1Main.Controls.Add(this.pictureBoxHosp);
            this.tabPage1Main.Controls.Add(this.pictureBox1Hospital);
            this.tabPage1Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1Main.Location = new System.Drawing.Point(4, 29);
            this.tabPage1Main.Name = "tabPage1Main";
            this.tabPage1Main.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Main.Size = new System.Drawing.Size(1262, 488);
            this.tabPage1Main.TabIndex = 0;
            this.tabPage1Main.Text = "Главная страница";
            // 
            // label6Time
            // 
            this.label6Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6Time.AutoSize = true;
            this.label6Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6Time.Location = new System.Drawing.Point(69, 452);
            this.label6Time.Name = "label6Time";
            this.label6Time.Size = new System.Drawing.Size(142, 20);
            this.label6Time.TabIndex = 8;
            this.label6Time.Text = "Текущее время:";
            // 
            // label5Date
            // 
            this.label5Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5Date.AutoSize = true;
            this.label5Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5Date.Location = new System.Drawing.Point(69, 415);
            this.label5Date.Name = "label5Date";
            this.label5Date.Size = new System.Drawing.Size(132, 20);
            this.label5Date.TabIndex = 7;
            this.label5Date.Text = "Текущая дата:";
            // 
            // label4Time
            // 
            this.label4Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4Time.AutoSize = true;
            this.label4Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4Time.Location = new System.Drawing.Point(246, 449);
            this.label4Time.Name = "label4Time";
            this.label4Time.Size = new System.Drawing.Size(0, 20);
            this.label4Time.TabIndex = 6;
            // 
            // label3Date
            // 
            this.label3Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3Date.AutoSize = true;
            this.label3Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3Date.Location = new System.Drawing.Point(246, 417);
            this.label3Date.Name = "label3Date";
            this.label3Date.Size = new System.Drawing.Size(0, 20);
            this.label3Date.TabIndex = 5;
            // 
            // label2Telephone
            // 
            this.label2Telephone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2Telephone.AutoSize = true;
            this.label2Telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2Telephone.Location = new System.Drawing.Point(506, 441);
            this.label2Telephone.Name = "label2Telephone";
            this.label2Telephone.Size = new System.Drawing.Size(515, 25);
            this.label2Telephone.TabIndex = 4;
            this.label2Telephone.Text = "Горячая линия тех. поддержки: 8-800-555-35-35.";
            // 
            // label1Hospital
            // 
            this.label1Hospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Hospital.Location = new System.Drawing.Point(6, 6);
            this.label1Hospital.Name = "label1Hospital";
            this.label1Hospital.Size = new System.Drawing.Size(341, 124);
            this.label1Hospital.TabIndex = 3;
            this.label1Hospital.Text = "ГАУЗ городская поликлиника № 21\r\nстуденческая поликлиника\r\nрежим работы:\r\nс 8.30 " +
    "до 19:30.\r\n\r\n";
            // 
            // buttoncomplaintbook
            // 
            this.buttoncomplaintbook.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttoncomplaintbook.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttoncomplaintbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttoncomplaintbook.Location = new System.Drawing.Point(83, 315);
            this.buttoncomplaintbook.Name = "buttoncomplaintbook";
            this.buttoncomplaintbook.Size = new System.Drawing.Size(173, 64);
            this.buttoncomplaintbook.TabIndex = 2;
            this.buttoncomplaintbook.Text = "Жалобная книга.";
            this.buttoncomplaintbook.UseVisualStyleBackColor = false;
            this.buttoncomplaintbook.Click += new System.EventHandler(this.buttoncomplaintbook_Click);
            // 
            // pictureBoxHosp
            // 
            this.pictureBoxHosp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxHosp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHosp.Image")));
            this.pictureBoxHosp.Location = new System.Drawing.Point(59, 133);
            this.pictureBoxHosp.Name = "pictureBoxHosp";
            this.pictureBoxHosp.Size = new System.Drawing.Size(226, 176);
            this.pictureBoxHosp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHosp.TabIndex = 1;
            this.pictureBoxHosp.TabStop = false;
            // 
            // pictureBox1Hospital
            // 
            this.pictureBox1Hospital.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1Hospital.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Hospital.Image")));
            this.pictureBox1Hospital.Location = new System.Drawing.Point(348, 0);
            this.pictureBox1Hospital.Name = "pictureBox1Hospital";
            this.pictureBox1Hospital.Size = new System.Drawing.Size(914, 413);
            this.pictureBox1Hospital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Hospital.TabIndex = 0;
            this.pictureBox1Hospital.TabStop = false;
            // 
            // tabPage2Employee
            // 
            this.tabPage2Employee.BackColor = System.Drawing.Color.SlateGray;
            this.tabPage2Employee.Controls.Add(this.button6updateEmployee);
            this.tabPage2Employee.Controls.Add(this.dataGridViewEmployee);
            this.tabPage2Employee.Controls.Add(this.buttonEmployee);
            this.tabPage2Employee.Location = new System.Drawing.Point(4, 29);
            this.tabPage2Employee.Name = "tabPage2Employee";
            this.tabPage2Employee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Employee.Size = new System.Drawing.Size(1262, 488);
            this.tabPage2Employee.TabIndex = 1;
            this.tabPage2Employee.Text = " Сотрудники";
            // 
            // button6updateEmployee
            // 
            this.button6updateEmployee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button6updateEmployee.AutoSize = true;
            this.button6updateEmployee.Location = new System.Drawing.Point(426, 425);
            this.button6updateEmployee.Name = "button6updateEmployee";
            this.button6updateEmployee.Size = new System.Drawing.Size(155, 47);
            this.button6updateEmployee.TabIndex = 6;
            this.button6updateEmployee.Text = "Обновить список";
            this.button6updateEmployee.UseVisualStyleBackColor = true;
            this.button6updateEmployee.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(0, 4);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1259, 420);
            this.dataGridViewEmployee.TabIndex = 5;
            this.dataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewEmployee.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEmployee.AutoSize = true;
            this.buttonEmployee.Location = new System.Drawing.Point(141, 425);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(161, 47);
            this.buttonEmployee.TabIndex = 4;
            this.buttonEmployee.Text = "Выгрузить список";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage3WorkLoad
            // 
            this.tabPage3WorkLoad.BackColor = System.Drawing.Color.SlateGray;
            this.tabPage3WorkLoad.Controls.Add(this.pictureBox4Timetable);
            this.tabPage3WorkLoad.Controls.Add(this.pictureBox3Diagrams);
            this.tabPage3WorkLoad.Controls.Add(this.label7announcement);
            this.tabPage3WorkLoad.Location = new System.Drawing.Point(4, 29);
            this.tabPage3WorkLoad.Name = "tabPage3WorkLoad";
            this.tabPage3WorkLoad.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3WorkLoad.Size = new System.Drawing.Size(1262, 488);
            this.tabPage3WorkLoad.TabIndex = 2;
            this.tabPage3WorkLoad.Text = "Загруженность врачей";
            // 
            // pictureBox4Timetable
            // 
            this.pictureBox4Timetable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4Timetable.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4Timetable.Image")));
            this.pictureBox4Timetable.Location = new System.Drawing.Point(20, 78);
            this.pictureBox4Timetable.Name = "pictureBox4Timetable";
            this.pictureBox4Timetable.Size = new System.Drawing.Size(601, 386);
            this.pictureBox4Timetable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4Timetable.TabIndex = 2;
            this.pictureBox4Timetable.TabStop = false;
            // 
            // pictureBox3Diagrams
            // 
            this.pictureBox3Diagrams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3Diagrams.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3Diagrams.Image")));
            this.pictureBox3Diagrams.Location = new System.Drawing.Point(627, 78);
            this.pictureBox3Diagrams.Name = "pictureBox3Diagrams";
            this.pictureBox3Diagrams.Size = new System.Drawing.Size(632, 386);
            this.pictureBox3Diagrams.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3Diagrams.TabIndex = 1;
            this.pictureBox3Diagrams.TabStop = false;
            // 
            // label7announcement
            // 
            this.label7announcement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7announcement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7announcement.Location = new System.Drawing.Point(172, 3);
            this.label7announcement.Name = "label7announcement";
            this.label7announcement.Size = new System.Drawing.Size(819, 72);
            this.label7announcement.TabIndex = 0;
            this.label7announcement.Text = "Уважаемые сотрудники! График и расписание обновляется каждую cубботу в 04:00.Прос" +
    "им отнестись с пониманием.";
            // 
            // tabPage4Patients
            // 
            this.tabPage4Patients.BackColor = System.Drawing.Color.SlateGray;
            this.tabPage4Patients.Controls.Add(this.button3unloadpatients);
            this.tabPage4Patients.Controls.Add(this.buttonunload1);
            this.tabPage4Patients.Controls.Add(this.dataGridViewPatients);
            this.tabPage4Patients.Location = new System.Drawing.Point(4, 29);
            this.tabPage4Patients.Name = "tabPage4Patients";
            this.tabPage4Patients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4Patients.Size = new System.Drawing.Size(1262, 488);
            this.tabPage4Patients.TabIndex = 3;
            this.tabPage4Patients.Text = "Пациенты";
            // 
            // button3unloadpatients
            // 
            this.button3unloadpatients.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3unloadpatients.Location = new System.Drawing.Point(570, 421);
            this.button3unloadpatients.Name = "button3unloadpatients";
            this.button3unloadpatients.Size = new System.Drawing.Size(132, 38);
            this.button3unloadpatients.TabIndex = 2;
            this.button3unloadpatients.Text = "Обновить список";
            this.button3unloadpatients.UseVisualStyleBackColor = true;
            this.button3unloadpatients.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonunload1
            // 
            this.buttonunload1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonunload1.Location = new System.Drawing.Point(106, 418);
            this.buttonunload1.Name = "buttonunload1";
            this.buttonunload1.Size = new System.Drawing.Size(146, 45);
            this.buttonunload1.TabIndex = 1;
            this.buttonunload1.Text = "Выгрузить список";
            this.buttonunload1.UseVisualStyleBackColor = true;
            this.buttonunload1.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(6, 3);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.RowHeadersWidth = 51;
            this.dataGridViewPatients.RowTemplate.Height = 24;
            this.dataGridViewPatients.Size = new System.Drawing.Size(1253, 391);
            this.dataGridViewPatients.TabIndex = 0;
            this.dataGridViewPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridViewPatients.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_UserAddedRow);
            // 
            // tabPage5Record
            // 
            this.tabPage5Record.BackColor = System.Drawing.Color.SlateGray;
            this.tabPage5Record.Controls.Add(this.label15announcementreception);
            this.tabPage5Record.Controls.Add(this.button9Printreception);
            this.tabPage5Record.Controls.Add(this.button8savereception);
            this.tabPage5Record.Controls.Add(this.textBox7symptoms);
            this.tabPage5Record.Controls.Add(this.textBox6addres);
            this.tabPage5Record.Controls.Add(this.textBox5snils);
            this.tabPage5Record.Controls.Add(this.textBox4age);
            this.tabPage5Record.Controls.Add(this.textBox3FIO);
            this.tabPage5Record.Controls.Add(this.label14symptoms);
            this.tabPage5Record.Controls.Add(this.label13addres);
            this.tabPage5Record.Controls.Add(this.label12SNILS);
            this.tabPage5Record.Controls.Add(this.label11Age);
            this.tabPage5Record.Controls.Add(this.label10FIO);
            this.tabPage5Record.Location = new System.Drawing.Point(4, 29);
            this.tabPage5Record.Name = "tabPage5Record";
            this.tabPage5Record.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5Record.Size = new System.Drawing.Size(1262, 488);
            this.tabPage5Record.TabIndex = 4;
            this.tabPage5Record.Text = "Запись на приём";
            // 
            // label15announcementreception
            // 
            this.label15announcementreception.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15announcementreception.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15announcementreception.Location = new System.Drawing.Point(6, 22);
            this.label15announcementreception.Name = "label15announcementreception";
            this.label15announcementreception.Size = new System.Drawing.Size(1259, 54);
            this.label15announcementreception.TabIndex = 16;
            this.label15announcementreception.Text = "Уважаемые сотрудники! Запись на приём осуществялется строго в будние дни с 7:00 д" +
    "о 16:30.\r\n";
            // 
            // button9Printreception
            // 
            this.button9Printreception.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button9Printreception.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9Printreception.Location = new System.Drawing.Point(692, 400);
            this.button9Printreception.Name = "button9Printreception";
            this.button9Printreception.Size = new System.Drawing.Size(185, 77);
            this.button9Printreception.TabIndex = 15;
            this.button9Printreception.Text = "Печать направления";
            this.button9Printreception.UseVisualStyleBackColor = true;
            this.button9Printreception.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8savereception
            // 
            this.button8savereception.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button8savereception.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8savereception.Location = new System.Drawing.Point(972, 400);
            this.button8savereception.Name = "button8savereception";
            this.button8savereception.Size = new System.Drawing.Size(264, 77);
            this.button8savereception.TabIndex = 14;
            this.button8savereception.Text = "Сохранить в базу данных и в файл";
            this.button8savereception.UseVisualStyleBackColor = true;
            this.button8savereception.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox7symptoms
            // 
            this.textBox7symptoms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7symptoms.Location = new System.Drawing.Point(234, 327);
            this.textBox7symptoms.Name = "textBox7symptoms";
            this.textBox7symptoms.Size = new System.Drawing.Size(613, 22);
            this.textBox7symptoms.TabIndex = 11;
            // 
            // textBox6addres
            // 
            this.textBox6addres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6addres.Location = new System.Drawing.Point(234, 270);
            this.textBox6addres.Name = "textBox6addres";
            this.textBox6addres.Size = new System.Drawing.Size(613, 22);
            this.textBox6addres.TabIndex = 10;
            // 
            // textBox5snils
            // 
            this.textBox5snils.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5snils.Location = new System.Drawing.Point(234, 218);
            this.textBox5snils.Name = "textBox5snils";
            this.textBox5snils.Size = new System.Drawing.Size(613, 22);
            this.textBox5snils.TabIndex = 9;
            // 
            // textBox4age
            // 
            this.textBox4age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4age.Location = new System.Drawing.Point(234, 169);
            this.textBox4age.Name = "textBox4age";
            this.textBox4age.Size = new System.Drawing.Size(613, 22);
            this.textBox4age.TabIndex = 8;
            // 
            // textBox3FIO
            // 
            this.textBox3FIO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3FIO.Location = new System.Drawing.Point(234, 122);
            this.textBox3FIO.Name = "textBox3FIO";
            this.textBox3FIO.Size = new System.Drawing.Size(613, 22);
            this.textBox3FIO.TabIndex = 7;
            // 
            // label14symptoms
            // 
            this.label14symptoms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14symptoms.AutoSize = true;
            this.label14symptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14symptoms.Location = new System.Drawing.Point(85, 323);
            this.label14symptoms.Name = "label14symptoms";
            this.label14symptoms.Size = new System.Drawing.Size(118, 25);
            this.label14symptoms.TabIndex = 4;
            this.label14symptoms.Text = "Симптомы";
            // 
            // label13addres
            // 
            this.label13addres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13addres.AutoSize = true;
            this.label13addres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13addres.Location = new System.Drawing.Point(85, 266);
            this.label13addres.Name = "label13addres";
            this.label13addres.Size = new System.Drawing.Size(69, 25);
            this.label13addres.TabIndex = 3;
            this.label13addres.Text = "Адрес";
            // 
            // label12SNILS
            // 
            this.label12SNILS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12SNILS.AutoSize = true;
            this.label12SNILS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12SNILS.Location = new System.Drawing.Point(85, 218);
            this.label12SNILS.Name = "label12SNILS";
            this.label12SNILS.Size = new System.Drawing.Size(80, 25);
            this.label12SNILS.TabIndex = 2;
            this.label12SNILS.Text = "СНИЛС";
            // 
            // label11Age
            // 
            this.label11Age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11Age.AutoSize = true;
            this.label11Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11Age.Location = new System.Drawing.Point(85, 169);
            this.label11Age.Name = "label11Age";
            this.label11Age.Size = new System.Drawing.Size(89, 25);
            this.label11Age.TabIndex = 1;
            this.label11Age.Text = "Возраст";
            // 
            // label10FIO
            // 
            this.label10FIO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10FIO.AutoSize = true;
            this.label10FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10FIO.Location = new System.Drawing.Point(85, 122);
            this.label10FIO.Name = "label10FIO";
            this.label10FIO.Size = new System.Drawing.Size(60, 25);
            this.label10FIO.TabIndex = 0;
            this.label10FIO.Text = "ФИО";
            // 
            // tabPage6complaintbook
            // 
            this.tabPage6complaintbook.BackColor = System.Drawing.Color.SlateGray;
            this.tabPage6complaintbook.Controls.Add(this.button7printwritecomplaint);
            this.tabPage6complaintbook.Controls.Add(this.button4savewritecomplaint);
            this.tabPage6complaintbook.Controls.Add(this.label9writecomplaint);
            this.tabPage6complaintbook.Controls.Add(this.textBox2writecomplaint);
            this.tabPage6complaintbook.Controls.Add(this.textBox1bookFIO);
            this.tabPage6complaintbook.Controls.Add(this.label8bookFIO);
            this.tabPage6complaintbook.Location = new System.Drawing.Point(4, 29);
            this.tabPage6complaintbook.Name = "tabPage6complaintbook";
            this.tabPage6complaintbook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6complaintbook.Size = new System.Drawing.Size(1262, 488);
            this.tabPage6complaintbook.TabIndex = 5;
            this.tabPage6complaintbook.Text = "Жалобная книга";
            // 
            // button7printwritecomplaint
            // 
            this.button7printwritecomplaint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button7printwritecomplaint.Location = new System.Drawing.Point(602, 416);
            this.button7printwritecomplaint.Name = "button7printwritecomplaint";
            this.button7printwritecomplaint.Size = new System.Drawing.Size(162, 47);
            this.button7printwritecomplaint.TabIndex = 5;
            this.button7printwritecomplaint.Text = "Распечатать";
            this.button7printwritecomplaint.UseVisualStyleBackColor = true;
            this.button7printwritecomplaint.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4savewritecomplaint
            // 
            this.button4savewritecomplaint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4savewritecomplaint.Location = new System.Drawing.Point(947, 416);
            this.button4savewritecomplaint.Name = "button4savewritecomplaint";
            this.button4savewritecomplaint.Size = new System.Drawing.Size(255, 48);
            this.button4savewritecomplaint.TabIndex = 4;
            this.button4savewritecomplaint.Text = "Сохранить и отправить в базу данных";
            this.button4savewritecomplaint.UseVisualStyleBackColor = true;
            this.button4savewritecomplaint.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9writecomplaint
            // 
            this.label9writecomplaint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9writecomplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9writecomplaint.Location = new System.Drawing.Point(11, 95);
            this.label9writecomplaint.Name = "label9writecomplaint";
            this.label9writecomplaint.Size = new System.Drawing.Size(313, 23);
            this.label9writecomplaint.TabIndex = 3;
            this.label9writecomplaint.Text = "Ниже напишите вашу жалобу";
            // 
            // textBox2writecomplaint
            // 
            this.textBox2writecomplaint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2writecomplaint.Location = new System.Drawing.Point(3, 121);
            this.textBox2writecomplaint.Multiline = true;
            this.textBox2writecomplaint.Name = "textBox2writecomplaint";
            this.textBox2writecomplaint.Size = new System.Drawing.Size(1256, 289);
            this.textBox2writecomplaint.TabIndex = 2;
            // 
            // textBox1bookFIO
            // 
            this.textBox1bookFIO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1bookFIO.Location = new System.Drawing.Point(185, 31);
            this.textBox1bookFIO.Name = "textBox1bookFIO";
            this.textBox1bookFIO.Size = new System.Drawing.Size(453, 22);
            this.textBox1bookFIO.TabIndex = 1;
            // 
            // label8bookFIO
            // 
            this.label8bookFIO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8bookFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8bookFIO.Location = new System.Drawing.Point(16, 31);
            this.label8bookFIO.Name = "label8bookFIO";
            this.label8bookFIO.Size = new System.Drawing.Size(163, 23);
            this.label8bookFIO.TabIndex = 0;
            this.label8bookFIO.Text = "Введите ФИО";
            this.label8bookFIO.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // timer1Date
            // 
            this.timer1Date.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1270, 521);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Городская клиническая поликлиника №21";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1Main.ResumeLayout(false);
            this.tabPage1Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHosp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Hospital)).EndInit();
            this.tabPage2Employee.ResumeLayout(false);
            this.tabPage2Employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.tabPage3WorkLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4Timetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3Diagrams)).EndInit();
            this.tabPage4Patients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.tabPage5Record.ResumeLayout(false);
            this.tabPage5Record.PerformLayout();
            this.tabPage6complaintbook.ResumeLayout(false);
            this.tabPage6complaintbook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1Main;
        private System.Windows.Forms.Label label1Hospital;
        private System.Windows.Forms.Button buttoncomplaintbook;
        private System.Windows.Forms.PictureBox pictureBoxHosp;
        private System.Windows.Forms.PictureBox pictureBox1Hospital;
        public System.Windows.Forms.TabPage tabPage2Employee;
        private System.Windows.Forms.Label label4Time;
        private System.Windows.Forms.Label label3Date;
        private System.Windows.Forms.Label label2Telephone;
        private System.Windows.Forms.Timer timer1Date;
        private System.Windows.Forms.Label label6Time;
        private System.Windows.Forms.Label label5Date;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button button6updateEmployee;
        public System.Windows.Forms.TabPage tabPage3WorkLoad;
        private System.Windows.Forms.PictureBox pictureBox4Timetable;
        private System.Windows.Forms.PictureBox pictureBox3Diagrams;
        private System.Windows.Forms.Label label7announcement;
        private System.Windows.Forms.TabPage tabPage4Patients;
        private System.Windows.Forms.TabPage tabPage5Record;
        private System.Windows.Forms.TabPage tabPage6complaintbook;
        private System.Windows.Forms.Button button3unloadpatients;
        private System.Windows.Forms.Button buttonunload1;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Label label9writecomplaint;
        private System.Windows.Forms.TextBox textBox2writecomplaint;
        private System.Windows.Forms.TextBox textBox1bookFIO;
        private System.Windows.Forms.Label label8bookFIO;
        private System.Windows.Forms.Button button4savewritecomplaint;
        private System.Windows.Forms.Button button7printwritecomplaint;
        private System.Windows.Forms.Button button8savereception;
        private System.Windows.Forms.TextBox textBox7symptoms;
        private System.Windows.Forms.TextBox textBox6addres;
        private System.Windows.Forms.TextBox textBox5snils;
        private System.Windows.Forms.TextBox textBox4age;
        private System.Windows.Forms.TextBox textBox3FIO;
        private System.Windows.Forms.Label label14symptoms;
        private System.Windows.Forms.Label label13addres;
        private System.Windows.Forms.Label label12SNILS;
        private System.Windows.Forms.Label label11Age;
        private System.Windows.Forms.Label label10FIO;
        private System.Windows.Forms.Button button9Printreception;
        private System.Windows.Forms.Label label15announcementreception;
    }
}


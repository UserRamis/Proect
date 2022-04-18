
namespace Project
{
    partial class FormAuthorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.label1Login = new System.Windows.Forms.Label();
            this.label2Password = new System.Windows.Forms.Label();
            this.textBox1Login = new System.Windows.Forms.TextBox();
            this.textBox2Password = new System.Windows.Forms.TextBox();
            this.button1Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1Login
            // 
            this.label1Login.AutoSize = true;
            this.label1Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1Login.Location = new System.Drawing.Point(113, 71);
            this.label1Login.Name = "label1Login";
            this.label1Login.Size = new System.Drawing.Size(69, 24);
            this.label1Login.TabIndex = 0;
            this.label1Login.Text = "Логин:";
            // 
            // label2Password
            // 
            this.label2Password.AutoSize = true;
            this.label2Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2Password.Location = new System.Drawing.Point(113, 145);
            this.label2Password.Name = "label2Password";
            this.label2Password.Size = new System.Drawing.Size(81, 24);
            this.label2Password.TabIndex = 1;
            this.label2Password.Text = "Пароль:";
            // 
            // textBox1Login
            // 
            this.textBox1Login.Location = new System.Drawing.Point(201, 73);
            this.textBox1Login.Name = "textBox1Login";
            this.textBox1Login.Size = new System.Drawing.Size(143, 22);
            this.textBox1Login.TabIndex = 2;
            // 
            // textBox2Password
            // 
            this.textBox2Password.Location = new System.Drawing.Point(201, 147);
            this.textBox2Password.Name = "textBox2Password";
            this.textBox2Password.Size = new System.Drawing.Size(143, 22);
            this.textBox2Password.TabIndex = 3;
            this.textBox2Password.UseSystemPasswordChar = true;
            // 
            // button1Continue
            // 
            this.button1Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Continue.Location = new System.Drawing.Point(356, 241);
            this.button1Continue.Name = "button1Continue";
            this.button1Continue.Size = new System.Drawing.Size(163, 51);
            this.button1Continue.TabIndex = 4;
            this.button1Continue.Text = "Продолжить";
            this.button1Continue.UseVisualStyleBackColor = true;
            this.button1Continue.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 304);
            this.Controls.Add(this.button1Continue);
            this.Controls.Add(this.textBox2Password);
            this.Controls.Add(this.textBox1Login);
            this.Controls.Add(this.label2Password);
            this.Controls.Add(this.label1Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAuthorization";
            this.Text = "Окно авторизации";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Login;
        private System.Windows.Forms.Label label2Password;
        private System.Windows.Forms.TextBox textBox1Login;
        private System.Windows.Forms.TextBox textBox2Password;
        private System.Windows.Forms.Button button1Continue;
    }
}
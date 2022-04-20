
namespace Project
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelFIOMED = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxFIOMED = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(87, 112);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(153, 25);
            this.labelFIO.TabIndex = 8;
            this.labelFIO.Text = "ФИО пациента";
            // 
            // labelFIOMED
            // 
            this.labelFIOMED.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFIOMED.AutoSize = true;
            this.labelFIOMED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIOMED.Location = new System.Drawing.Point(87, 232);
            this.labelFIOMED.Name = "labelFIOMED";
            this.labelFIOMED.Size = new System.Drawing.Size(302, 25);
            this.labelFIOMED.TabIndex = 9;
            this.labelFIOMED.Text = "ФИО медицинского работника";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFIO.Location = new System.Drawing.Point(452, 115);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(308, 22);
            this.textBoxFIO.TabIndex = 10;
            // 
            // textBoxFIOMED
            // 
            this.textBoxFIOMED.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFIOMED.Location = new System.Drawing.Point(452, 236);
            this.textBoxFIOMED.Name = "textBoxFIOMED";
            this.textBoxFIOMED.Size = new System.Drawing.Size(308, 22);
            this.textBoxFIOMED.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(587, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFIOMED);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelFIOMED);
            this.Controls.Add(this.labelFIO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Согласие на проведение МРТ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelFIOMED;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxFIOMED;
        private System.Windows.Forms.Button button1;
    }
}
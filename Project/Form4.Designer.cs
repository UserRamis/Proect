
namespace Project
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelMED = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.buttonSAVE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(111, 148);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(60, 25);
            this.labelFIO.TabIndex = 8;
            this.labelFIO.Text = "ФИО";
            // 
            // labelMED
            // 
            this.labelMED.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMED.AutoSize = true;
            this.labelMED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMED.Location = new System.Drawing.Point(111, 235);
            this.labelMED.Name = "labelMED";
            this.labelMED.Size = new System.Drawing.Size(202, 25);
            this.labelMED.TabIndex = 9;
            this.labelMED.Text = "Медицинская группа";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFIO.Location = new System.Drawing.Point(373, 148);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(298, 22);
            this.textBoxFIO.TabIndex = 10;
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNAME.Location = new System.Drawing.Point(373, 238);
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(298, 22);
            this.textBoxNAME.TabIndex = 11;
            // 
            // buttonSAVE
            // 
            this.buttonSAVE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSAVE.Location = new System.Drawing.Point(610, 382);
            this.buttonSAVE.Name = "buttonSAVE";
            this.buttonSAVE.Size = new System.Drawing.Size(134, 41);
            this.buttonSAVE.TabIndex = 12;
            this.buttonSAVE.Text = "Сохранить";
            this.buttonSAVE.UseVisualStyleBackColor = true;
            this.buttonSAVE.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSAVE);
            this.Controls.Add(this.textBoxNAME);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelMED);
            this.Controls.Add(this.labelFIO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Освобождение от уроков физкультуры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelMED;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.Button buttonSAVE;
    }
}
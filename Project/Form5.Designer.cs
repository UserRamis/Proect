
namespace Project
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelDATA = new System.Windows.Forms.Label();
            this.labelFIOMED = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxDATA = new System.Windows.Forms.TextBox();
            this.textBoxMED = new System.Windows.Forms.TextBox();
            this.buttonSAVE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(120, 72);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(153, 25);
            this.labelFIO.TabIndex = 8;
            this.labelFIO.Text = "ФИО пациента";
            // 
            // labelDATA
            // 
            this.labelDATA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDATA.AutoSize = true;
            this.labelDATA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDATA.Location = new System.Drawing.Point(120, 183);
            this.labelDATA.Name = "labelDATA";
            this.labelDATA.Size = new System.Drawing.Size(240, 50);
            this.labelDATA.TabIndex = 9;
            this.labelDATA.Text = "Дата рождения\r\n( в формате 01.01.2000)";
            // 
            // labelFIOMED
            // 
            this.labelFIOMED.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFIOMED.AutoSize = true;
            this.labelFIOMED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIOMED.Location = new System.Drawing.Point(120, 319);
            this.labelFIOMED.Name = "labelFIOMED";
            this.labelFIOMED.Size = new System.Drawing.Size(205, 50);
            this.labelFIOMED.TabIndex = 10;
            this.labelFIOMED.Text = "ФИО медицинского \r\nработника";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFIO.Location = new System.Drawing.Point(401, 76);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(288, 22);
            this.textBoxFIO.TabIndex = 11;
            // 
            // textBoxDATA
            // 
            this.textBoxDATA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDATA.Location = new System.Drawing.Point(401, 211);
            this.textBoxDATA.Name = "textBoxDATA";
            this.textBoxDATA.Size = new System.Drawing.Size(288, 22);
            this.textBoxDATA.TabIndex = 12;
            // 
            // textBoxMED
            // 
            this.textBoxMED.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMED.Location = new System.Drawing.Point(401, 319);
            this.textBoxMED.Name = "textBoxMED";
            this.textBoxMED.Size = new System.Drawing.Size(288, 22);
            this.textBoxMED.TabIndex = 13;
            // 
            // buttonSAVE
            // 
            this.buttonSAVE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSAVE.Location = new System.Drawing.Point(609, 401);
            this.buttonSAVE.Name = "buttonSAVE";
            this.buttonSAVE.Size = new System.Drawing.Size(127, 37);
            this.buttonSAVE.TabIndex = 14;
            this.buttonSAVE.Text = "Сохранить";
            this.buttonSAVE.UseVisualStyleBackColor = true;
            this.buttonSAVE.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSAVE);
            this.Controls.Add(this.textBoxMED);
            this.Controls.Add(this.textBoxDATA);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelFIOMED);
            this.Controls.Add(this.labelDATA);
            this.Controls.Add(this.labelFIO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Согласие на медицинское вмешательтсво";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelDATA;
        private System.Windows.Forms.Label labelFIOMED;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxDATA;
        private System.Windows.Forms.TextBox textBoxMED;
        private System.Windows.Forms.Button buttonSAVE;
    }
}
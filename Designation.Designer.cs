namespace Project
{
    partial class Designation
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
            System.Windows.Forms.Label Label1;
            this.btnadd = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.desigid = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = System.Drawing.Color.Linen;
            Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            Label1.ForeColor = System.Drawing.Color.Black;
            Label1.Location = new System.Drawing.Point(128, 75);
            Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            Label1.Size = new System.Drawing.Size(310, 66);
            Label1.TabIndex = 12;
            Label1.Text = "DESIGNATION";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Linen;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(136, 334);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(327, 47);
            this.btnadd.TabIndex = 15;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(129, 188);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(283, 36);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "Designation Name ";
            // 
            // desigid
            // 
            this.desigid.AutoSize = true;
            this.desigid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.desigid.ForeColor = System.Drawing.Color.Black;
            this.desigid.Location = new System.Drawing.Point(31, 34);
            this.desigid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.desigid.Name = "desigid";
            this.desigid.Size = new System.Drawing.Size(33, 36);
            this.desigid.TabIndex = 16;
            this.desigid.Text = "0";
            // 
            // cmbCity
            // 
            this.cmbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "operater",
            "setter",
            "quality",
            "cutting",
            "drilling",
            "supervisors",
            "security",
            "manager",
            "HR"});
            this.cmbCity.Location = new System.Drawing.Point(139, 238);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(312, 39);
            this.cmbCity.TabIndex = 17;
            this.cmbCity.Text = "--select your designation --";
            // 
            // Designation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(603, 430);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.desigid);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.Label3);
            this.Controls.Add(Label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Designation";
            this.Text = "Designation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label desigid;
        private System.Windows.Forms.ComboBox cmbCity;
    }
}
namespace Project
{
    partial class frmdaily_salary
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dailysalid = new System.Windows.Forms.Label();
            this.txttotalsalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.date.Location = new System.Drawing.Point(395, 269);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(303, 38);
            this.date.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(264, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 36);
            this.label3.TabIndex = 118;
            this.label3.Text = "Date :";
            // 
            // dailysalid
            // 
            this.dailysalid.AutoSize = true;
            this.dailysalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.dailysalid.ForeColor = System.Drawing.Color.Black;
            this.dailysalid.Location = new System.Drawing.Point(193, 104);
            this.dailysalid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dailysalid.Name = "dailysalid";
            this.dailysalid.Size = new System.Drawing.Size(33, 36);
            this.dailysalid.TabIndex = 117;
            this.dailysalid.Text = "0";
            // 
            // txttotalsalary
            // 
            this.txttotalsalary.BackColor = System.Drawing.Color.White;
            this.txttotalsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txttotalsalary.Location = new System.Drawing.Point(395, 345);
            this.txttotalsalary.Margin = new System.Windows.Forms.Padding(4);
            this.txttotalsalary.Name = "txttotalsalary";
            this.txttotalsalary.Size = new System.Drawing.Size(303, 38);
            this.txttotalsalary.TabIndex = 116;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(140, 345);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 36);
            this.label10.TabIndex = 115;
            this.label10.Text = "Total_Salary :";
            // 
            // txtempid
            // 
            this.txtempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtempid.Location = new System.Drawing.Point(395, 198);
            this.txtempid.Margin = new System.Windows.Forms.Padding(4);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(303, 38);
            this.txtempid.TabIndex = 114;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(216, 200);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(141, 36);
            this.Label2.TabIndex = 113;
            this.Label2.Text = "emp_ID :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Linen;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(308, 84);
            this.Label1.Margin = new System.Windows.Forms.Padding(4);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Label1.Size = new System.Drawing.Size(321, 66);
            this.Label1.TabIndex = 112;
            this.Label1.Text = "DAILY SALARY";
            // 
            // frmdaily_salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(839, 466);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dailysalid);
            this.Controls.Add(this.txttotalsalary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "frmdaily_salary";
            this.Text = "frmdaily_salary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker date;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label dailysalid;
        internal System.Windows.Forms.TextBox txttotalsalary;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtempid;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}
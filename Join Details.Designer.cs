namespace Project
{
    partial class Join_Details
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
            this.leavingdate = new System.Windows.Forms.DateTimePicker();
            this.joindate = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.joinid = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txtdesignid = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leavingdate
            // 
            this.leavingdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.leavingdate.Location = new System.Drawing.Point(553, 325);
            this.leavingdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leavingdate.Name = "leavingdate";
            this.leavingdate.Size = new System.Drawing.Size(303, 38);
            this.leavingdate.TabIndex = 27;
            // 
            // joindate
            // 
            this.joindate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.joindate.Location = new System.Drawing.Point(83, 327);
            this.joindate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.joindate.Name = "joindate";
            this.joindate.Size = new System.Drawing.Size(303, 38);
            this.joindate.TabIndex = 26;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(553, 276);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(210, 36);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "Leaving_Date";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Linen;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(257, 457);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(329, 63);
            this.btnadd.TabIndex = 22;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(83, 282);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(167, 36);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Join_Date ";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Linen;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(296, 47);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Label1.Size = new System.Drawing.Size(305, 66);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "JOIN DETAILS";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // joinid
            // 
            this.joinid.AutoSize = true;
            this.joinid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.joinid.ForeColor = System.Drawing.Color.Black;
            this.joinid.Location = new System.Drawing.Point(32, 33);
            this.joinid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.joinid.Name = "joinid";
            this.joinid.Size = new System.Drawing.Size(33, 36);
            this.joinid.TabIndex = 28;
            this.joinid.Text = "0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(83, 161);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(118, 36);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "emp_id";
            // 
            // txtempid
            // 
            this.txtempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtempid.Location = new System.Drawing.Point(83, 207);
            this.txtempid.Margin = new System.Windows.Forms.Padding(4);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(303, 38);
            this.txtempid.TabIndex = 21;
            // 
            // txtdesignid
            // 
            this.txtdesignid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtdesignid.Location = new System.Drawing.Point(553, 207);
            this.txtdesignid.Margin = new System.Windows.Forms.Padding(4);
            this.txtdesignid.Name = "txtdesignid";
            this.txtdesignid.Size = new System.Drawing.Size(303, 38);
            this.txtdesignid.TabIndex = 25;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(553, 161);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(228, 36);
            this.Label5.TabIndex = 24;
            this.Label5.Text = "Designation_id";
            // 
            // Join_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(933, 571);
            this.Controls.Add(this.joinid);
            this.Controls.Add(this.leavingdate);
            this.Controls.Add(this.joindate);
            this.Controls.Add(this.txtdesignid);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Join_Details";
            this.Text = "Join_Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker leavingdate;
        internal System.Windows.Forms.DateTimePicker joindate;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label joinid;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtempid;
        internal System.Windows.Forms.TextBox txtdesignid;
        internal System.Windows.Forms.Label Label5;
    }
}
namespace Project
{
    partial class Leave
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
            this.btnadd = new System.Windows.Forms.Button();
            this.txtleaverea = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.leaveid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Linen;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(244, 375);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(329, 63);
            this.btnadd.TabIndex = 69;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // txtleaverea
            // 
            this.txtleaverea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtleaverea.Location = new System.Drawing.Point(400, 239);
            this.txtleaverea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtleaverea.Multiline = true;
            this.txtleaverea.Name = "txtleaverea";
            this.txtleaverea.Size = new System.Drawing.Size(303, 83);
            this.txtleaverea.TabIndex = 64;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(103, 240);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(252, 36);
            this.Label4.TabIndex = 63;
            this.Label4.Text = "Leave Reasons :";
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtdate.Location = new System.Drawing.Point(400, 166);
            this.txtdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(303, 38);
            this.txtdate.TabIndex = 62;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(269, 166);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 36);
            this.Label2.TabIndex = 61;
            this.Label2.Text = "Date :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Linen;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(221, 43);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Label1.Size = new System.Drawing.Size(343, 66);
            this.Label1.TabIndex = 60;
            this.Label1.Text = "LEAVE DETAILS";
            // 
            // leaveid
            // 
            this.leaveid.AutoSize = true;
            this.leaveid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.leaveid.ForeColor = System.Drawing.Color.Black;
            this.leaveid.Location = new System.Drawing.Point(29, 31);
            this.leaveid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leaveid.Name = "leaveid";
            this.leaveid.Size = new System.Drawing.Size(33, 36);
            this.leaveid.TabIndex = 70;
            this.leaveid.Text = "0";
            // 
            // Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(921, 524);
            this.Controls.Add(this.leaveid);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtleaverea);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Leave";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.TextBox txtleaverea;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtdate;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label leaveid;
    }
}
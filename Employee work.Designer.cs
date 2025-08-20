namespace Project
{
    partial class Employee_work
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txtempwid = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtshiftid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.empwid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Linen;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(245, 429);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(313, 52);
            this.btnlogin.TabIndex = 17;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // txtempid
            // 
            this.txtempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtempid.Location = new System.Drawing.Point(290, 276);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(241, 32);
            this.txtempid.TabIndex = 16;
            // 
            // txtempwid
            // 
            this.txtempwid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtempwid.Location = new System.Drawing.Point(290, 177);
            this.txtempwid.Name = "txtempwid";
            this.txtempwid.Size = new System.Drawing.Size(241, 32);
            this.txtempwid.TabIndex = 15;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(291, 238);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(114, 29);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "emp_id :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(291, 139);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(184, 29);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "emp work_id : ";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Linen;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(254, 43);
            this.Label1.Margin = new System.Windows.Forms.Padding(3);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new System.Windows.Forms.Padding(10);
            this.Label1.Size = new System.Drawing.Size(313, 56);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "EMPLOYEE WORK";
            // 
            // txtshiftid
            // 
            this.txtshiftid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtshiftid.Location = new System.Drawing.Point(290, 366);
            this.txtshiftid.Name = "txtshiftid";
            this.txtshiftid.Size = new System.Drawing.Size(241, 32);
            this.txtshiftid.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(291, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "shft_id :";
            // 
            // empwid
            // 
            this.empwid.AutoSize = true;
            this.empwid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.empwid.ForeColor = System.Drawing.Color.Black;
            this.empwid.Location = new System.Drawing.Point(30, 31);
            this.empwid.Name = "empwid";
            this.empwid.Size = new System.Drawing.Size(27, 29);
            this.empwid.TabIndex = 20;
            this.empwid.Text = "0";
            // 
            // Employee_work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(820, 493);
            this.Controls.Add(this.empwid);
            this.Controls.Add(this.txtshiftid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.txtempwid);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Employee_work";
            this.Text = "Employee_work";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnlogin;
        internal System.Windows.Forms.TextBox txtempid;
        internal System.Windows.Forms.TextBox txtempwid;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtshiftid;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label empwid;
    }
}
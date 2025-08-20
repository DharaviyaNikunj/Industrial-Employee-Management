namespace Project
{
    partial class frmemp_type
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
            this.dailysalid = new System.Windows.Forms.Label();
            this.txttotalsalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dailysalid
            // 
            this.dailysalid.AutoSize = true;
            this.dailysalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.dailysalid.ForeColor = System.Drawing.Color.Black;
            this.dailysalid.Location = new System.Drawing.Point(96, 168);
            this.dailysalid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dailysalid.Name = "dailysalid";
            this.dailysalid.Size = new System.Drawing.Size(33, 36);
            this.dailysalid.TabIndex = 123;
            this.dailysalid.Text = "0";
            this.dailysalid.Visible = false;
            // 
            // txttotalsalary
            // 
            this.txttotalsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txttotalsalary.Location = new System.Drawing.Point(328, 329);
            this.txttotalsalary.Margin = new System.Windows.Forms.Padding(4);
            this.txttotalsalary.Name = "txttotalsalary";
            this.txttotalsalary.Size = new System.Drawing.Size(303, 38);
            this.txttotalsalary.TabIndex = 122;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(74, 329);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 36);
            this.label10.TabIndex = 121;
            this.label10.Text = "Total_Salary :";
            // 
            // txtempid
            // 
            this.txtempid.BackColor = System.Drawing.Color.White;
            this.txtempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtempid.Location = new System.Drawing.Point(328, 262);
            this.txtempid.Margin = new System.Windows.Forms.Padding(4);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(303, 38);
            this.txtempid.TabIndex = 120;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(150, 263);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(160, 36);
            this.Label2.TabIndex = 119;
            this.Label2.Text = "Temp_ID :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Linen;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(198, 151);
            this.Label1.Margin = new System.Windows.Forms.Padding(4);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Label1.Size = new System.Drawing.Size(371, 66);
            this.Label1.TabIndex = 118;
            this.Label1.Text = "EMPLOYEE TYPE";
            // 
            // frmemp_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(704, 519);
            this.Controls.Add(this.dailysalid);
            this.Controls.Add(this.txttotalsalary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "frmemp_type";
            this.Text = "frmemp_type";
            this.Load += new System.EventHandler(this.frmemp_type_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label dailysalid;
        internal System.Windows.Forms.TextBox txttotalsalary;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtempid;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}
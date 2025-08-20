using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class frmlogin : Form
    {
        string emailpatton = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
        string password = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        public frmlogin()
        {
           
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //SqlCommand CMD;
        //static string cnn = "Data Source=DharaviyaNikunj;Initial Catalog=employ_information;Integrated Security=True";
        //static SqlConnection CONN = new SqlConnection(cnn);
        //SqlDataAdapter DA;
        //DataTable DT;
        Connection cnn;

        private void btnlogin_Click(object sender, EventArgs e)
        {
        
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter Password!");
                return;
            }
            
            string Qry = "SELECT * FROM tbl_employ_details ";
            Qry += "WHERE email_id = '" + txtEmail.Text + "' AND password = '" + txtPassword.Text + "'";
            cnn = new Connection();
            int l =cnn.Login(Qry);
            if(l>0){
            MessageBox.Show("success fully login");
            }else{
                MessageBox.Show("something wrong username or password");
            }
            //CMD = new SqlCommand(Qry, CONN);
            //DA = new SqlDataAdapter(CMD);
            //DT = new DataTable();
            //DA.Fill(DT);
            //CONN.Open();
            //CMD.ExecuteNonQuery();
            //CONN.Close();
            //if (DT.Rows.Count > 0)
            //{
            //    MessageBox.Show("You Login Successfully!");
            //}
            //else {
            //    MessageBox.Show("Something is wrong email or password!");
            //}
        
        }

        private void lblTecher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Employee_details().Show();
        }

        private void frmlogin_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, emailpatton) == false)
            {
                txtEmail.Focus();
                errorProvider1.SetError(this.txtEmail, "please fill valid email");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtPassword.Text, password) == false)
            {
                txtPassword.Focus();
                errorProvider1.SetError(this.txtPassword, "please fill strong password");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}


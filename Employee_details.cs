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
    public partial class Employee_details : Form
    {
        string emailpatton = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
        string password = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        public Employee_details()
        {
            
            InitializeComponent();
        }

        Connection cnn;

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnregister_Click(object sender, EventArgs e)
        {
            string Qry = "INSERT INTO tbl_employ_details ";
            Qry += "SELECT MAX(emp_id) + 1, ";
            Qry += "'" + txtName.Text.Trim() + "', ";

            if (rdbMale.Checked)
                Qry += "'TRUE', ";
            else
                Qry += "'FALSE', ";
            Qry += "'" + bdate.Text.Trim() + "', ";
            Qry += "" + txtAge.Text.Trim() + ", ";
            Qry += "'" + txtAddress.Text.Trim() + "', ";
            Qry += "'" + cmbCity.SelectedItem.ToString() + "', ";
            Qry += "'" + txtEmail.Text.Trim() + "', ";
            Qry += "'" + txtPassword.Text.Trim() + "', ";
            Qry += "" + txtPhone.Text.Trim() + ", ";
            //Qry += "'" + cmbRole.SelectedItem.ToString() + "', ";
            Qry += "'true' FROM tbl_employ_details";
            MessageBox.Show(Qry);
            MessageBox.Show("success fully register");

            cnn = new Connection();
            cnn.Register(Qry);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                txtName.Focus();
                errorProvider1.SetError(this.txtName, "please fill name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char  ch = e.KeyChar;
            if(char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void cmbCity_Leave(object sender, EventArgs e)
        {
            if (cmbCity.SelectedIndex == -1)
            {
                
                errorProvider4.SetError(cmbCity, "Please select an option from the ComboBox.");
            }
            else
            {
           
                errorProvider4.SetError(cmbCity, "");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, emailpatton) == false)
            {
                txtEmail.Focus();
                errorProvider2.SetError(this.txtEmail, "please fill valid email");
            }
            else
            {
                errorProvider2.Clear(); 
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtPassword.Text, password) == false)
            {
                txtPassword.Focus();
                errorProvider3.SetError(this.txtPassword, "please fill strong password");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void rdbMale_Leave(object sender, EventArgs e)
        {
            if (!rdbMale.Checked && !rdbFemale.Checked)
            {
               
                
                errorProvider5.SetError(rdbMale, "Please select a gender.");
                errorProvider5.SetError(rdbFemale, "Please select a gender.");
            }
            else
            {
                
                errorProvider5.SetError(rdbMale, "");
                errorProvider5.SetError(rdbFemale, "");
                errorProvider5.Clear();

            }
        }

        private void bdate_Leave(object sender, EventArgs e)
        {
            //if (!IsValidDate(bdate.Value))
            //{

            //    errorProvider6.SetError(bdate, "Please enter a valid date in the format MM/dd/yyyy.");
            //}
            //else
            //{

            //    errorProvider6.Clear();
            //}
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                txtAddress.Focus();
                errorProvider7.SetError(txtAddress, "please enter your address");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(txtPhone.Text) == true)
            {
                txtPhone.Focus();
                errorProvider1.SetError(this.txtPhone, "please fill phone no");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

       }
    
}
 
    
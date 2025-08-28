using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_in_Sign_in_Project
{
    public partial class CfrmLogin : Form
    {
        static int iMax = 2;
       static string[] passwords = new string[iMax];
        static string[] username = new string[iMax];
        static int iCount = 0;
        public CfrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            username[iCount] = name;

            string password = txtPassword.Text;
            passwords[iCount] = password;
            iCount++;

                MessageBox.Show($"{name} you have succesfully logged in ");
             
           
            
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUserName.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

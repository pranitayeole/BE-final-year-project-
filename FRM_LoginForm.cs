using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MultiFaceRec
{
    public partial class FRM_LoginForm : Form
    {
       

        public FRM_LoginForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtpassword.Text == "admin")
            {
               Main1 frm = new Main1();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username And Password..", "correct username And Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpassword.Clear();
         
                txtUserName.Focus();
                return;
            }
            
          

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();

        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                BtnLogin.Focus();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FRM_LoginForm_Activated(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void txtUserName_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtpassword.Focus();
            }
        }

        private void txtUserName_KeyDown_2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpassword.Focus();
            }
        }

       

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;



namespace BankSystem
{
    public partial class FrmLoginScreen : Form
    {
        public FrmLoginScreen()
        {
            InitializeComponent();
            button1.Focus();

        }

       

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0 || txtUserName.Text.Length == 0) 
            {
                MessageBox.Show("error. pls enter a value.");
                return;
            }

            if (clsUsers.CheckedUser(txtUserName.Text,txtPassword.Text))
            {
                
                Form frm = new frmMainScreen(txtUserName.Text);
                frm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("User Name or Password incorrect.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

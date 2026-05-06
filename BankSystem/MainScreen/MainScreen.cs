using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankSystem
{
    public partial class frmMainScreen : Form
    {
       
        static string UserNames { get; set; }

        clsUsers User;
        

        public frmMainScreen(string UserName)
        {
            InitializeComponent();
            UserNames = UserName;
            lblUserName.Text = UserName;
            lblDateNow.Text = DateTime.Now.ToString();
            User = clsUsers.FindUserByUserName(UserNames);


        }

        

        private void _LoginRegisterScreen()
        {

            if (clsSetting.sPermission(User.Permission, clsUsers.enPermission.enLoginRegister))
            {
                Form frm = new frmLoginRegisterScreen();
                frm.ShowDialog();
                return;
            }

            MessageBox.Show(clsSetting.MessageErrorPermissionForms("Login Register Screen"));
            
        }

        private void _TransactionScreen()
        {
            if (clsSetting.sPermission(User.Permission, clsUsers.enPermission.enTransaction))
            {
                Form frm = new frmShowTransaction(User);
                frm.ShowDialog();
                return;
            }
            MessageBox.Show(clsSetting.MessageErrorPermissionForms("Show Transaction Screen"));
        }

        private void _ManageUserScreen()
        {
            if (clsSetting.sPermission(User.Permission, clsUsers.enPermission.enManageUsers))
            {
                Form frm = new frmShowManageUsers(User.UserName);
                frm.ShowDialog();
                return;
            }
            MessageBox.Show(clsSetting.MessageErrorPermissionForms("Show Manage User Screen"));
        }

        private void ClickEnterd(object sender, EventArgs e)
        {
            if (((Button)sender) == btnLoginRegister)
            {
                _LoginRegisterScreen();
            }

            else if (((Button)sender) == btnManageClients)
            {
                Form frm = new frmShowManageClients(ref User);
                frm.ShowDialog();
                return;
            }

            else if (((Button)sender) == btnManageUsers)
            {
                _ManageUserScreen();
            }
            else if ((Button)sender == btnTransactions)
            {
                _TransactionScreen();
            }
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            if (clsUsers.AddLoginRegister(UserNames))
            {
                MessageBox.Show("error, Add Login Register is dosn't work.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnCurrencyExchange_Click(object sender, EventArgs e)
        {
            Form frm = new frmCurrencyScreen(User.UserName);
            frm.ShowDialog();
        }
    }
}

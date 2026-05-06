using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmShowManageUsers : Form
    {
        private enum enEnterUser { enFind = 0, enDelete = 1, enUpdate};
        private enEnterUser EnterUser = new enEnterUser();
        private string UserName {  get; set; }
        public frmShowManageUsers(string UserName)
        {
            InitializeComponent();
            this.UserName = UserName;
            lblUserName.Text = UserName;
        }

        private void RefrechTable()
        {
            dgvForListUsers.DataSource = clsUsers.GetAllUsers();
        }

        private void frmShowManageUsers_Load(object sender, EventArgs e)
        {
            RefrechTable();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Length == 0)
            {
                MessageBox.Show("Pls Enter UserID");
                return;
            }

            else
            {
                int UserID = Convert.ToInt32(txtUserID.Text);
                if (EnterUser == enEnterUser.enFind)
                {
                    Form frm = new frmPrintUser(UserID);
                    frm.ShowDialog();
                }
                if (EnterUser == enEnterUser.enDelete)
                {
                    DeleteUser(UserID);
                }
                if (EnterUser == enEnterUser.enUpdate)
                {
                    UpdateUser(UserID);
                }
            }
            RefrechTable();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            Form frm = new frmUpdateAddUser(((int)clsUsers.enPermission.enAll));
            frm.ShowDialog();
            RefrechTable();
        }

        private void UpdateUser(int UserID)
        {
            if (clsUsers.CheckedUser(UserID))
            {
                Form frm = new frmUpdateAddUser(UserID);
                frm.ShowDialog();
            }
            return;
        }

        private void DeleteUser(int UserID)
        {
            clsUsers User = clsUsers.FindUserByUserID(UserID);
            if (User.UserName == UserName)
            {
                MessageBox.Show("error, you can't delete You");
                return;
            }
            if (clsUsers.DeleteUserByUserID(UserID))
            {
                MessageBox.Show("Delete UserID: " + UserID + " Successfully");
            }
            else
            {
                MessageBox.Show("UserID is not found");
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnlEnterUserID.Visible = false; 
        }

        private void OpenPanelUserID(object sender, EventArgs e)
        {
            if (((Button)sender) == btnFindUsers)
            {
                pnlEnterUserID.Visible=true;
                EnterUser = enEnterUser.enFind;
                return;
            }
            else if (((Button)sender) == btnDeleteUsers)
            {
                pnlEnterUserID.Visible = true;
                EnterUser = enEnterUser.enDelete;
            }
            else
            {
                pnlEnterUserID.Visible = true;
                EnterUser = enEnterUser.enUpdate;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

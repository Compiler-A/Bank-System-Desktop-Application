using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmUpdateAddUser : Form
    {
        private enum enMode { enUpdate, enAdd };
        private enMode Mode;

        private int _UserID = 0;
        clsUsers Users;

        public frmUpdateAddUser(int UserID)
        {
            InitializeComponent();
            this._UserID = UserID;
            if (UserID == ((int)clsUsers.enPermission.enAll))
            {
                Mode = enMode.enAdd;
            }
            else
            {
                Mode = enMode.enUpdate;
            }
        }
        private int _PermissionsSum()
        {
            int _Permission = 0;
            if (cbAll.Checked)
            {
                _CheckedAll();
                return -1;

            }
            if (cbAddUser.Checked)
            {
                _Permission += (int)(clsUsers.enPermission.enAdd);
            }
            if (cbDeleteUser.Checked)
            {
                _Permission += (int)(clsUsers.enPermission.enDelete);
            }
            if (cbUpdateUser.Checked)
            {
                _Permission += (int)(clsUsers.enPermission.enUpdate);
            }
            if (cbFindUser.Checked)
            {
                _Permission += (int)(clsUsers.enPermission.enFind);
            }
            if (cbTransaction.Checked)
            {
                _Permission += (int)(clsUsers.enPermission.enTransaction);
            }
            if (cbManageUsers.Checked)
            {
                _Permission += (int)(clsUsers.enPermission.enManageUsers);
            }
            if (cbLoginRegister.Checked)
            {
                _Permission += (int)(clsUsers.enPermission.enLoginRegister);
            }
            return _Permission;
        }
        private void _Permissions(int Permission)
        {
            if (Permission == -1)
            {
                cbAll.Checked = true;
                _CheckedAll();
                return;
            }
            if ((Permission & ((int)(clsUsers.enPermission.enAdd))) == (int)(clsUsers.enPermission.enAdd))
            {
                cbAddUser.Checked = true;
            }
            if ((Permission & ((int)(clsUsers.enPermission.enUpdate))) == ((int)(clsUsers.enPermission.enUpdate)))
            {
                cbUpdateUser.Checked = true;
            }
            if ((Permission & (int)(clsUsers.enPermission.enDelete)) == (int)(clsUsers.enPermission.enDelete))
            {
                cbDeleteUser.Checked = true;
            }
            if ((Permission & (int)(clsUsers.enPermission.enFind)) == (int)(clsUsers.enPermission.enFind))
            {
                cbFindUser.Checked = true;
            }
            if ((Permission & (int)(clsUsers.enPermission.enTransaction)) == (int)(clsUsers.enPermission.enTransaction))
            {
                cbTransaction.Checked = true;
            }
            if ((Permission & (int)(clsUsers.enPermission.enManageUsers)) == (int)(clsUsers.enPermission.enManageUsers))
            {
                cbManageUsers.Checked = true;
            }
            if ((Permission & (int)(clsUsers.enPermission.enLoginRegister)) == (int)(clsUsers.enPermission.enLoginRegister))
            {
                cbLoginRegister.Checked = true;
            }

        }

        private void _Load()
        {
            if (Mode == enMode.enAdd)
            {
                Users = new clsUsers();
                lblUserID.Text = "Add New User:";
                return;
            }

            Users = clsUsers.FindUserByUserID(_UserID);

            if (Users == null)
            {
                MessageBox.Show("This form will be closed because No User with ID = " + _UserID);
                this.Close();
                return;
            }
            lblUserID.Text = "UserID = " + Users.UserID;
            txtUserName.Text = Users.UserName;
            txtFirstName.Text = Users.FirstName;
            txtLastName.Text = Users.LastName;
            txtPassword.Text = Users.Password;
            txtEmail.Text = Users.Email;
            txtPhone.Text = Users.Phone.ToString();
            _Permissions(Users.Permission);
        }

        private void frmUpdateAddUser_Load(object sender, EventArgs e)
        {
            _Load();
        }

        bool _Checked()
        {
            if (Mode == enMode.enAdd && txtUserName.Text == clsUsers.FindUserByUserName(txtUserName.Text).UserName)
            {
                return true;
            }
            if (Mode == enMode.enUpdate && clsUsers.NotUniqueUserName(txtUserName.Text, _UserID))
            {
                return true;
            }
            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (_Checked())
            {
                MessageBox.Show("this User Name Has Repeted. pls enter an another User Name");
                return;
            }
            int UserID = clsUsers.FindUserByUserID(this._UserID).UserID;
            Users.UserName = txtUserName.Text;
            Users.FirstName = txtFirstName.Text;
            Users.LastName = txtLastName.Text;
            Users.Password = clsSetting.Encryption(txtPassword.Text);
            Users.Email = txtEmail.Text;
            Users.Phone = Convert.ToInt32(txtPhone.Text);
            Users.Permission = _PermissionsSum();

            if (Users.Save())
            {
                MessageBox.Show("Data Saved Successfully ");
            }
            else
            {
                MessageBox.Show("Error. Data is not Saved Successfully");
            }
        }

        private void _CheckedAll()
        {
            CheckBox cbBox = new CheckBox();
            if (cbAll.Checked)
            {
                cbAddUser.Checked = true;
                foreach (var item in gbPermission.Controls)
                {
                    ((CheckBox)item).Checked = true;
                    
                }
            }
            else
            {
                cbAll.Checked = false;
            }
        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            _CheckedAll();
        }
    }
}

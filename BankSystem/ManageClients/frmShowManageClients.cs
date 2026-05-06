using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmShowManageClients : Form
    {
        private enum enEnterClient { enFind = 0, enDelete = 1, enUpdate };
        private enEnterClient EnterClient = new enEnterClient();

        private clsUsers User;
        public frmShowManageClients(ref clsUsers User)
        {
            InitializeComponent();
            btnUserName.Text = User.UserName;
            this.User = User;
           
        }

        void RefrechTable()
        {
            dgvForListClients.DataSource = clsClients.GetAllClients();
        }

        private void frmShowListClients_Load(object sender, EventArgs e)
        {
            RefrechTable();
        }

        private void _FindClient()
        {
            if (clsSetting.sPermission(User.Permission, clsUsers.enPermission.enFind))
            {
                pnlForEnterClientID.Visible = true;
                EnterClient = enEnterClient.enFind;
                return;
            }
            MessageBox.Show(clsSetting.MessageErrorPermissionClients("Find Client"));
        }

        private void _UpdateClient()
        {
            if (clsSetting.sPermission(User.Permission, clsUsers.enPermission.enUpdate))
            {
                pnlForEnterClientID.Visible = true;
                EnterClient = enEnterClient.enUpdate;
                return;
            }
            MessageBox.Show(clsSetting.MessageErrorPermissionClients("Update Client"));
        }

        private void _DeleteClient()
        {
            if (clsSetting.sPermission(User.Permission, clsUsers.enPermission.enDelete))
            {
                pnlForEnterClientID.Visible = true;
                EnterClient = enEnterClient.enDelete;
                return;
            }
            MessageBox.Show(clsSetting.MessageErrorPermissionClients("Delete Client"));
        }

        private void OpenPanelClientID(object sender, EventArgs e)
        {
            if (((Button)sender) == btnFindClient)
            {
                _FindClient();
            }
            if (((Button)sender) == btnUpdateClient)
            {
                _UpdateClient();
            }

            if (((Button)sender) == btnDeleteClient)
            {
                _DeleteClient();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtClientID.Text.Length == 0)
            {
                MessageBox.Show("Pls Enter ClientID");
                return;
            }

            int ClientID = Convert.ToInt32(txtClientID.Text);
            if (EnterClient == enEnterClient.enFind)
            {
                Form frm = new frmPrintClient(ClientID);
                frm.ShowDialog();
            }
            if (EnterClient ==  enEnterClient.enDelete)
            {
                _Delete(ClientID);
            }
            if (EnterClient == enEnterClient.enUpdate)
            {
                _Update(ClientID);
            }
            RefrechTable();
        }

        private void _Update(int ID)
        {
            if (clsClients.CheckedUser(ID))
            {
                Form frm = new frmUpdateAddClient(ID);
                frm.ShowDialog();
            }
            return;
        }

        private void _Delete(int ClientID)
        {
            if (clsClients.DeleteClientByClientID(ClientID))
            {
                MessageBox.Show("Delete ClientID: " + ClientID + " Successfully");
            }
            else
            {
                MessageBox.Show("ClientID is not found");
            }
        }

        private void _AddClient()
        {
            if (clsSetting.sPermission(User.Permission, clsUsers.enPermission.enAdd))
            {
                Form frm = new frmUpdateAddClient(-1);
                frm.ShowDialog();
                RefrechTable();
                return;
            }
            MessageBox.Show(clsSetting.MessageErrorPermissionClients("Add Client"));

        }

        private void btnAddNewClients_Click(object sender, EventArgs e)
        {
            _AddClient();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlForEnterClientID.Visible = false;
        }
    }
}

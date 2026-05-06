using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmUpdateAddClient : Form
    {
        private enum enMode { enUpdate, enAdd };
        private enMode _Mode;

        private int _Client = 0;
        clsClients Client;
        public frmUpdateAddClient(int Mode)
        {
            InitializeComponent();
            this._Client = Mode;
            if (Mode == -1)
            {
                _Mode = enMode.enAdd;
            }
            else
            {
                _Mode = enMode.enUpdate;
            }
        }

        private void _Load()
        {
            if (_Mode == enMode.enAdd)
            {
                 Client = new clsClients();
                lblClientID.Text = "Add new Client:";
                return;
            }

            Client = clsClients.FindClientByClientID(_Client);
            if (Client == null)
            {
                MessageBox.Show("This form will be closed because No Client with ID = " + _Client);
                this.Close();
                return;
            }

            lblClientID.Text = "Client ID = " + Client.ClientID;
            txtClientName.Text = Client.ClientName;
            txtFirstName.Text = Client.FirstName;
            txtLastName.Text = Client.LastName;
            txtPhone.Text = Client.Phone.ToString();
            txtEmail.Text = Client.Email;
            txtPinCode.Text = (Client.PinCode);
            txtBallance.Text = Client.Ballance.ToString();

        }

        bool _Checked()
        {
            if (_Mode == enMode.enAdd && txtClientName.Text == clsClients.FindClientByClientName(txtClientName.Text).ClientName)
            {
                return true;
            }
            if (_Mode == enMode.enUpdate && clsClients.NotUniqueClientName(txtClientName.Text, _Client))
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_Checked())
            {
                MessageBox.Show("this User Name Has Repeted. pls enter an another Client Name");
                return;
            }
           
            Client.ClientName = txtClientName.Text;
            Client.FirstName = txtFirstName.Text;
            Client.LastName = txtLastName.Text;
            Client.Email = txtEmail.Text;
            Client.Phone = Convert.ToInt32(txtPhone.Text);
            Client.PinCode = clsSetting.Encryption(txtPinCode.Text);
            Client.Ballance = Convert.ToInt32(txtBallance.Text);

            if (Client.Save())
            {
                MessageBox.Show("Data Saved Successfully ");
            }
            else
            {
                MessageBox.Show("Error. Data is not Saved Successfully");
            }
        }

        private void frmUpdateAddClient_Load(object sender, EventArgs e)
        {
            _Load();
        }
    }
}

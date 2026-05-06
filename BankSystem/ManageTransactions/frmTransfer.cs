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
    public partial class frmTransfer : Form
    {
        string _UserName {  get; set; }
        float _Amount { get; set; }
        public frmTransfer(clsUsers Users)
        {
            InitializeComponent();
            _UserName = Users.UserName;
            lblUserName.Text = _UserName;
        }

        private string _InfoClient(TextBox txtClient)
        {
            clsClients Client = clsClients.FindClientByClientName(txtClient.Text);
            if (Client == null)
            {
                return "";
            }

            string stClient = "\n Client Name  : " + Client.ClientName +
                                     "\n Full Name  : " + Client.FirstName + " " + Client.LastName +
                                     "\n Email      : " + Client.Email +
                                     "\n Phone      : " + Client.Phone +
                                     "\n PinCode    : " + Client.PinCode +
                                     "\n Ballance   : " + Client.Ballance;
            return stClient;
        }

        private void txtsClientName_TextChanged(object sender, EventArgs e)
        {
            lblsClient.Text = _InfoClient((TextBox)sender);
        }

        private void txtdClientName_TextChanged(object sender, EventArgs e)
        {
            lbldClient.Text = _InfoClient((TextBox)sender);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sClient = txtsClientName.Text;
            string dClient = txtdClientName.Text;
            _Amount = Convert.ToSingle( mtxtAmount.Text);
            if (clsTranfer.AddTransfer(sClient, dClient, _Amount , _UserName))
            {
                MessageBox.Show("Transfer Completed Saccessfully");
            }
        }
    }
}

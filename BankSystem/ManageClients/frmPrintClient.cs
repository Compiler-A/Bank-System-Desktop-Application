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
    public partial class frmPrintClient : Form
    {
        private int _ClientID { get; set; }
        public frmPrintClient(int clientID)
        {
            InitializeComponent();
            _ClientID = clientID;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblInfoClient.Text);
        }

        private void frmPrintClient_Load(object sender, EventArgs e)
        {
            clsClients Client = clsClients.FindClientByClientID(_ClientID);
            if (Client == null)
            {
                return;
            }

            lblInfoClient.Text = "\n Client Name  : " + Client.ClientName +
                                     "\n Full Name  : " + Client.FirstName + " " + Client.LastName +
                                     "\n Email      : " + Client.Email +
                                     "\n Phone      : " + Client.Phone +
                                     "\n PinCode    : " + Client.PinCode +
                                     "\n Ballance   : " + Client.Ballance;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

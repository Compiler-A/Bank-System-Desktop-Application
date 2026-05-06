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
    public partial class frmShowTransaction : Form
    {
        private enum enTransaction
        {
            enDeposit,
            enWithdrow
        }
        enTransaction Transaction = new enTransaction();

        
        clsClients _Client;
        clsUsers _User;
        public frmShowTransaction(clsUsers User)
        {
            InitializeComponent();
            lblUserName.Text = User.UserName;
            _User = User;
        }


        private void _RefrechTableListTransfer()
        {
            dgvListTranfer.DataSource = clsTranfer.GetAllTransfer();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _Deposit()
        {
            if (MessageBox.Show("Are you sure do you want to Deposit Amount?", "Deposit" , MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                clsClients.ChangedBallance(txtClientName.Text, Convert.ToSingle(mtxtAmount.Text));
                return;
            }
            
        }
        private void _Withdrow()
        {
            if(Convert.ToSingle(mtxtAmount.Text) > _Client.Ballance)
            {
                MessageBox.Show("Amount > Ballance");
                return;
            }
            if (MessageBox.Show("Are you sure do you want to Withdrow Amount?", "Withdrow", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                clsClients.ChangedBallance(txtClientName.Text, -Convert.ToSingle(mtxtAmount.Text));
                return;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (mtxtAmount.Text.Length == 0 || txtClientName.Text.Length ==0)
            {
                MessageBox.Show("error, pls enter Correct Values");
                return;
            }

            string ClientName = txtClientName.Text;
            _Client = clsClients.FindClientByClientName(txtClientName.Text);
            if (_Client.ClientID == 0)
            {
                MessageBox.Show("Pls Enter an anther Client Name");
                return;
            }
            if (Transaction == enTransaction.enDeposit)
            {
                _Deposit();
            }
            if (Transaction == enTransaction.enWithdrow)
            {
                _Withdrow();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            _Client = clsClients.FindClientByClientName(txtClientName.Text);
            Form frm = new frmPrintClient(_Client.ClientID);
            frm.ShowDialog();
        }

        private void OpenPanelDW(object sender, EventArgs e)
        {
            if (((Button)sender) == btnDeposit)
            {
                Transaction = enTransaction.enDeposit;
                pnlDW.Visible = true;
                return;
            }
            if (((Button)sender) == btnWithDrow)
            {
                Transaction = enTransaction.enWithdrow;
                pnlDW.Visible = true;
                return;
            }
        }

        

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Form frm = new frmTransfer(_User);
            frm.ShowDialog();
            _RefrechTableListTransfer();
        }

        private void frmShowTransaction_Load(object sender, EventArgs e)
        {
            _RefrechTableListTransfer();
        }

        private void btnTotalBallance_Click(object sender, EventArgs e)
        {
            Form frm = new frmTotalBallance();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlDW.Visible = false;
        }
    }
}

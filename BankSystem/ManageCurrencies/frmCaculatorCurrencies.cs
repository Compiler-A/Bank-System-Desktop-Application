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
    public partial class frmCaculatorCurrencies : Form
    {
        
        public frmCaculatorCurrencies()
        {
            InitializeComponent();
        }

        private clsCurrencies _GetCurrencies(string Code)
        {
            return clsCurrencies.FindCurrencyByCode(Code);
        }

        private void btnShowFor_Click(object sender, EventArgs e)
        {
           
            Form frm = new frmPrintCurrency(_GetCurrencies(txtCodeFor.Text));
            frm.ShowDialog();

        }

        private void btnShowTo_Click(object sender, EventArgs e)
        {
            Form frm = new frmPrintCurrency(_GetCurrencies(txtCodeTo.Text));
            frm.ShowDialog();
        }

        private bool _Checked()
        {
            if (!clsCurrencies.ExistCurrencyByCode(txtCodeFor.Text))
            {
                MessageBox.Show("pls Enter an another Code [For]");
                return false;
            }
            if (!clsCurrencies.ExistCurrencyByCode(txtCodeTo.Text))
            {
                MessageBox.Show("pls Enter an another Code [To]");
                return false;
            }
            return true;

        }

        private float ConvertedTotal()
        {
            clsCurrencies Currency = clsCurrencies.FindCurrencyByCode(txtCodeFor.Text);
             return Convert.ToSingle(Currency.ConvertToOtherCurrency(Convert.ToSingle(mtxtAmountFor.Text), clsCurrencies.FindCurrencyByCode(txtCodeTo.Text)));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if (_Checked())
            {
                lblResult.Text = $"{ConvertedTotal().ToString()}";
            }
        }

        private void frmCaculatorCurrencies_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmCurrencyScreen : Form
    {
        private string _UserName;
        private clsCurrencies _Currencies;
        
        public frmCurrencyScreen(string UserName)
        {
            InitializeComponent();
            _UserName = UserName;
            lblUserName.Text = _UserName;
            rbCode.Checked = true;
        }

        private void _RefrechListCurrencies()
        {
            dgvListCurrencies.DataSource = clsCurrencies.GetAllCurrencies();
        }





        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCurrencyScreen_Load(object sender, EventArgs e)
        {
            _RefrechListCurrencies();
        }

        private void btHide_Click(object sender, EventArgs e)
        {
            pnlDW.Visible = false;
        }

        private void pnlEntered(object sender, EventArgs e)
        {
            if (((Button)sender) == btnFindCurrency)
            {
                pnlDW.Visible = true;
                pnlUpdatePrice.Visible = false;
                rbCountryName.Enabled = true;
                return;
            }
            if (((Button)sender) == btnUpdateCurrency)
            {
                pnlDW.Visible = true;
                pnlUpdatePrice.Visible = true;
                rbCountryName.Enabled = false;
                return;
            }
        }

        private void _ByCountryName()
        {
            _Currencies = clsCurrencies.FindCurrencyByCountryName(txtCodeOrCountry.Text);
        }
        private void _ByCode()
        {
            _Currencies = clsCurrencies.FindCurrencyByCode(txtCodeOrCountry.Text);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (rbCountryName.Checked)
            {
                _ByCountryName();
            }
            else
            {
                _ByCode();
            }

            Form frm = new frmPrintCurrency(_Currencies);
            frm.ShowDialog();
            
        }

        private bool _UpdateRateForCurrencyByCode()
        {
            if (clsCurrencies.ExistCurrencyByCode(txtCodeOrCountry.Text))
            {
                return clsCurrencies.UpdateCurrencyByCode(txtCodeOrCountry.Text, Convert.ToDouble(mtxtRate.Text));
            }
            return false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _ByCode();
            if (_UpdateRateForCurrencyByCode())
            {
                MessageBox.Show($"Update Rate for Code: {txtCodeOrCountry.Text}. old({_Currencies.Rate.ToString()}) , new({mtxtRate.Text})");
                return;
            }
            MessageBox.Show("error. pls Enter an another Code");
        }

        private void btnTotalCurrencies_Click(object sender, EventArgs e)
        {
            Form frm = new frmTotalCurrencies();
            frm.ShowDialog();
        }

        private void btnCalculateCurrency_Click(object sender, EventArgs e)
        {
            Form frm = new frmCaculatorCurrencies();
            frm.ShowDialog();
        }
    }
}

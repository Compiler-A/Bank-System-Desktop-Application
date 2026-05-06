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
    public partial class frmTotalCurrencies : Form
    {
        
        public frmTotalCurrencies()
        {
            InitializeComponent();
            int TCurrncies = clsCurrencies.GetTotalCurrencies();
            lblTotalCurrenciesNumber.Text = TCurrncies.ToString();
            lblTotalCurrenciesText.Text = clsSetting.NumberToText(TCurrncies);
        }

        private void frmTotalCurrencies_Load(object sender, EventArgs e)
        {
            dgvForAllCurrencies.DataSource = clsCurrencies.GetAllCurrencies();
        }
    }
}

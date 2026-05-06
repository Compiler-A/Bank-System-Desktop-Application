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
    public partial class frmPrintCurrency : Form
    {
        clsCurrencies _Currency;
        public frmPrintCurrency(clsCurrencies Currency)
        {
            InitializeComponent();
            _Currency = Currency;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblInfoCurrency.Text);
        }

        private void frmPrintCurrency_Load(object sender, EventArgs e)
        {
            if (_Currency == null)
            {
                return;
            }

            lblInfoCurrency.Text = "\n Country Name  : " + _Currency.Country +
                                     "\n Code       : " + _Currency.Code +
                                     "\n Name       : " + _Currency.Name +
                                     "\n Rate       : " + _Currency.Rate.ToString();
        }
    }
}

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
    public partial class frmTotalBallance : Form
    {
        public frmTotalBallance()
        {
            InitializeComponent();
            float Tballance = clsClients.GetTotalBallance();
            dgvListClient.DataSource = clsClients.GetAllClients();
            lblTotalBallanceNumber.Text = Tballance.ToString();
            lblTotalBallanceText.Text = clsSetting.NumberToText(Convert.ToInt32(Tballance));
        }

       
    }
}

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
    public partial class frmLoginRegisterScreen : Form
    {
        public frmLoginRegisterScreen()
        {
            InitializeComponent();
        }

        private void frmLoginRegisterScreen_Load(object sender, EventArgs e)
        {
            dgvForLoginRegister.DataSource = clsUsers.GetAllLoginRegister();
        }
    }
}

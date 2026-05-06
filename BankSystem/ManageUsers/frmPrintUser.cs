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
using System.Xml.Linq;

namespace BankSystem
{
    public partial class frmPrintUser : Form
    {
        private int UserID;
        public frmPrintUser(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowUser_Load(object sender, EventArgs e)
        {
            clsUsers User = clsUsers.FindUserByUserID(UserID);
            if (User == null)
            {
                return;
            }

            lblShowResultUser.Text = "\n User Name  : " + User.UserName +
                                     "\n Full Name  : " + User.FirstName + " " + User.LastName +
                                     "\n Email      : " + User.Email +
                                     "\n Phone      : " + User.Phone +
                                     "\n Password   : " + User.Password +
                                     "\n Permission : " + User.Permission;

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblShowResultUser.Text);
            
        }
    }
}

namespace BankSystem
{
    partial class frmShowManageUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindUsers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.btnUpdateUsers = new System.Windows.Forms.Button();
            this.btnForAllitems = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.pnlEnterUserID = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvForListUsers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnForAllitems.SuspendLayout();
            this.pnlEnterUserID.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForListUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(890, 58);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFindUsers
            // 
            this.btnFindUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFindUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnFindUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFindUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindUsers.Location = new System.Drawing.Point(164, 6);
            this.btnFindUsers.Name = "btnFindUsers";
            this.btnFindUsers.Size = new System.Drawing.Size(154, 47);
            this.btnFindUsers.TabIndex = 2;
            this.btnFindUsers.Text = "Find User";
            this.btnFindUsers.UseVisualStyleBackColor = false;
            this.btnFindUsers.Click += new System.EventHandler(this.OpenPanelUserID);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(4, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 47);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAddUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsers.Location = new System.Drawing.Point(4, 6);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(154, 47);
            this.btnAddUsers.TabIndex = 1;
            this.btnAddUsers.Text = "Add User";
            this.btnAddUsers.UseVisualStyleBackColor = false;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDeleteUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUsers.Location = new System.Drawing.Point(164, 59);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(154, 47);
            this.btnDeleteUsers.TabIndex = 4;
            this.btnDeleteUsers.Text = "Delete User";
            this.btnDeleteUsers.UseVisualStyleBackColor = false;
            this.btnDeleteUsers.Click += new System.EventHandler(this.OpenPanelUserID);
            // 
            // btnUpdateUsers
            // 
            this.btnUpdateUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUpdateUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdateUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUsers.Location = new System.Drawing.Point(4, 59);
            this.btnUpdateUsers.Name = "btnUpdateUsers";
            this.btnUpdateUsers.Size = new System.Drawing.Size(154, 47);
            this.btnUpdateUsers.TabIndex = 3;
            this.btnUpdateUsers.Text = "Update User";
            this.btnUpdateUsers.UseVisualStyleBackColor = false;
            this.btnUpdateUsers.Click += new System.EventHandler(this.OpenPanelUserID);
            // 
            // btnForAllitems
            // 
            this.btnForAllitems.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnForAllitems.Controls.Add(this.btnFindUsers);
            this.btnForAllitems.Controls.Add(this.button2);
            this.btnForAllitems.Controls.Add(this.btnAddUsers);
            this.btnForAllitems.Controls.Add(this.btnDeleteUsers);
            this.btnForAllitems.Controls.Add(this.btnUpdateUsers);
            this.btnForAllitems.Location = new System.Drawing.Point(12, 61);
            this.btnForAllitems.Name = "btnForAllitems";
            this.btnForAllitems.Size = new System.Drawing.Size(321, 167);
            this.btnForAllitems.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(170, 35);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pls Enter UsersID:";
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(7, 40);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(157, 28);
            this.txtUserID.TabIndex = 5;
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlEnterUserID
            // 
            this.pnlEnterUserID.Controls.Add(this.btnHide);
            this.pnlEnterUserID.Controls.Add(this.btnOK);
            this.pnlEnterUserID.Controls.Add(this.label2);
            this.pnlEnterUserID.Controls.Add(this.txtUserID);
            this.pnlEnterUserID.Location = new System.Drawing.Point(339, 67);
            this.pnlEnterUserID.Name = "pnlEnterUserID";
            this.pnlEnterUserID.Size = new System.Drawing.Size(265, 73);
            this.pnlEnterUserID.TabIndex = 13;
            this.pnlEnterUserID.Visible = false;
            // 
            // btnHide
            // 
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.Location = new System.Drawing.Point(211, 3);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(51, 30);
            this.btnHide.TabIndex = 12;
            this.btnHide.Text = "hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(73, 6);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(105, 25);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "User: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(656, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 39);
            this.panel2.TabIndex = 11;
            // 
            // dgvForListUsers
            // 
            this.dgvForListUsers.AllowUserToAddRows = false;
            this.dgvForListUsers.AllowUserToDeleteRows = false;
            this.dgvForListUsers.AllowUserToOrderColumns = true;
            this.dgvForListUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvForListUsers.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvForListUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvForListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForListUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvForListUsers.Location = new System.Drawing.Point(0, 263);
            this.dgvForListUsers.Name = "dgvForListUsers";
            this.dgvForListUsers.ReadOnly = true;
            this.dgvForListUsers.RowHeadersWidth = 51;
            this.dgvForListUsers.RowTemplate.Height = 24;
            this.dgvForListUsers.Size = new System.Drawing.Size(890, 249);
            this.dgvForListUsers.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(803, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmShowManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(890, 512);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvForListUsers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEnterUserID);
            this.Controls.Add(this.btnForAllitems);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmShowManageUsers";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmShowManageUsers_Load);
            this.btnForAllitems.ResumeLayout(false);
            this.pnlEnterUserID.ResumeLayout(false);
            this.pnlEnterUserID.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForListUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindUsers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Button btnDeleteUsers;
        private System.Windows.Forms.Button btnUpdateUsers;
        private System.Windows.Forms.Panel btnForAllitems;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Panel pnlEnterUserID;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvForListUsers;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button button1;
    }
}
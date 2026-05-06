namespace BankSystem
{
    partial class frmShowManageClients
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
            this.dgvForListClients = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewClients = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.pnlForAllitems = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUserName = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlForEnterClientID = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForListClients)).BeginInit();
            this.pnlForAllitems.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlForEnterClientID.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvForListClients
            // 
            this.dgvForListClients.AllowUserToAddRows = false;
            this.dgvForListClients.AllowUserToDeleteRows = false;
            this.dgvForListClients.AllowUserToOrderColumns = true;
            this.dgvForListClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvForListClients.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvForListClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvForListClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForListClients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvForListClients.Location = new System.Drawing.Point(0, 263);
            this.dgvForListClients.Name = "dgvForListClients";
            this.dgvForListClients.ReadOnly = true;
            this.dgvForListClients.RowHeadersWidth = 51;
            this.dgvForListClients.RowTemplate.Height = 24;
            this.dgvForListClients.Size = new System.Drawing.Size(890, 249);
            this.dgvForListClients.TabIndex = 7;
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
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Clients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddNewClients
            // 
            this.btnAddNewClients.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAddNewClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddNewClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewClients.Location = new System.Drawing.Point(4, 6);
            this.btnAddNewClients.Name = "btnAddNewClients";
            this.btnAddNewClients.Size = new System.Drawing.Size(154, 47);
            this.btnAddNewClients.TabIndex = 1;
            this.btnAddNewClients.Text = "Add Client";
            this.btnAddNewClients.UseVisualStyleBackColor = false;
            this.btnAddNewClients.Click += new System.EventHandler(this.btnAddNewClients_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUpdateClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.Location = new System.Drawing.Point(4, 59);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(154, 47);
            this.btnUpdateClient.TabIndex = 3;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.OpenPanelClientID);
            // 
            // btnFindClient
            // 
            this.btnFindClient.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFindClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnFindClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFindClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.Location = new System.Drawing.Point(164, 6);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(154, 47);
            this.btnFindClient.TabIndex = 2;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.UseVisualStyleBackColor = false;
            this.btnFindClient.Click += new System.EventHandler(this.OpenPanelClientID);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDeleteClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.Location = new System.Drawing.Point(164, 59);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(154, 47);
            this.btnDeleteClient.TabIndex = 4;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.OpenPanelClientID);
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefreshData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRefreshData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRefreshData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshData.Location = new System.Drawing.Point(4, 112);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(154, 47);
            this.btnRefreshData.TabIndex = 7;
            this.btnRefreshData.UseVisualStyleBackColor = false;
            // 
            // pnlForAllitems
            // 
            this.pnlForAllitems.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlForAllitems.Controls.Add(this.btnFindClient);
            this.pnlForAllitems.Controls.Add(this.btnRefreshData);
            this.pnlForAllitems.Controls.Add(this.btnAddNewClients);
            this.pnlForAllitems.Controls.Add(this.btnDeleteClient);
            this.pnlForAllitems.Controls.Add(this.btnUpdateClient);
            this.pnlForAllitems.Location = new System.Drawing.Point(12, 61);
            this.pnlForAllitems.Name = "pnlForAllitems";
            this.pnlForAllitems.Size = new System.Drawing.Size(321, 167);
            this.pnlForAllitems.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "User: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(656, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 39);
            this.panel1.TabIndex = 10;
            // 
            // btnUserName
            // 
            this.btnUserName.AutoSize = true;
            this.btnUserName.BackColor = System.Drawing.Color.Transparent;
            this.btnUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserName.ForeColor = System.Drawing.Color.White;
            this.btnUserName.Location = new System.Drawing.Point(73, 6);
            this.btnUserName.Name = "btnUserName";
            this.btnUserName.Size = new System.Drawing.Size(105, 25);
            this.btnUserName.TabIndex = 10;
            this.btnUserName.Text = "UserName";
            // 
            // txtClientID
            // 
            this.txtClientID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtClientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.Location = new System.Drawing.Point(7, 40);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(157, 28);
            this.txtClientID.TabIndex = 5;
            this.txtClientID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pls Enter ClientID:";
            // 
            // pnlForEnterClientID
            // 
            this.pnlForEnterClientID.Controls.Add(this.button1);
            this.pnlForEnterClientID.Controls.Add(this.btnOK);
            this.pnlForEnterClientID.Controls.Add(this.label3);
            this.pnlForEnterClientID.Controls.Add(this.txtClientID);
            this.pnlForEnterClientID.Location = new System.Drawing.Point(339, 67);
            this.pnlForEnterClientID.Name = "pnlForEnterClientID";
            this.pnlForEnterClientID.Size = new System.Drawing.Size(265, 73);
            this.pnlForEnterClientID.TabIndex = 12;
            this.pnlForEnterClientID.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(210, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "hide";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(803, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 15;
            this.button2.Text = "close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmShowManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(890, 512);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnlForEnterClientID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlForAllitems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvForListClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmShowManageClients";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Clients";
            this.Load += new System.EventHandler(this.frmShowListClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForListClients)).EndInit();
            this.pnlForAllitems.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlForEnterClientID.ResumeLayout(false);
            this.pnlForEnterClientID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvForListClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewClients;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnRefreshData;
        private System.Windows.Forms.Panel pnlForAllitems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnUserName;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlForEnterClientID;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
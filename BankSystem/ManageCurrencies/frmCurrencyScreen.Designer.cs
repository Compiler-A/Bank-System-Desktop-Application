namespace BankSystem
{
    partial class frmCurrencyScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTotalCurrencies = new System.Windows.Forms.Button();
            this.btnCalculateCurrency = new System.Windows.Forms.Button();
            this.btnUpdateCurrency = new System.Windows.Forms.Button();
            this.btnFindCurrency = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlDW = new System.Windows.Forms.Panel();
            this.pnlUpdatePrice = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtRate = new System.Windows.Forms.MaskedTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.rbCountryName = new System.Windows.Forms.RadioButton();
            this.rbCode = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtCodeOrCountry = new System.Windows.Forms.TextBox();
            this.btHide = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListCurrencies = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlDW.SuspendLayout();
            this.pnlUpdatePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCurrencies)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(890, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currency Exchange";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "User: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(656, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 39);
            this.panel2.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(803, 123);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 27);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTotalCurrencies
            // 
            this.btnTotalCurrencies.BackColor = System.Drawing.Color.White;
            this.btnTotalCurrencies.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTotalCurrencies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnTotalCurrencies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTotalCurrencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalCurrencies.Location = new System.Drawing.Point(3, 162);
            this.btnTotalCurrencies.Name = "btnTotalCurrencies";
            this.btnTotalCurrencies.Size = new System.Drawing.Size(211, 47);
            this.btnTotalCurrencies.TabIndex = 6;
            this.btnTotalCurrencies.Text = "Tatal Currencies";
            this.btnTotalCurrencies.UseVisualStyleBackColor = false;
            this.btnTotalCurrencies.Click += new System.EventHandler(this.btnTotalCurrencies_Click);
            // 
            // btnCalculateCurrency
            // 
            this.btnCalculateCurrency.BackColor = System.Drawing.Color.White;
            this.btnCalculateCurrency.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCalculateCurrency.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCalculateCurrency.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCalculateCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateCurrency.Location = new System.Drawing.Point(3, 109);
            this.btnCalculateCurrency.Name = "btnCalculateCurrency";
            this.btnCalculateCurrency.Size = new System.Drawing.Size(211, 47);
            this.btnCalculateCurrency.TabIndex = 5;
            this.btnCalculateCurrency.Text = "Calculator Currency";
            this.btnCalculateCurrency.UseVisualStyleBackColor = false;
            this.btnCalculateCurrency.Click += new System.EventHandler(this.btnCalculateCurrency_Click);
            // 
            // btnUpdateCurrency
            // 
            this.btnUpdateCurrency.BackColor = System.Drawing.Color.White;
            this.btnUpdateCurrency.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateCurrency.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUpdateCurrency.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdateCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCurrency.Location = new System.Drawing.Point(3, 56);
            this.btnUpdateCurrency.Name = "btnUpdateCurrency";
            this.btnUpdateCurrency.Size = new System.Drawing.Size(211, 47);
            this.btnUpdateCurrency.TabIndex = 4;
            this.btnUpdateCurrency.Text = "Update Currency";
            this.btnUpdateCurrency.UseVisualStyleBackColor = false;
            this.btnUpdateCurrency.Click += new System.EventHandler(this.pnlEntered);
            // 
            // btnFindCurrency
            // 
            this.btnFindCurrency.BackColor = System.Drawing.Color.White;
            this.btnFindCurrency.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFindCurrency.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnFindCurrency.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFindCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCurrency.Location = new System.Drawing.Point(3, 3);
            this.btnFindCurrency.Name = "btnFindCurrency";
            this.btnFindCurrency.Size = new System.Drawing.Size(211, 47);
            this.btnFindCurrency.TabIndex = 3;
            this.btnFindCurrency.Text = "Find Currency";
            this.btnFindCurrency.UseVisualStyleBackColor = false;
            this.btnFindCurrency.Click += new System.EventHandler(this.pnlEntered);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.btnTotalCurrencies);
            this.panel3.Controls.Add(this.btnCalculateCurrency);
            this.panel3.Controls.Add(this.btnUpdateCurrency);
            this.panel3.Controls.Add(this.btnFindCurrency);
            this.panel3.Location = new System.Drawing.Point(12, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 216);
            this.panel3.TabIndex = 7;
            // 
            // pnlDW
            // 
            this.pnlDW.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlDW.Controls.Add(this.pnlUpdatePrice);
            this.pnlDW.Controls.Add(this.rbCountryName);
            this.pnlDW.Controls.Add(this.rbCode);
            this.pnlDW.Controls.Add(this.btnShow);
            this.pnlDW.Controls.Add(this.txtCodeOrCountry);
            this.pnlDW.Controls.Add(this.btHide);
            this.pnlDW.Controls.Add(this.label4);
            this.pnlDW.Location = new System.Drawing.Point(235, 88);
            this.pnlDW.Name = "pnlDW";
            this.pnlDW.Size = new System.Drawing.Size(415, 206);
            this.pnlDW.TabIndex = 18;
            this.pnlDW.Visible = false;
            // 
            // pnlUpdatePrice
            // 
            this.pnlUpdatePrice.Controls.Add(this.label2);
            this.pnlUpdatePrice.Controls.Add(this.mtxtRate);
            this.pnlUpdatePrice.Controls.Add(this.btnOK);
            this.pnlUpdatePrice.Location = new System.Drawing.Point(0, 113);
            this.pnlUpdatePrice.Name = "pnlUpdatePrice";
            this.pnlUpdatePrice.Size = new System.Drawing.Size(415, 100);
            this.pnlUpdatePrice.TabIndex = 19;
            this.pnlUpdatePrice.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Rate:";
            // 
            // mtxtRate
            // 
            this.mtxtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtRate.Location = new System.Drawing.Point(8, 46);
            this.mtxtRate.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.mtxtRate.Name = "mtxtRate";
            this.mtxtRate.Size = new System.Drawing.Size(231, 27);
            this.mtxtRate.TabIndex = 2;
            this.mtxtRate.ValidatingType = typeof(int);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(327, 58);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 32);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rbCountryName
            // 
            this.rbCountryName.AutoSize = true;
            this.rbCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCountryName.Location = new System.Drawing.Point(153, 16);
            this.rbCountryName.Name = "rbCountryName";
            this.rbCountryName.Size = new System.Drawing.Size(164, 24);
            this.rbCountryName.TabIndex = 21;
            this.rbCountryName.TabStop = true;
            this.rbCountryName.Text = "COUNTRY NAME";
            this.rbCountryName.UseVisualStyleBackColor = true;
            // 
            // rbCode
            // 
            this.rbCode.AutoSize = true;
            this.rbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCode.Location = new System.Drawing.Point(8, 16);
            this.rbCode.Name = "rbCode";
            this.rbCode.Size = new System.Drawing.Size(79, 24);
            this.rbCode.TabIndex = 20;
            this.rbCode.TabStop = true;
            this.rbCode.Text = "CODE";
            this.rbCode.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(245, 81);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(72, 27);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtCodeOrCountry
            // 
            this.txtCodeOrCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeOrCountry.Location = new System.Drawing.Point(8, 81);
            this.txtCodeOrCountry.Name = "txtCodeOrCountry";
            this.txtCodeOrCountry.Size = new System.Drawing.Size(231, 27);
            this.txtCodeOrCountry.TabIndex = 3;
            // 
            // btHide
            // 
            this.btHide.BackColor = System.Drawing.Color.White;
            this.btHide.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHide.Location = new System.Drawing.Point(349, 4);
            this.btHide.Name = "btHide";
            this.btHide.Size = new System.Drawing.Size(63, 32);
            this.btHide.TabIndex = 1;
            this.btHide.Text = "Hide";
            this.btHide.UseVisualStyleBackColor = false;
            this.btHide.Click += new System.EventHandler(this.btHide_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter ";
            // 
            // dgvListCurrencies
            // 
            this.dgvListCurrencies.AllowUserToAddRows = false;
            this.dgvListCurrencies.AllowUserToDeleteRows = false;
            this.dgvListCurrencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCurrencies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListCurrencies.Location = new System.Drawing.Point(0, 307);
            this.dgvListCurrencies.Name = "dgvListCurrencies";
            this.dgvListCurrencies.ReadOnly = true;
            this.dgvListCurrencies.RowHeadersWidth = 51;
            this.dgvListCurrencies.RowTemplate.Height = 24;
            this.dgvListCurrencies.Size = new System.Drawing.Size(890, 205);
            this.dgvListCurrencies.TabIndex = 19;
            // 
            // frmCurrencyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(890, 512);
            this.ControlBox = false;
            this.Controls.Add(this.dgvListCurrencies);
            this.Controls.Add(this.pnlDW);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmCurrencyScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Screen";
            this.Load += new System.EventHandler(this.frmCurrencyScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlDW.ResumeLayout(false);
            this.pnlDW.PerformLayout();
            this.pnlUpdatePrice.ResumeLayout(false);
            this.pnlUpdatePrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCurrencies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTotalCurrencies;
        private System.Windows.Forms.Button btnCalculateCurrency;
        private System.Windows.Forms.Button btnUpdateCurrency;
        private System.Windows.Forms.Button btnFindCurrency;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlDW;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtCodeOrCountry;
        private System.Windows.Forms.MaskedTextBox mtxtRate;
        private System.Windows.Forms.Button btHide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlUpdatePrice;
        private System.Windows.Forms.RadioButton rbCountryName;
        private System.Windows.Forms.RadioButton rbCode;
        private System.Windows.Forms.DataGridView dgvListCurrencies;
    }
}
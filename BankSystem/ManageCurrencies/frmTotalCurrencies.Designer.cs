namespace BankSystem
{
    partial class frmTotalCurrencies
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
            this.dgvForAllCurrencies = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCurrenciesNumber = new System.Windows.Forms.Label();
            this.lblTotalCurrenciesText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForAllCurrencies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvForAllCurrencies
            // 
            this.dgvForAllCurrencies.AllowUserToAddRows = false;
            this.dgvForAllCurrencies.AllowUserToDeleteRows = false;
            this.dgvForAllCurrencies.AllowUserToOrderColumns = true;
            this.dgvForAllCurrencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvForAllCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForAllCurrencies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvForAllCurrencies.Location = new System.Drawing.Point(0, 160);
            this.dgvForAllCurrencies.Name = "dgvForAllCurrencies";
            this.dgvForAllCurrencies.ReadOnly = true;
            this.dgvForAllCurrencies.RowHeadersWidth = 51;
            this.dgvForAllCurrencies.RowTemplate.Height = 24;
            this.dgvForAllCurrencies.Size = new System.Drawing.Size(800, 290);
            this.dgvForAllCurrencies.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Currencies:";
            // 
            // lblTotalCurrenciesNumber
            // 
            this.lblTotalCurrenciesNumber.AutoSize = true;
            this.lblTotalCurrenciesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCurrenciesNumber.Location = new System.Drawing.Point(15, 69);
            this.lblTotalCurrenciesNumber.Name = "lblTotalCurrenciesNumber";
            this.lblTotalCurrenciesNumber.Size = new System.Drawing.Size(79, 29);
            this.lblTotalCurrenciesNumber.TabIndex = 2;
            this.lblTotalCurrenciesNumber.Text = "label2";
            // 
            // lblTotalCurrenciesText
            // 
            this.lblTotalCurrenciesText.AutoSize = true;
            this.lblTotalCurrenciesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCurrenciesText.Location = new System.Drawing.Point(15, 113);
            this.lblTotalCurrenciesText.Name = "lblTotalCurrenciesText";
            this.lblTotalCurrenciesText.Size = new System.Drawing.Size(79, 29);
            this.lblTotalCurrenciesText.TabIndex = 3;
            this.lblTotalCurrenciesText.Text = "label2";
            // 
            // frmTotalCurrencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalCurrenciesText);
            this.Controls.Add(this.lblTotalCurrenciesNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvForAllCurrencies);
            this.Name = "frmTotalCurrencies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Currencies";
            this.Load += new System.EventHandler(this.frmTotalCurrencies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForAllCurrencies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvForAllCurrencies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCurrenciesNumber;
        private System.Windows.Forms.Label lblTotalCurrenciesText;
    }
}
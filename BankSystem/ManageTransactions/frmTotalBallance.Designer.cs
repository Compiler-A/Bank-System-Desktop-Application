namespace BankSystem
{
    partial class frmTotalBallance
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
            this.dgvListClient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalBallanceNumber = new System.Windows.Forms.Label();
            this.lblTotalBallanceText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListClient
            // 
            this.dgvListClient.AllowUserToAddRows = false;
            this.dgvListClient.AllowUserToDeleteRows = false;
            this.dgvListClient.AllowUserToOrderColumns = true;
            this.dgvListClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListClient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListClient.Location = new System.Drawing.Point(0, 118);
            this.dgvListClient.Name = "dgvListClient";
            this.dgvListClient.ReadOnly = true;
            this.dgvListClient.RowHeadersWidth = 51;
            this.dgvListClient.RowTemplate.Height = 24;
            this.dgvListClient.Size = new System.Drawing.Size(800, 332);
            this.dgvListClient.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Ballance:";
            // 
            // lblTotalBallanceNumber
            // 
            this.lblTotalBallanceNumber.AutoSize = true;
            this.lblTotalBallanceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBallanceNumber.Location = new System.Drawing.Point(237, 47);
            this.lblTotalBallanceNumber.Name = "lblTotalBallanceNumber";
            this.lblTotalBallanceNumber.Size = new System.Drawing.Size(104, 29);
            this.lblTotalBallanceNumber.TabIndex = 2;
            this.lblTotalBallanceNumber.Text = "ballance";
            // 
            // lblTotalBallanceText
            // 
            this.lblTotalBallanceText.AutoSize = true;
            this.lblTotalBallanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBallanceText.Location = new System.Drawing.Point(238, 85);
            this.lblTotalBallanceText.Name = "lblTotalBallanceText";
            this.lblTotalBallanceText.Size = new System.Drawing.Size(45, 20);
            this.lblTotalBallanceText.TabIndex = 3;
            this.lblTotalBallanceText.Text = "Text";
            // 
            // frmTotalBallance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalBallanceText);
            this.Controls.Add(this.lblTotalBallanceNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListClient);
            this.Name = "frmTotalBallance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Ballance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalBallanceNumber;
        private System.Windows.Forms.Label lblTotalBallanceText;
    }
}
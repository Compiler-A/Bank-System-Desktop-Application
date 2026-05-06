namespace BankSystem
{
    partial class frmLoginRegisterScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvForLoginRegister = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForLoginRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvForLoginRegister
            // 
            this.dgvForLoginRegister.AllowUserToAddRows = false;
            this.dgvForLoginRegister.AllowUserToDeleteRows = false;
            this.dgvForLoginRegister.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvForLoginRegister.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvForLoginRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvForLoginRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForLoginRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvForLoginRegister.Location = new System.Drawing.Point(0, 131);
            this.dgvForLoginRegister.Name = "dgvForLoginRegister";
            this.dgvForLoginRegister.ReadOnly = true;
            this.dgvForLoginRegister.RowHeadersWidth = 51;
            this.dgvForLoginRegister.RowTemplate.Height = 24;
            this.dgvForLoginRegister.Size = new System.Drawing.Size(800, 319);
            this.dgvForLoginRegister.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Register";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLoginRegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvForLoginRegister);
            this.Name = "frmLoginRegisterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Register Screen";
            this.Load += new System.EventHandler(this.frmLoginRegisterScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForLoginRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvForLoginRegister;
        private System.Windows.Forms.Label label1;
    }
}
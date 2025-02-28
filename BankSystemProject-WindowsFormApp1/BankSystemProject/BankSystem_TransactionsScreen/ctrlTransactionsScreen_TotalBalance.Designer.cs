namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_TransactionsScreen
{
    partial class ctrlTransactionsScreen_TotalBalance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTotalBalance = new System.Windows.Forms.DataGridView();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTotalBalance
            // 
            this.dgvTotalBalance.AllowUserToAddRows = false;
            this.dgvTotalBalance.AllowUserToDeleteRows = false;
            this.dgvTotalBalance.AllowUserToOrderColumns = true;
            this.dgvTotalBalance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTotalBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalBalance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTotalBalance.Location = new System.Drawing.Point(0, 80);
            this.dgvTotalBalance.Name = "dgvTotalBalance";
            this.dgvTotalBalance.ReadOnly = true;
            this.dgvTotalBalance.RowHeadersWidth = 51;
            this.dgvTotalBalance.RowTemplate.Height = 24;
            this.dgvTotalBalance.Size = new System.Drawing.Size(897, 510);
            this.dgvTotalBalance.TabIndex = 0;
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBalance.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalBalance.Location = new System.Drawing.Point(476, 21);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(74, 32);
            this.lblTotalBalance.TabIndex = 7;
            this.lblTotalBalance.Text = "[????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Balance :";
            // 
            // ctrlTransactionsScreen_TotalBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.lblTotalBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTotalBalance);
            this.Name = "ctrlTransactionsScreen_TotalBalance";
            this.Size = new System.Drawing.Size(897, 590);
            this.Load += new System.EventHandler(this.ctrlTransactionsScreen_TotalBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTotalBalance;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label label2;
    }
}

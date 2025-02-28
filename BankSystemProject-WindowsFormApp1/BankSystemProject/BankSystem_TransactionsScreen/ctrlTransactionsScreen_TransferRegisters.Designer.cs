namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_TransactionsScreen
{
    partial class ctrlTransactionsScreen_TransferRegisters
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
            this.dgvTransferRegisters = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferRegisters)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransferRegisters
            // 
            this.dgvTransferRegisters.AllowUserToAddRows = false;
            this.dgvTransferRegisters.AllowUserToDeleteRows = false;
            this.dgvTransferRegisters.AllowUserToOrderColumns = true;
            this.dgvTransferRegisters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTransferRegisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferRegisters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransferRegisters.Location = new System.Drawing.Point(0, 0);
            this.dgvTransferRegisters.Name = "dgvTransferRegisters";
            this.dgvTransferRegisters.ReadOnly = true;
            this.dgvTransferRegisters.RowHeadersWidth = 51;
            this.dgvTransferRegisters.RowTemplate.Height = 24;
            this.dgvTransferRegisters.Size = new System.Drawing.Size(897, 590);
            this.dgvTransferRegisters.TabIndex = 0;
            this.dgvTransferRegisters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransferRegisters_CellContentClick);
            // 
            // ctrlTransactionsScreen_TransferRegisters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.dgvTransferRegisters);
            this.Name = "ctrlTransactionsScreen_TransferRegisters";
            this.Size = new System.Drawing.Size(897, 590);
            this.Load += new System.EventHandler(this.ctrlTransactionsScreen_TransferRegisters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferRegisters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransferRegisters;
    }
}

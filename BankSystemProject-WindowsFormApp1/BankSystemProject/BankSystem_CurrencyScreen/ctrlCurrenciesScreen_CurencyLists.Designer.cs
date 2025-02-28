namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_CurrencyScreen
{
    partial class ctrlCurrenciesScreen_CurencyLists
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
            this.dgvCurrencyLists = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencyLists)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCurrencyLists
            // 
            this.dgvCurrencyLists.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCurrencyLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrencyLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrencyLists.Location = new System.Drawing.Point(0, 0);
            this.dgvCurrencyLists.Name = "dgvCurrencyLists";
            this.dgvCurrencyLists.RowHeadersWidth = 51;
            this.dgvCurrencyLists.RowTemplate.Height = 24;
            this.dgvCurrencyLists.Size = new System.Drawing.Size(897, 590);
            this.dgvCurrencyLists.TabIndex = 0;
            // 
            // ctrlCurrenciesScreen_CurencyLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.dgvCurrencyLists);
            this.Name = "ctrlCurrenciesScreen_CurencyLists";
            this.Size = new System.Drawing.Size(897, 590);
            this.Load += new System.EventHandler(this.ctrlCurrenciesScreen_CurencyLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencyLists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCurrencyLists;
    }
}

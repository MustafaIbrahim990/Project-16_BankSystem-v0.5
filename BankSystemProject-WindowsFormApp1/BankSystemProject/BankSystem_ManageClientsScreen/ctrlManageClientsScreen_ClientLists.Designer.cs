namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_ManageClientsScreen
{
    partial class ctrlManageClientsScreen_ClientLists
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
            this.dgvClientLists = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientLists)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientLists
            // 
            this.dgvClientLists.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvClientLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientLists.Location = new System.Drawing.Point(0, 0);
            this.dgvClientLists.Name = "dgvClientLists";
            this.dgvClientLists.RowHeadersWidth = 51;
            this.dgvClientLists.RowTemplate.Height = 24;
            this.dgvClientLists.Size = new System.Drawing.Size(897, 590);
            this.dgvClientLists.TabIndex = 0;
            this.dgvClientLists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientLists_CellContentClick);
            // 
            // ctrlManageClientsScreen_ClientLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.dgvClientLists);
            this.Name = "ctrlManageClientsScreen_ClientLists";
            this.Size = new System.Drawing.Size(897, 590);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientLists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientLists;
    }
}

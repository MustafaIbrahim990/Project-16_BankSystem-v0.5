namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_ManageUsersScreen
{
    partial class ctrlManageUsersScreen_UserLists
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
            this.dgvUserLists = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLists)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserLists
            // 
            this.dgvUserLists.AllowUserToAddRows = false;
            this.dgvUserLists.AllowUserToDeleteRows = false;
            this.dgvUserLists.AllowUserToOrderColumns = true;
            this.dgvUserLists.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUserLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserLists.GridColor = System.Drawing.Color.Gray;
            this.dgvUserLists.Location = new System.Drawing.Point(0, 0);
            this.dgvUserLists.Name = "dgvUserLists";
            this.dgvUserLists.ReadOnly = true;
            this.dgvUserLists.RowHeadersWidth = 51;
            this.dgvUserLists.RowTemplate.Height = 24;
            this.dgvUserLists.Size = new System.Drawing.Size(897, 590);
            this.dgvUserLists.TabIndex = 0;
            // 
            // ctrlManageUsersScreen_UserLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.dgvUserLists);
            this.Name = "ctrlManageUsersScreen_UserLists";
            this.Size = new System.Drawing.Size(897, 590);
            this.Load += new System.EventHandler(this.ctrlManageUsersScreen_UserLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserLists;
    }
}

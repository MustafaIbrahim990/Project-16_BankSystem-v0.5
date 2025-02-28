namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_ManageUsersScreen
{
    partial class ctrlManageUsersScreen_DeleteUser
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
            this.UserCardPanel = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // UserCardPanel
            // 
            this.UserCardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserCardPanel.Location = new System.Drawing.Point(0, 0);
            this.UserCardPanel.Name = "UserCardPanel";
            this.UserCardPanel.Size = new System.Drawing.Size(736, 590);
            this.UserCardPanel.TabIndex = 10;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Animated = true;
            this.btnDeleteUser.CheckedState.Parent = this.btnDeleteUser;
            this.btnDeleteUser.CustomImages.Parent = this.btnDeleteUser;
            this.btnDeleteUser.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.HoverState.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.DeleteUser_RedX;
            this.btnDeleteUser.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDeleteUser.Location = new System.Drawing.Point(782, 494);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.PressedColor = System.Drawing.Color.Red;
            this.btnDeleteUser.ShadowDecoration.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Size = new System.Drawing.Size(70, 61);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // ctrlManageUsersScreen_DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.UserCardPanel);
            this.Name = "ctrlManageUsersScreen_DeleteUser";
            this.Size = new System.Drawing.Size(897, 590);
            this.Load += new System.EventHandler(this.ctrlManageUsersScreen_DeleteUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UserCardPanel;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteUser;
    }
}

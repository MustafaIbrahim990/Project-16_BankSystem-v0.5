namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_ManageUsersScreen
{
    partial class ctrlManageUsersScreen_ManageUsersScreenOptions
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
            this.TopPanelSide = new System.Windows.Forms.Panel();
            this.DownPanelSide = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUserLists = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdateUser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnFindUser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ctrlManageUsersScreen_UserLists1 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_ManageUsersScreen.ctrlManageUsersScreen_UserLists();
            this.TopPanelSide.SuspendLayout();
            this.DownPanelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanelSide
            // 
            this.TopPanelSide.Controls.Add(this.btnDeleteUser);
            this.TopPanelSide.Controls.Add(this.btnUserLists);
            this.TopPanelSide.Controls.Add(this.btnUpdateUser);
            this.TopPanelSide.Controls.Add(this.btnAddNewUser);
            this.TopPanelSide.Controls.Add(this.btnFindUser);
            this.TopPanelSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelSide.Location = new System.Drawing.Point(0, 0);
            this.TopPanelSide.Name = "TopPanelSide";
            this.TopPanelSide.Size = new System.Drawing.Size(897, 112);
            this.TopPanelSide.TabIndex = 2;
            // 
            // DownPanelSide
            // 
            this.DownPanelSide.Controls.Add(this.ctrlManageUsersScreen_UserLists1);
            this.DownPanelSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownPanelSide.Location = new System.Drawing.Point(0, 112);
            this.DownPanelSide.Name = "DownPanelSide";
            this.DownPanelSide.Size = new System.Drawing.Size(897, 590);
            this.DownPanelSide.TabIndex = 3;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Animated = true;
            this.btnDeleteUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDeleteUser.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.CheckedState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDeleteUser.CheckedState.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.DeleteBlue;
            this.btnDeleteUser.CheckedState.Parent = this.btnDeleteUser;
            this.btnDeleteUser.CustomImages.Parent = this.btnDeleteUser;
            this.btnDeleteUser.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.HoverState.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.DeleteBlack;
            this.btnDeleteUser.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDeleteUser.Location = new System.Drawing.Point(678, 18);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.PressedColor = System.Drawing.Color.Blue;
            this.btnDeleteUser.ShadowDecoration.Parent = this.btnDeleteUser;
            this.btnDeleteUser.Size = new System.Drawing.Size(105, 75);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUserLists
            // 
            this.btnUserLists.Animated = true;
            this.btnUserLists.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUserLists.Checked = true;
            this.btnUserLists.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnUserLists.CheckedState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnUserLists.CheckedState.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.ListBlue;
            this.btnUserLists.CheckedState.Parent = this.btnUserLists;
            this.btnUserLists.CustomImages.Parent = this.btnUserLists;
            this.btnUserLists.FillColor = System.Drawing.Color.Transparent;
            this.btnUserLists.FillColor2 = System.Drawing.Color.Transparent;
            this.btnUserLists.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUserLists.ForeColor = System.Drawing.Color.White;
            this.btnUserLists.HoverState.Parent = this.btnUserLists;
            this.btnUserLists.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.ListBlack;
            this.btnUserLists.ImageSize = new System.Drawing.Size(50, 50);
            this.btnUserLists.Location = new System.Drawing.Point(106, 18);
            this.btnUserLists.Name = "btnUserLists";
            this.btnUserLists.PressedColor = System.Drawing.Color.Blue;
            this.btnUserLists.ShadowDecoration.Parent = this.btnUserLists;
            this.btnUserLists.Size = new System.Drawing.Size(105, 75);
            this.btnUserLists.TabIndex = 0;
            this.btnUserLists.Click += new System.EventHandler(this.btnUserLists_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Animated = true;
            this.btnUpdateUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateUser.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.CheckedState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnUpdateUser.CheckedState.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.UpdateBlue;
            this.btnUpdateUser.CheckedState.Parent = this.btnUpdateUser;
            this.btnUpdateUser.CustomImages.Parent = this.btnUpdateUser;
            this.btnUpdateUser.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.FillColor2 = System.Drawing.Color.Transparent;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.HoverState.Parent = this.btnUpdateUser;
            this.btnUpdateUser.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.UpdateBlack;
            this.btnUpdateUser.ImageSize = new System.Drawing.Size(50, 50);
            this.btnUpdateUser.Location = new System.Drawing.Point(535, 18);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.PressedColor = System.Drawing.Color.Blue;
            this.btnUpdateUser.ShadowDecoration.Parent = this.btnUpdateUser;
            this.btnUpdateUser.Size = new System.Drawing.Size(105, 75);
            this.btnUpdateUser.TabIndex = 3;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Animated = true;
            this.btnAddNewUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddNewUser.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.CheckedState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnAddNewUser.CheckedState.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.AddNewBlue;
            this.btnAddNewUser.CheckedState.Parent = this.btnAddNewUser;
            this.btnAddNewUser.CustomImages.Parent = this.btnAddNewUser;
            this.btnAddNewUser.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.FillColor2 = System.Drawing.Color.Transparent;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.HoverState.Parent = this.btnAddNewUser;
            this.btnAddNewUser.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.AddNewBlack;
            this.btnAddNewUser.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewUser.Location = new System.Drawing.Point(249, 18);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.PressedColor = System.Drawing.Color.Blue;
            this.btnAddNewUser.ShadowDecoration.Parent = this.btnAddNewUser;
            this.btnAddNewUser.Size = new System.Drawing.Size(105, 75);
            this.btnAddNewUser.TabIndex = 1;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnFindUser
            // 
            this.btnFindUser.Animated = true;
            this.btnFindUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFindUser.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnFindUser.CheckedState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnFindUser.CheckedState.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.FindClient_Blue;
            this.btnFindUser.CheckedState.Parent = this.btnFindUser;
            this.btnFindUser.CustomImages.Parent = this.btnFindUser;
            this.btnFindUser.FillColor = System.Drawing.Color.Transparent;
            this.btnFindUser.FillColor2 = System.Drawing.Color.Transparent;
            this.btnFindUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindUser.ForeColor = System.Drawing.Color.White;
            this.btnFindUser.HoverState.Parent = this.btnFindUser;
            this.btnFindUser.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.FindClient_Black2;
            this.btnFindUser.ImageSize = new System.Drawing.Size(50, 50);
            this.btnFindUser.Location = new System.Drawing.Point(392, 18);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.PressedColor = System.Drawing.Color.Blue;
            this.btnFindUser.ShadowDecoration.Parent = this.btnFindUser;
            this.btnFindUser.Size = new System.Drawing.Size(105, 75);
            this.btnFindUser.TabIndex = 2;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // ctrlManageUsersScreen_UserLists1
            // 
            this.ctrlManageUsersScreen_UserLists1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlManageUsersScreen_UserLists1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlManageUsersScreen_UserLists1.Location = new System.Drawing.Point(0, 0);
            this.ctrlManageUsersScreen_UserLists1.Name = "ctrlManageUsersScreen_UserLists1";
            this.ctrlManageUsersScreen_UserLists1.Size = new System.Drawing.Size(897, 590);
            this.ctrlManageUsersScreen_UserLists1.TabIndex = 0;
            // 
            // ctrlManageUsersScreen_ManageUsersScreenOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.DownPanelSide);
            this.Controls.Add(this.TopPanelSide);
            this.Name = "ctrlManageUsersScreen_ManageUsersScreenOptions";
            this.Size = new System.Drawing.Size(897, 702);
            this.Load += new System.EventHandler(this.ctrlManageUsersScreen_ManageUsersScreenOptions_Load);
            this.TopPanelSide.ResumeLayout(false);
            this.DownPanelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanelSide;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteUser;
        private Guna.UI2.WinForms.Guna2GradientButton btnUserLists;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdateUser;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddNewUser;
        private Guna.UI2.WinForms.Guna2GradientButton btnFindUser;
        private System.Windows.Forms.Panel DownPanelSide;
        private ctrlManageUsersScreen_UserLists ctrlManageUsersScreen_UserLists1;
    }
}

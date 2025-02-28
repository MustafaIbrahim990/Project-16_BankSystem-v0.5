namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_ManageClientsScreen
{
    partial class ctrlManageClientsScreen_ManageClientsScreenOptions
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
            this.btnDeleteClient = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClientLists = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdateClient = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddNewClient = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnFIndClient = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ctrlManageClientsScreen_FindClient1 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_ManageClientsScreen.ctrlManageClientsScreen_FindClient();
            this.ctrlManageClientsScreen_AddNewClient1 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_ManageClientsScreen.ctrlManageClientsScreen_AddNewClient();
            this.ctrlManageClientsScreen_ClientLists1 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_ManageClientsScreen.ctrlManageClientsScreen_ClientLists();
            this.TopPanelSide.SuspendLayout();
            this.DownPanelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanelSide
            // 
            this.TopPanelSide.Controls.Add(this.btnDeleteClient);
            this.TopPanelSide.Controls.Add(this.btnClientLists);
            this.TopPanelSide.Controls.Add(this.btnUpdateClient);
            this.TopPanelSide.Controls.Add(this.btnAddNewClient);
            this.TopPanelSide.Controls.Add(this.btnFIndClient);
            this.TopPanelSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelSide.Location = new System.Drawing.Point(0, 0);
            this.TopPanelSide.Name = "TopPanelSide";
            this.TopPanelSide.Size = new System.Drawing.Size(897, 112);
            this.TopPanelSide.TabIndex = 0;
            this.TopPanelSide.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanelSide_Paint);
            // 
            // DownPanelSide
            // 
            this.DownPanelSide.Controls.Add(this.ctrlManageClientsScreen_ClientLists1);
            this.DownPanelSide.Controls.Add(this.ctrlManageClientsScreen_FindClient1);
            this.DownPanelSide.Controls.Add(this.ctrlManageClientsScreen_AddNewClient1);
            this.DownPanelSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownPanelSide.Location = new System.Drawing.Point(0, 112);
            this.DownPanelSide.Name = "DownPanelSide";
            this.DownPanelSide.Size = new System.Drawing.Size(897, 590);
            this.DownPanelSide.TabIndex = 1;
            this.DownPanelSide.TabStop = true;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Animated = true;
            this.btnDeleteClient.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDeleteClient.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteClient.CheckedState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDeleteClient.CheckedState.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.DeleteBlue;
            this.btnDeleteClient.CheckedState.Parent = this.btnDeleteClient;
            this.btnDeleteClient.CustomImages.Parent = this.btnDeleteClient;
            this.btnDeleteClient.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteClient.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.HoverState.Parent = this.btnDeleteClient;
            this.btnDeleteClient.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.DeleteBlack;
            this.btnDeleteClient.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDeleteClient.Location = new System.Drawing.Point(678, 18);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.PressedColor = System.Drawing.Color.Blue;
            this.btnDeleteClient.ShadowDecoration.Parent = this.btnDeleteClient;
            this.btnDeleteClient.Size = new System.Drawing.Size(105, 75);
            this.btnDeleteClient.TabIndex = 4;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnClientLists
            // 
            this.btnClientLists.Animated = true;
            this.btnClientLists.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnClientLists.Checked = true;
            this.btnClientLists.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnClientLists.CheckedState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnClientLists.CheckedState.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.ListBlue;
            this.btnClientLists.CheckedState.Parent = this.btnClientLists;
            this.btnClientLists.CustomImages.Parent = this.btnClientLists;
            this.btnClientLists.FillColor = System.Drawing.Color.Transparent;
            this.btnClientLists.FillColor2 = System.Drawing.Color.Transparent;
            this.btnClientLists.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClientLists.ForeColor = System.Drawing.Color.White;
            this.btnClientLists.HoverState.Parent = this.btnClientLists;
            this.btnClientLists.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.ListBlack;
            this.btnClientLists.ImageSize = new System.Drawing.Size(50, 50);
            this.btnClientLists.Location = new System.Drawing.Point(106, 18);
            this.btnClientLists.Name = "btnClientLists";
            this.btnClientLists.PressedColor = System.Drawing.Color.Blue;
            this.btnClientLists.ShadowDecoration.Parent = this.btnClientLists;
            this.btnClientLists.Size = new System.Drawing.Size(105, 75);
            this.btnClientLists.TabIndex = 0;
            this.btnClientLists.Click += new System.EventHandler(this.btnClientLists_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Animated = true;
            this.btnUpdateClient.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateClient.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateClient.CheckedState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnUpdateClient.CheckedState.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.UpdateBlue;
            this.btnUpdateClient.CheckedState.Parent = this.btnUpdateClient;
            this.btnUpdateClient.CustomImages.Parent = this.btnUpdateClient;
            this.btnUpdateClient.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateClient.FillColor2 = System.Drawing.Color.Transparent;
            this.btnUpdateClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateClient.ForeColor = System.Drawing.Color.White;
            this.btnUpdateClient.HoverState.Parent = this.btnUpdateClient;
            this.btnUpdateClient.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.UpdateBlack;
            this.btnUpdateClient.ImageSize = new System.Drawing.Size(50, 50);
            this.btnUpdateClient.Location = new System.Drawing.Point(535, 18);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.PressedColor = System.Drawing.Color.Blue;
            this.btnUpdateClient.ShadowDecoration.Parent = this.btnUpdateClient;
            this.btnUpdateClient.Size = new System.Drawing.Size(105, 75);
            this.btnUpdateClient.TabIndex = 3;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.Animated = true;
            this.btnAddNewClient.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddNewClient.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewClient.CheckedState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnAddNewClient.CheckedState.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.AddNewBlue;
            this.btnAddNewClient.CheckedState.Parent = this.btnAddNewClient;
            this.btnAddNewClient.CustomImages.Parent = this.btnAddNewClient;
            this.btnAddNewClient.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewClient.FillColor2 = System.Drawing.Color.Transparent;
            this.btnAddNewClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewClient.ForeColor = System.Drawing.Color.White;
            this.btnAddNewClient.HoverState.Parent = this.btnAddNewClient;
            this.btnAddNewClient.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.AddNewBlack;
            this.btnAddNewClient.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewClient.Location = new System.Drawing.Point(249, 18);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.PressedColor = System.Drawing.Color.Blue;
            this.btnAddNewClient.ShadowDecoration.Parent = this.btnAddNewClient;
            this.btnAddNewClient.Size = new System.Drawing.Size(105, 75);
            this.btnAddNewClient.TabIndex = 1;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // btnFIndClient
            // 
            this.btnFIndClient.Animated = true;
            this.btnFIndClient.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFIndClient.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnFIndClient.CheckedState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnFIndClient.CheckedState.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.FindClient_Blue;
            this.btnFIndClient.CheckedState.Parent = this.btnFIndClient;
            this.btnFIndClient.CustomImages.Parent = this.btnFIndClient;
            this.btnFIndClient.FillColor = System.Drawing.Color.Transparent;
            this.btnFIndClient.FillColor2 = System.Drawing.Color.Transparent;
            this.btnFIndClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFIndClient.ForeColor = System.Drawing.Color.White;
            this.btnFIndClient.HoverState.Parent = this.btnFIndClient;
            this.btnFIndClient.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.FindClient_Black2;
            this.btnFIndClient.ImageSize = new System.Drawing.Size(50, 50);
            this.btnFIndClient.Location = new System.Drawing.Point(392, 18);
            this.btnFIndClient.Name = "btnFIndClient";
            this.btnFIndClient.PressedColor = System.Drawing.Color.Blue;
            this.btnFIndClient.ShadowDecoration.Parent = this.btnFIndClient;
            this.btnFIndClient.Size = new System.Drawing.Size(105, 75);
            this.btnFIndClient.TabIndex = 2;
            this.btnFIndClient.Click += new System.EventHandler(this.btnFIndClient_Click);
            // 
            // ctrlManageClientsScreen_FindClient1
            // 
            this.ctrlManageClientsScreen_FindClient1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlManageClientsScreen_FindClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlManageClientsScreen_FindClient1.Location = new System.Drawing.Point(0, 0);
            this.ctrlManageClientsScreen_FindClient1.Name = "ctrlManageClientsScreen_FindClient1";
            this.ctrlManageClientsScreen_FindClient1.Size = new System.Drawing.Size(897, 590);
            this.ctrlManageClientsScreen_FindClient1.TabIndex = 1;
            // 
            // ctrlManageClientsScreen_AddNewClient1
            // 
            this.ctrlManageClientsScreen_AddNewClient1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlManageClientsScreen_AddNewClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlManageClientsScreen_AddNewClient1.Location = new System.Drawing.Point(0, 0);
            this.ctrlManageClientsScreen_AddNewClient1.Name = "ctrlManageClientsScreen_AddNewClient1";
            this.ctrlManageClientsScreen_AddNewClient1.Size = new System.Drawing.Size(897, 590);
            this.ctrlManageClientsScreen_AddNewClient1.TabIndex = 0;
            // 
            // ctrlManageClientsScreen_ClientLists1
            // 
            this.ctrlManageClientsScreen_ClientLists1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlManageClientsScreen_ClientLists1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlManageClientsScreen_ClientLists1.Location = new System.Drawing.Point(0, 0);
            this.ctrlManageClientsScreen_ClientLists1.Name = "ctrlManageClientsScreen_ClientLists1";
            this.ctrlManageClientsScreen_ClientLists1.Size = new System.Drawing.Size(897, 590);
            this.ctrlManageClientsScreen_ClientLists1.TabIndex = 2;
            // 
            // ctrlManageClientsScreen_ManageClientsScreenOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.DownPanelSide);
            this.Controls.Add(this.TopPanelSide);
            this.Name = "ctrlManageClientsScreen_ManageClientsScreenOptions";
            this.Size = new System.Drawing.Size(897, 702);
            this.Load += new System.EventHandler(this.ctrlManageClientsScreen_ManageClientsScreenOptions_Load);
            this.TopPanelSide.ResumeLayout(false);
            this.DownPanelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanelSide;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteClient;
        private Guna.UI2.WinForms.Guna2GradientButton btnClientLists;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdateClient;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddNewClient;
        private Guna.UI2.WinForms.Guna2GradientButton btnFIndClient;
        private System.Windows.Forms.Panel DownPanelSide;
        private ctrlManageClientsScreen_AddNewClient ctrlManageClientsScreen_AddNewClient1;
        private ctrlManageClientsScreen_FindClient ctrlManageClientsScreen_FindClient1;
        private ctrlManageClientsScreen_ClientLists ctrlManageClientsScreen_ClientLists1;
    }
}

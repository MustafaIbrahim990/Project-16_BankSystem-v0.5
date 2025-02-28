namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_ManageClientsScreen
{
    partial class ctrlManageClientsScreen_DeleteClient
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
            this.btnDeleteClient = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ClientCardPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Animated = true;
            this.btnDeleteClient.CheckedState.Parent = this.btnDeleteClient;
            this.btnDeleteClient.CustomImages.Parent = this.btnDeleteClient;
            this.btnDeleteClient.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteClient.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.HoverState.Parent = this.btnDeleteClient;
            this.btnDeleteClient.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.DeleteUser_RedX;
            this.btnDeleteClient.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDeleteClient.Location = new System.Drawing.Point(782, 494);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.PressedColor = System.Drawing.Color.Red;
            this.btnDeleteClient.ShadowDecoration.Parent = this.btnDeleteClient;
            this.btnDeleteClient.Size = new System.Drawing.Size(70, 61);
            this.btnDeleteClient.TabIndex = 8;
            this.btnDeleteClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // ClientCardPanel
            // 
            this.ClientCardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClientCardPanel.Location = new System.Drawing.Point(0, 0);
            this.ClientCardPanel.Name = "ClientCardPanel";
            this.ClientCardPanel.Size = new System.Drawing.Size(736, 590);
            this.ClientCardPanel.TabIndex = 9;
            // 
            // ctrlManageClientsScreen_DeleteClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.ClientCardPanel);
            this.Controls.Add(this.btnDeleteClient);
            this.Name = "ctrlManageClientsScreen_DeleteClient";
            this.Size = new System.Drawing.Size(897, 590);
            this.Load += new System.EventHandler(this.ctrlManageClientsScreen_DeleteClient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteClient;
        private System.Windows.Forms.Panel ClientCardPanel;
    }
}

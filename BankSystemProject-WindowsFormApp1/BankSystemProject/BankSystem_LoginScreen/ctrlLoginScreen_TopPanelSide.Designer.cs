namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_LoginScreen
{
    partial class ctrlLoginScreen_TopPanelSide
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnExitApp = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(154, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(72, 25);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "[????]";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(443, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "[????]";
            // 
            // btnExitApp
            // 
            this.btnExitApp.Animated = true;
            this.btnExitApp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnExitApp.CheckedState.Parent = this.btnExitApp;
            this.btnExitApp.CustomImages.Parent = this.btnExitApp;
            this.btnExitApp.FillColor = System.Drawing.Color.Transparent;
            this.btnExitApp.FillColor2 = System.Drawing.Color.Transparent;
            this.btnExitApp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExitApp.ForeColor = System.Drawing.Color.White;
            this.btnExitApp.HoverState.Parent = this.btnExitApp;
            this.btnExitApp.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.Close_AppRed;
            this.btnExitApp.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExitApp.Location = new System.Drawing.Point(828, 3);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.PressedColor = System.Drawing.Color.Red;
            this.btnExitApp.ShadowDecoration.Parent = this.btnExitApp;
            this.btnExitApp.Size = new System.Drawing.Size(57, 42);
            this.btnExitApp.TabIndex = 3;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // ctrlLoginScreen_TopPanelSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Name = "ctrlLoginScreen_TopPanelSide";
            this.Size = new System.Drawing.Size(897, 48);
            this.Load += new System.EventHandler(this.ctrlLoginScreen_TopPanelSide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2GradientButton btnExitApp;
    }
}

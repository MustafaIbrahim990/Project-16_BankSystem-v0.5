namespace BankSystemProject_WindowsFormApp1
{
    partial class frmLoginScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LoginScreen_TopPanelSide = new System.Windows.Forms.Panel();
            this.ctrlLoginScreen_TopPanelSide1 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_LoginScreen.ctrlLoginScreen_TopPanelSide();
            this.LoginScreen_LeftPanelSide = new System.Windows.Forms.Panel();
            this.ctrlLoginScreen_LeftPanelSide1 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_LoginScreen.ctrlLoginScreen_LeftPanelSide();
            this.LoginScreen_MainPanelSide = new System.Windows.Forms.Panel();
            this.ctrlLoginScreen_RightPanelSide1 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_LoginScreen.ctrlLoginScreen_RightPanelSide();
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.LoginScreen_TopPanelSide.SuspendLayout();
            this.LoginScreen_LeftPanelSide.SuspendLayout();
            this.LoginScreen_MainPanelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginScreen_TopPanelSide
            // 
            this.LoginScreen_TopPanelSide.Controls.Add(this.ctrlLoginScreen_TopPanelSide1);
            this.LoginScreen_TopPanelSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginScreen_TopPanelSide.Location = new System.Drawing.Point(263, 0);
            this.LoginScreen_TopPanelSide.Name = "LoginScreen_TopPanelSide";
            this.LoginScreen_TopPanelSide.Size = new System.Drawing.Size(897, 48);
            this.LoginScreen_TopPanelSide.TabIndex = 1;
            // 
            // ctrlLoginScreen_TopPanelSide1
            // 
            this.ctrlLoginScreen_TopPanelSide1.BackColor = System.Drawing.Color.Silver;
            this.ctrlLoginScreen_TopPanelSide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlLoginScreen_TopPanelSide1.Location = new System.Drawing.Point(0, 0);
            this.ctrlLoginScreen_TopPanelSide1.Name = "ctrlLoginScreen_TopPanelSide1";
            this.ctrlLoginScreen_TopPanelSide1.Size = new System.Drawing.Size(897, 48);
            this.ctrlLoginScreen_TopPanelSide1.TabIndex = 2;
            this.ctrlLoginScreen_TopPanelSide1.TabStop = false;
            // 
            // LoginScreen_LeftPanelSide
            // 
            this.LoginScreen_LeftPanelSide.Controls.Add(this.ctrlLoginScreen_LeftPanelSide1);
            this.LoginScreen_LeftPanelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginScreen_LeftPanelSide.Location = new System.Drawing.Point(0, 0);
            this.LoginScreen_LeftPanelSide.Name = "LoginScreen_LeftPanelSide";
            this.LoginScreen_LeftPanelSide.Size = new System.Drawing.Size(263, 750);
            this.LoginScreen_LeftPanelSide.TabIndex = 1;
            // 
            // ctrlLoginScreen_LeftPanelSide1
            // 
            this.ctrlLoginScreen_LeftPanelSide1.BackColor = System.Drawing.Color.Silver;
            this.ctrlLoginScreen_LeftPanelSide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlLoginScreen_LeftPanelSide1.Location = new System.Drawing.Point(0, 0);
            this.ctrlLoginScreen_LeftPanelSide1.Name = "ctrlLoginScreen_LeftPanelSide1";
            this.ctrlLoginScreen_LeftPanelSide1.Size = new System.Drawing.Size(263, 750);
            this.ctrlLoginScreen_LeftPanelSide1.TabIndex = 1;
            this.ctrlLoginScreen_LeftPanelSide1.TabStop = false;
            // 
            // LoginScreen_MainPanelSide
            // 
            this.LoginScreen_MainPanelSide.Controls.Add(this.ctrlLoginScreen_RightPanelSide1);
            this.LoginScreen_MainPanelSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginScreen_MainPanelSide.Location = new System.Drawing.Point(263, 48);
            this.LoginScreen_MainPanelSide.Name = "LoginScreen_MainPanelSide";
            this.LoginScreen_MainPanelSide.Size = new System.Drawing.Size(897, 702);
            this.LoginScreen_MainPanelSide.TabIndex = 3;
            // 
            // ctrlLoginScreen_RightPanelSide1
            // 
            this.ctrlLoginScreen_RightPanelSide1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlLoginScreen_RightPanelSide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlLoginScreen_RightPanelSide1.Location = new System.Drawing.Point(0, 0);
            this.ctrlLoginScreen_RightPanelSide1.Name = "ctrlLoginScreen_RightPanelSide1";
            this.ctrlLoginScreen_RightPanelSide1.Size = new System.Drawing.Size(897, 702);
            this.ctrlLoginScreen_RightPanelSide1.TabIndex = 0;
            this.ctrlLoginScreen_RightPanelSide1.Load += new System.EventHandler(this.ctrlLoginScreen_RightPanelSide1_Load);
            // 
            // DragControl1
            // 
            this.DragControl1.TargetControl = this.ctrlLoginScreen_TopPanelSide1;
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 750);
            this.Controls.Add(this.LoginScreen_MainPanelSide);
            this.Controls.Add(this.LoginScreen_TopPanelSide);
            this.Controls.Add(this.LoginScreen_LeftPanelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLoginScreen_Load);
            this.LoginScreen_TopPanelSide.ResumeLayout(false);
            this.LoginScreen_LeftPanelSide.ResumeLayout(false);
            this.LoginScreen_MainPanelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LoginScreen_TopPanelSide;
        private System.Windows.Forms.Panel LoginScreen_LeftPanelSide;
        private System.Windows.Forms.Panel LoginScreen_MainPanelSide;
        private BankSystemProject.BankSystem_LoginScreen.ctrlLoginScreen_TopPanelSide ctrlLoginScreen_TopPanelSide1;
        private BankSystemProject.BankSystem_LoginScreen.ctrlLoginScreen_LeftPanelSide ctrlLoginScreen_LeftPanelSide1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private BankSystemProject.BankSystem_LoginScreen.ctrlLoginScreen_RightPanelSide ctrlLoginScreen_RightPanelSide1;
    }
}
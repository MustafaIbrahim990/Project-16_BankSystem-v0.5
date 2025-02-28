namespace BankSystemProject_WindowsFormApp1
{
    partial class frmMainScreen
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctrlLoginScreen_LeftPanelSide1 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_LoginScreen.ctrlLoginScreen_LeftPanelSide();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ctrlLoginScreen_TopPanelSide1 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_LoginScreen.ctrlLoginScreen_TopPanelSide();
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MainScreen_RightPanelSide = new System.Windows.Forms.Panel();
            this.ctrlMainScreen_RightPanelSide1 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_MainScreen.ctrlMainScreen_RightPanelSide();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.MainScreen_RightPanelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ctrlLoginScreen_LeftPanelSide1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 750);
            this.panel2.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.ctrlLoginScreen_TopPanelSide1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(263, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(897, 48);
            this.panel3.TabIndex = 1;
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
            // DragControl1
            // 
            this.DragControl1.TargetControl = this.ctrlLoginScreen_TopPanelSide1;
            // 
            // MainScreen_RightPanelSide
            // 
            this.MainScreen_RightPanelSide.Controls.Add(this.ctrlMainScreen_RightPanelSide1);
            this.MainScreen_RightPanelSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainScreen_RightPanelSide.Location = new System.Drawing.Point(263, 48);
            this.MainScreen_RightPanelSide.Name = "MainScreen_RightPanelSide";
            this.MainScreen_RightPanelSide.Size = new System.Drawing.Size(897, 702);
            this.MainScreen_RightPanelSide.TabIndex = 3;
            // 
            // ctrlMainScreen_RightPanelSide1
            // 
            this.ctrlMainScreen_RightPanelSide1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlMainScreen_RightPanelSide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlMainScreen_RightPanelSide1.Location = new System.Drawing.Point(0, 0);
            this.ctrlMainScreen_RightPanelSide1.Name = "ctrlMainScreen_RightPanelSide1";
            this.ctrlMainScreen_RightPanelSide1.Size = new System.Drawing.Size(897, 702);
            this.ctrlMainScreen_RightPanelSide1.TabIndex = 0;
            this.ctrlMainScreen_RightPanelSide1.Load += new System.EventHandler(this.ctrlMainScreen_RightPanelSide1_Load);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1160, 750);
            this.Controls.Add(this.MainScreen_RightPanelSide);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.MainScreen_RightPanelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private BankSystemProject.BankSystem_LoginScreen.ctrlLoginScreen_LeftPanelSide ctrlLoginScreen_LeftPanelSide1;
        private BankSystemProject.BankSystem_LoginScreen.ctrlLoginScreen_TopPanelSide ctrlLoginScreen_TopPanelSide1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private System.Windows.Forms.Panel MainScreen_RightPanelSide;
        private BankSystemProject.BankSystem_MainScreen.ctrlMainScreen_RightPanelSide ctrlMainScreen_RightPanelSide1;
    }
}


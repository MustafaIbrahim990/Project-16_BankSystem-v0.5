namespace BankSystemProject_WindowsFormApp1
{
    partial class frmCurrenciesScreen
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
            this.LeftPanelSide = new System.Windows.Forms.Panel();
            this.TopPanelSide = new System.Windows.Forms.Panel();
            this.ctrlLoginScreen_TopPanelSide1 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_LoginScreen.ctrlLoginScreen_TopPanelSide();
            this.ctrlLoginScreen_LeftPanelSide1 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_LoginScreen.ctrlLoginScreen_LeftPanelSide();
            this.RightPanelSide = new System.Windows.Forms.Panel();
            this.ctrlCurrenciesScreen_CurrencyOptions1 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_CurrencyScreen.ctrlCurrenciesScreen_CurrencyOptions();
            this.LeftPanelSide.SuspendLayout();
            this.TopPanelSide.SuspendLayout();
            this.RightPanelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanelSide
            // 
            this.LeftPanelSide.Controls.Add(this.ctrlLoginScreen_LeftPanelSide1);
            this.LeftPanelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanelSide.Location = new System.Drawing.Point(0, 0);
            this.LeftPanelSide.Name = "LeftPanelSide";
            this.LeftPanelSide.Size = new System.Drawing.Size(263, 750);
            this.LeftPanelSide.TabIndex = 1;
            // 
            // TopPanelSide
            // 
            this.TopPanelSide.Controls.Add(this.ctrlLoginScreen_TopPanelSide1);
            this.TopPanelSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelSide.Location = new System.Drawing.Point(263, 0);
            this.TopPanelSide.Name = "TopPanelSide";
            this.TopPanelSide.Size = new System.Drawing.Size(897, 48);
            this.TopPanelSide.TabIndex = 1;
            // 
            // ctrlLoginScreen_TopPanelSide1
            // 
            this.ctrlLoginScreen_TopPanelSide1.BackColor = System.Drawing.Color.Silver;
            this.ctrlLoginScreen_TopPanelSide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlLoginScreen_TopPanelSide1.Location = new System.Drawing.Point(0, 0);
            this.ctrlLoginScreen_TopPanelSide1.Name = "ctrlLoginScreen_TopPanelSide1";
            this.ctrlLoginScreen_TopPanelSide1.Size = new System.Drawing.Size(897, 48);
            this.ctrlLoginScreen_TopPanelSide1.TabIndex = 4;
            this.ctrlLoginScreen_TopPanelSide1.TabStop = false;
            // 
            // ctrlLoginScreen_LeftPanelSide1
            // 
            this.ctrlLoginScreen_LeftPanelSide1.BackColor = System.Drawing.Color.Silver;
            this.ctrlLoginScreen_LeftPanelSide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlLoginScreen_LeftPanelSide1.Location = new System.Drawing.Point(0, 0);
            this.ctrlLoginScreen_LeftPanelSide1.Name = "ctrlLoginScreen_LeftPanelSide1";
            this.ctrlLoginScreen_LeftPanelSide1.Size = new System.Drawing.Size(263, 750);
            this.ctrlLoginScreen_LeftPanelSide1.TabIndex = 3;
            this.ctrlLoginScreen_LeftPanelSide1.TabStop = false;
            // 
            // RightPanelSide
            // 
            this.RightPanelSide.Controls.Add(this.ctrlCurrenciesScreen_CurrencyOptions1);
            this.RightPanelSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanelSide.Location = new System.Drawing.Point(263, 48);
            this.RightPanelSide.Name = "RightPanelSide";
            this.RightPanelSide.Size = new System.Drawing.Size(897, 702);
            this.RightPanelSide.TabIndex = 1;
            // 
            // ctrlCurrenciesScreen_CurrencyOptions1
            // 
            this.ctrlCurrenciesScreen_CurrencyOptions1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlCurrenciesScreen_CurrencyOptions1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlCurrenciesScreen_CurrencyOptions1.Location = new System.Drawing.Point(0, 0);
            this.ctrlCurrenciesScreen_CurrencyOptions1.Name = "ctrlCurrenciesScreen_CurrencyOptions1";
            this.ctrlCurrenciesScreen_CurrencyOptions1.Size = new System.Drawing.Size(897, 702);
            this.ctrlCurrenciesScreen_CurrencyOptions1.TabIndex = 0;
            // 
            // frmCurrenciesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 750);
            this.Controls.Add(this.RightPanelSide);
            this.Controls.Add(this.TopPanelSide);
            this.Controls.Add(this.LeftPanelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCurrenciesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCurrenciesScreen";
            this.Load += new System.EventHandler(this.frmCurrenciesScreen_Load);
            this.LeftPanelSide.ResumeLayout(false);
            this.TopPanelSide.ResumeLayout(false);
            this.RightPanelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LeftPanelSide;
        private System.Windows.Forms.Panel TopPanelSide;
        private BankSystemProject.BankSystem_LoginScreen.ctrlLoginScreen_LeftPanelSide ctrlLoginScreen_LeftPanelSide1;
        private BankSystemProject.BankSystem_LoginScreen.ctrlLoginScreen_TopPanelSide ctrlLoginScreen_TopPanelSide1;
        private System.Windows.Forms.Panel RightPanelSide;
        private BankSystemProject.BankSystem_CurrencyScreen.ctrlCurrenciesScreen_CurrencyOptions ctrlCurrenciesScreen_CurrencyOptions1;
    }
}
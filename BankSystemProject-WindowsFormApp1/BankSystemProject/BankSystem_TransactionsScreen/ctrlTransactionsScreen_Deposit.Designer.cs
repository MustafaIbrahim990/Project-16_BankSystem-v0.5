namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_TransactionsScreen
{
    partial class ctrlTransactionsScreen_Deposit
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDepositAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.btnDposit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Account Number :";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Animated = true;
            this.txtAccountNumber.BorderColor = System.Drawing.Color.Gray;
            this.txtAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumber.DefaultText = "";
            this.txtAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.DisabledState.Parent = this.txtAccountNumber;
            this.txtAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.FillColor = System.Drawing.Color.Silver;
            this.txtAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.FocusedState.Parent = this.txtAccountNumber;
            this.txtAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.HoverState.Parent = this.txtAccountNumber;
            this.txtAccountNumber.Location = new System.Drawing.Point(30, 83);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PasswordChar = '\0';
            this.txtAccountNumber.PlaceholderText = "";
            this.txtAccountNumber.SelectedText = "";
            this.txtAccountNumber.ShadowDecoration.Parent = this.txtAccountNumber;
            this.txtAccountNumber.Size = new System.Drawing.Size(299, 32);
            this.txtAccountNumber.TabIndex = 0;
            this.txtAccountNumber.TextChanged += new System.EventHandler(this.txtAccountNumber_TextChanged);
            this.txtAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtAccountNumber_Validating);
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Animated = true;
            this.txtDepositAmount.BorderColor = System.Drawing.Color.Gray;
            this.txtDepositAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDepositAmount.DefaultText = "";
            this.txtDepositAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDepositAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDepositAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDepositAmount.DisabledState.Parent = this.txtDepositAmount;
            this.txtDepositAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDepositAmount.FillColor = System.Drawing.Color.Silver;
            this.txtDepositAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDepositAmount.FocusedState.Parent = this.txtDepositAmount;
            this.txtDepositAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDepositAmount.HoverState.Parent = this.txtDepositAmount;
            this.txtDepositAmount.Location = new System.Drawing.Point(30, 358);
            this.txtDepositAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.PasswordChar = '\0';
            this.txtDepositAmount.PlaceholderText = "";
            this.txtDepositAmount.SelectedText = "";
            this.txtDepositAmount.ShadowDecoration.Parent = this.txtDepositAmount;
            this.txtDepositAmount.Size = new System.Drawing.Size(299, 32);
            this.txtDepositAmount.TabIndex = 1;
            this.txtDepositAmount.TextChanged += new System.EventHandler(this.txtDepositAmount_TextChanged);
            this.txtDepositAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtDepositAmount_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Deposit Amount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Current Balance is :";
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCurrentBalance.Location = new System.Drawing.Point(289, 178);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(70, 28);
            this.lblCurrentBalance.TabIndex = 22;
            this.lblCurrentBalance.Text = "[????]";
            // 
            // btnDposit
            // 
            this.btnDposit.Animated = true;
            this.btnDposit.CheckedState.Parent = this.btnDposit;
            this.btnDposit.CustomImages.Parent = this.btnDposit;
            this.btnDposit.FillColor = System.Drawing.Color.Gray;
            this.btnDposit.FillColor2 = System.Drawing.Color.DarkGray;
            this.btnDposit.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.btnDposit.ForeColor = System.Drawing.Color.White;
            this.btnDposit.HoverState.Parent = this.btnDposit;
            this.btnDposit.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDposit.Location = new System.Drawing.Point(30, 455);
            this.btnDposit.Name = "btnDposit";
            this.btnDposit.PressedColor = System.Drawing.Color.Blue;
            this.btnDposit.ShadowDecoration.Parent = this.btnDposit;
            this.btnDposit.Size = new System.Drawing.Size(299, 61);
            this.btnDposit.TabIndex = 2;
            this.btnDposit.Text = "Deposit";
            this.btnDposit.Click += new System.EventHandler(this.btnDposit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlTransactionsScreen_Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.btnDposit);
            this.Controls.Add(this.lblCurrentBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepositAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label2);
            this.Name = "ctrlTransactionsScreen_Deposit";
            this.Size = new System.Drawing.Size(897, 590);
            this.Load += new System.EventHandler(this.ctrlTransactionsScreen_Deposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtDepositAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentBalance;
        private Guna.UI2.WinForms.Guna2GradientButton btnDposit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_TransactionsScreen
{
    partial class ctrlTransactionsScreen_Withdraw
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
            this.btnWithdraw = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWithdrawAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Animated = true;
            this.btnWithdraw.CheckedState.Parent = this.btnWithdraw;
            this.btnWithdraw.CustomImages.Parent = this.btnWithdraw;
            this.btnWithdraw.FillColor = System.Drawing.Color.Gray;
            this.btnWithdraw.FillColor2 = System.Drawing.Color.DarkGray;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.HoverState.Parent = this.btnWithdraw;
            this.btnWithdraw.ImageSize = new System.Drawing.Size(50, 50);
            this.btnWithdraw.Location = new System.Drawing.Point(30, 455);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.PressedColor = System.Drawing.Color.Blue;
            this.btnWithdraw.ShadowDecoration.Parent = this.btnWithdraw;
            this.btnWithdraw.Size = new System.Drawing.Size(299, 61);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCurrentBalance.Location = new System.Drawing.Point(289, 178);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(70, 28);
            this.lblCurrentBalance.TabIndex = 32;
            this.lblCurrentBalance.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "Current Balance is :";
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.Animated = true;
            this.txtWithdrawAmount.BorderColor = System.Drawing.Color.Gray;
            this.txtWithdrawAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWithdrawAmount.DefaultText = "";
            this.txtWithdrawAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWithdrawAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWithdrawAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWithdrawAmount.DisabledState.Parent = this.txtWithdrawAmount;
            this.txtWithdrawAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWithdrawAmount.FillColor = System.Drawing.Color.Silver;
            this.txtWithdrawAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWithdrawAmount.FocusedState.Parent = this.txtWithdrawAmount;
            this.txtWithdrawAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWithdrawAmount.HoverState.Parent = this.txtWithdrawAmount;
            this.txtWithdrawAmount.Location = new System.Drawing.Point(30, 358);
            this.txtWithdrawAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.PasswordChar = '\0';
            this.txtWithdrawAmount.PlaceholderText = "";
            this.txtWithdrawAmount.SelectedText = "";
            this.txtWithdrawAmount.ShadowDecoration.Parent = this.txtWithdrawAmount;
            this.txtWithdrawAmount.Size = new System.Drawing.Size(299, 32);
            this.txtWithdrawAmount.TabIndex = 1;
            this.txtWithdrawAmount.TextChanged += new System.EventHandler(this.txtWithdrawAmount_TextChanged);
            this.txtWithdrawAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtWithdrawAmount_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Withdraw Amount :";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "Account Number :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlTransactionsScreen_Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblCurrentBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWithdrawAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label2);
            this.Name = "ctrlTransactionsScreen_Withdraw";
            this.Size = new System.Drawing.Size(897, 590);
            this.Load += new System.EventHandler(this.ctrlTransactionsScreen_Withdraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnWithdraw;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtWithdrawAmount;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

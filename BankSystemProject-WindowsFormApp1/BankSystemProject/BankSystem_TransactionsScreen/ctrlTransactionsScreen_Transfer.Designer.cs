namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_TransactionsScreen
{
    partial class ctrlTransactionsScreen_Transfer
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
            this.lblFCurrentBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFromAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTCurrentBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTransfer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTransferAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFCurrentBalance
            // 
            this.lblFCurrentBalance.AutoSize = true;
            this.lblFCurrentBalance.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFCurrentBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFCurrentBalance.Location = new System.Drawing.Point(269, 173);
            this.lblFCurrentBalance.Name = "lblFCurrentBalance";
            this.lblFCurrentBalance.Size = new System.Drawing.Size(70, 28);
            this.lblFCurrentBalance.TabIndex = 36;
            this.lblFCurrentBalance.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "Current Balance is :";
            // 
            // txtFromAccountNumber
            // 
            this.txtFromAccountNumber.Animated = true;
            this.txtFromAccountNumber.BorderColor = System.Drawing.Color.Gray;
            this.txtFromAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFromAccountNumber.DefaultText = "";
            this.txtFromAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFromAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFromAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFromAccountNumber.DisabledState.Parent = this.txtFromAccountNumber;
            this.txtFromAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFromAccountNumber.FillColor = System.Drawing.Color.Silver;
            this.txtFromAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFromAccountNumber.FocusedState.Parent = this.txtFromAccountNumber;
            this.txtFromAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFromAccountNumber.HoverState.Parent = this.txtFromAccountNumber;
            this.txtFromAccountNumber.Location = new System.Drawing.Point(20, 78);
            this.txtFromAccountNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFromAccountNumber.Name = "txtFromAccountNumber";
            this.txtFromAccountNumber.PasswordChar = '\0';
            this.txtFromAccountNumber.PlaceholderText = "";
            this.txtFromAccountNumber.SelectedText = "";
            this.txtFromAccountNumber.ShadowDecoration.Parent = this.txtFromAccountNumber;
            this.txtFromAccountNumber.Size = new System.Drawing.Size(299, 32);
            this.txtFromAccountNumber.TabIndex = 33;
            this.txtFromAccountNumber.TextChanged += new System.EventHandler(this.txtFromAccountNumber_TextChanged);
            this.txtFromAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtFromAccountNumber_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 28);
            this.label2.TabIndex = 34;
            this.label2.Text = "From Acc. Number :";
            // 
            // lblTCurrentBalance
            // 
            this.lblTCurrentBalance.AutoSize = true;
            this.lblTCurrentBalance.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCurrentBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTCurrentBalance.Location = new System.Drawing.Point(757, 173);
            this.lblTCurrentBalance.Name = "lblTCurrentBalance";
            this.lblTCurrentBalance.Size = new System.Drawing.Size(70, 28);
            this.lblTCurrentBalance.TabIndex = 40;
            this.lblTCurrentBalance.Text = "[????]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 28);
            this.label4.TabIndex = 39;
            this.label4.Text = "Current Balance is :";
            // 
            // txtToAccountNumber
            // 
            this.txtToAccountNumber.Animated = true;
            this.txtToAccountNumber.BorderColor = System.Drawing.Color.Gray;
            this.txtToAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToAccountNumber.DefaultText = "";
            this.txtToAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtToAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtToAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtToAccountNumber.DisabledState.Parent = this.txtToAccountNumber;
            this.txtToAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtToAccountNumber.FillColor = System.Drawing.Color.Silver;
            this.txtToAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtToAccountNumber.FocusedState.Parent = this.txtToAccountNumber;
            this.txtToAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtToAccountNumber.HoverState.Parent = this.txtToAccountNumber;
            this.txtToAccountNumber.Location = new System.Drawing.Point(508, 78);
            this.txtToAccountNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtToAccountNumber.Name = "txtToAccountNumber";
            this.txtToAccountNumber.PasswordChar = '\0';
            this.txtToAccountNumber.PlaceholderText = "";
            this.txtToAccountNumber.SelectedText = "";
            this.txtToAccountNumber.ShadowDecoration.Parent = this.txtToAccountNumber;
            this.txtToAccountNumber.Size = new System.Drawing.Size(299, 32);
            this.txtToAccountNumber.TabIndex = 37;
            this.txtToAccountNumber.TextChanged += new System.EventHandler(this.txtToAccountNumber_TextChanged);
            this.txtToAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtToAccountNumber_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(508, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 28);
            this.label5.TabIndex = 38;
            this.label5.Text = "To Acc. Number :";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Animated = true;
            this.btnTransfer.CheckedState.Parent = this.btnTransfer;
            this.btnTransfer.CustomImages.Parent = this.btnTransfer;
            this.btnTransfer.FillColor = System.Drawing.Color.Gray;
            this.btnTransfer.FillColor2 = System.Drawing.Color.DarkGray;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.HoverState.Parent = this.btnTransfer;
            this.btnTransfer.ImageSize = new System.Drawing.Size(50, 50);
            this.btnTransfer.Location = new System.Drawing.Point(20, 464);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.PressedColor = System.Drawing.Color.Blue;
            this.btnTransfer.ShadowDecoration.Parent = this.btnTransfer;
            this.btnTransfer.Size = new System.Drawing.Size(299, 61);
            this.btnTransfer.TabIndex = 42;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Animated = true;
            this.txtTransferAmount.BorderColor = System.Drawing.Color.Gray;
            this.txtTransferAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTransferAmount.DefaultText = "";
            this.txtTransferAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTransferAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTransferAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTransferAmount.DisabledState.Parent = this.txtTransferAmount;
            this.txtTransferAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTransferAmount.FillColor = System.Drawing.Color.Silver;
            this.txtTransferAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTransferAmount.FocusedState.Parent = this.txtTransferAmount;
            this.txtTransferAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTransferAmount.HoverState.Parent = this.txtTransferAmount;
            this.txtTransferAmount.Location = new System.Drawing.Point(20, 367);
            this.txtTransferAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.PasswordChar = '\0';
            this.txtTransferAmount.PlaceholderText = "";
            this.txtTransferAmount.SelectedText = "";
            this.txtTransferAmount.ShadowDecoration.Parent = this.txtTransferAmount;
            this.txtTransferAmount.Size = new System.Drawing.Size(299, 32);
            this.txtTransferAmount.TabIndex = 41;
            this.txtTransferAmount.TextChanged += new System.EventHandler(this.txtTransferAmount_TextChanged);
            this.txtTransferAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtTransferAmount_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 28);
            this.label6.TabIndex = 43;
            this.label6.Text = "Transfer Amount :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlTransactionsScreen_Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtTransferAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTCurrentBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtToAccountNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFCurrentBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFromAccountNumber);
            this.Controls.Add(this.label2);
            this.Name = "ctrlTransactionsScreen_Transfer";
            this.Size = new System.Drawing.Size(897, 590);
            this.Load += new System.EventHandler(this.ctrlTransactionsScreen_Transfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFCurrentBalance;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtFromAccountNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTCurrentBalance;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtToAccountNumber;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientButton btnTransfer;
        private Guna.UI2.WinForms.Guna2TextBox txtTransferAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

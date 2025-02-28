namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_CurrencyScreen
{
    partial class ctrlCurrenciesScreen_CurrencyCalculator
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
            this.txtAmountToExchange = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCurrencyCalculator = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ctrlCurrenciesScreen_FindCurency2 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_CurrencyScreen.ctrlCurrenciesScreen_FindCurency();
            this.ctrlCurrenciesScreen_FindCurency1 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_CurrencyScreen.ctrlCurrenciesScreen_FindCurency();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmountToExchange
            // 
            this.txtAmountToExchange.Animated = true;
            this.txtAmountToExchange.BorderColor = System.Drawing.Color.Gray;
            this.txtAmountToExchange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmountToExchange.DefaultText = "";
            this.txtAmountToExchange.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmountToExchange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmountToExchange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmountToExchange.DisabledState.Parent = this.txtAmountToExchange;
            this.txtAmountToExchange.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmountToExchange.FillColor = System.Drawing.Color.Silver;
            this.txtAmountToExchange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmountToExchange.FocusedState.Parent = this.txtAmountToExchange;
            this.txtAmountToExchange.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmountToExchange.HoverState.Parent = this.txtAmountToExchange;
            this.txtAmountToExchange.Location = new System.Drawing.Point(27, 501);
            this.txtAmountToExchange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmountToExchange.Name = "txtAmountToExchange";
            this.txtAmountToExchange.PasswordChar = '\0';
            this.txtAmountToExchange.PlaceholderText = "";
            this.txtAmountToExchange.SelectedText = "";
            this.txtAmountToExchange.ShadowDecoration.Parent = this.txtAmountToExchange;
            this.txtAmountToExchange.Size = new System.Drawing.Size(299, 32);
            this.txtAmountToExchange.TabIndex = 39;
            this.txtAmountToExchange.TextChanged += new System.EventHandler(this.txtAmountToExchange_TextChanged);
            this.txtAmountToExchange.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmountToExchange_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Dubai Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 40);
            this.label10.TabIndex = 38;
            this.label10.Text = "Amount to Exchange :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCurrencyCalculator
            // 
            this.btnCurrencyCalculator.Animated = true;
            this.btnCurrencyCalculator.CheckedState.Parent = this.btnCurrencyCalculator;
            this.btnCurrencyCalculator.CustomImages.Parent = this.btnCurrencyCalculator;
            this.btnCurrencyCalculator.FillColor = System.Drawing.Color.Transparent;
            this.btnCurrencyCalculator.FillColor2 = System.Drawing.Color.Transparent;
            this.btnCurrencyCalculator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCurrencyCalculator.ForeColor = System.Drawing.Color.White;
            this.btnCurrencyCalculator.HoverState.Parent = this.btnCurrencyCalculator;
            this.btnCurrencyCalculator.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.MoneyExchsnge_Blue;
            this.btnCurrencyCalculator.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCurrencyCalculator.Location = new System.Drawing.Point(780, 472);
            this.btnCurrencyCalculator.Name = "btnCurrencyCalculator";
            this.btnCurrencyCalculator.PressedColor = System.Drawing.Color.Blue;
            this.btnCurrencyCalculator.ShadowDecoration.Parent = this.btnCurrencyCalculator;
            this.btnCurrencyCalculator.Size = new System.Drawing.Size(70, 61);
            this.btnCurrencyCalculator.TabIndex = 40;
            this.btnCurrencyCalculator.Click += new System.EventHandler(this.btnCurrencyCalculator_Click);
            // 
            // ctrlCurrenciesScreen_FindCurency2
            // 
            this.ctrlCurrenciesScreen_FindCurency2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlCurrenciesScreen_FindCurency2.CurrencyTitle = "Currency Code :";
            this.ctrlCurrenciesScreen_FindCurency2.Location = new System.Drawing.Point(460, 3);
            this.ctrlCurrenciesScreen_FindCurency2.Name = "ctrlCurrenciesScreen_FindCurency2";
            this.ctrlCurrenciesScreen_FindCurency2.Size = new System.Drawing.Size(435, 355);
            this.ctrlCurrenciesScreen_FindCurency2.TabIndex = 1;
            // 
            // ctrlCurrenciesScreen_FindCurency1
            // 
            this.ctrlCurrenciesScreen_FindCurency1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlCurrenciesScreen_FindCurency1.CurrencyTitle = "Currency Code :";
            this.ctrlCurrenciesScreen_FindCurency1.Location = new System.Drawing.Point(4, 3);
            this.ctrlCurrenciesScreen_FindCurency1.Name = "ctrlCurrenciesScreen_FindCurency1";
            this.ctrlCurrenciesScreen_FindCurency1.Size = new System.Drawing.Size(435, 355);
            this.ctrlCurrenciesScreen_FindCurency1.TabIndex = 0;
            // 
            // ctrlCurrenciesScreen_CurrencyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.btnCurrencyCalculator);
            this.Controls.Add(this.txtAmountToExchange);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ctrlCurrenciesScreen_FindCurency2);
            this.Controls.Add(this.ctrlCurrenciesScreen_FindCurency1);
            this.Name = "ctrlCurrenciesScreen_CurrencyCalculator";
            this.Size = new System.Drawing.Size(897, 590);
            this.Load += new System.EventHandler(this.ctrlCurrenciesScreen_CurrencyCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlCurrenciesScreen_FindCurency ctrlCurrenciesScreen_FindCurency1;
        private ctrlCurrenciesScreen_FindCurency ctrlCurrenciesScreen_FindCurency2;
        private Guna.UI2.WinForms.Guna2GradientButton btnCurrencyCalculator;
        private Guna.UI2.WinForms.Guna2TextBox txtAmountToExchange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

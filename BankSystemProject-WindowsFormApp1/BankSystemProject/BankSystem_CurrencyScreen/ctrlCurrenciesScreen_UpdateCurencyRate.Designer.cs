namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_CurrencyScreen
{
    partial class ctrlCurrenciesScreen_UpdateCurencyRate
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
            this.txtNewCurrencyRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdateCurrencyRate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ctrlCurrenciesScreen_FindCurency1 = new BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_CurrencyScreen.ctrlCurrenciesScreen_FindCurency();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewCurrencyRate
            // 
            this.txtNewCurrencyRate.Animated = true;
            this.txtNewCurrencyRate.BorderColor = System.Drawing.Color.Gray;
            this.txtNewCurrencyRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewCurrencyRate.DefaultText = "";
            this.txtNewCurrencyRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewCurrencyRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewCurrencyRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewCurrencyRate.DisabledState.Parent = this.txtNewCurrencyRate;
            this.txtNewCurrencyRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewCurrencyRate.FillColor = System.Drawing.Color.Silver;
            this.txtNewCurrencyRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewCurrencyRate.FocusedState.Parent = this.txtNewCurrencyRate;
            this.txtNewCurrencyRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewCurrencyRate.HoverState.Parent = this.txtNewCurrencyRate;
            this.txtNewCurrencyRate.Location = new System.Drawing.Point(30, 492);
            this.txtNewCurrencyRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewCurrencyRate.Name = "txtNewCurrencyRate";
            this.txtNewCurrencyRate.PasswordChar = '\0';
            this.txtNewCurrencyRate.PlaceholderText = "";
            this.txtNewCurrencyRate.SelectedText = "";
            this.txtNewCurrencyRate.ShadowDecoration.Parent = this.txtNewCurrencyRate;
            this.txtNewCurrencyRate.Size = new System.Drawing.Size(299, 32);
            this.txtNewCurrencyRate.TabIndex = 36;
            this.txtNewCurrencyRate.TextChanged += new System.EventHandler(this.txtNewCurrencyRate_TextChanged);
            this.txtNewCurrencyRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewCurrencyRate_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Dubai Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 438);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 40);
            this.label10.TabIndex = 35;
            this.label10.Text = "New Rate (1$) :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnUpdateCurrencyRate
            // 
            this.btnUpdateCurrencyRate.Animated = true;
            this.btnUpdateCurrencyRate.CheckedState.Parent = this.btnUpdateCurrencyRate;
            this.btnUpdateCurrencyRate.CustomImages.Parent = this.btnUpdateCurrencyRate;
            this.btnUpdateCurrencyRate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateCurrencyRate.FillColor2 = System.Drawing.Color.Transparent;
            this.btnUpdateCurrencyRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateCurrencyRate.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCurrencyRate.HoverState.Parent = this.btnUpdateCurrencyRate;
            this.btnUpdateCurrencyRate.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.UpdateBlue;
            this.btnUpdateCurrencyRate.ImageSize = new System.Drawing.Size(50, 50);
            this.btnUpdateCurrencyRate.Location = new System.Drawing.Point(763, 463);
            this.btnUpdateCurrencyRate.Name = "btnUpdateCurrencyRate";
            this.btnUpdateCurrencyRate.PressedColor = System.Drawing.Color.Blue;
            this.btnUpdateCurrencyRate.ShadowDecoration.Parent = this.btnUpdateCurrencyRate;
            this.btnUpdateCurrencyRate.Size = new System.Drawing.Size(70, 61);
            this.btnUpdateCurrencyRate.TabIndex = 37;
            this.btnUpdateCurrencyRate.Click += new System.EventHandler(this.btnUpdateCurrencyRate_Click);
            // 
            // ctrlCurrenciesScreen_FindCurency1
            // 
            this.ctrlCurrenciesScreen_FindCurency1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrlCurrenciesScreen_FindCurency1.CurrencyTitle = "Currency Code :";
            this.ctrlCurrenciesScreen_FindCurency1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlCurrenciesScreen_FindCurency1.Location = new System.Drawing.Point(0, 0);
            this.ctrlCurrenciesScreen_FindCurency1.Name = "ctrlCurrenciesScreen_FindCurency1";
            this.ctrlCurrenciesScreen_FindCurency1.Size = new System.Drawing.Size(897, 379);
            this.ctrlCurrenciesScreen_FindCurency1.TabIndex = 38;
            // 
            // ctrlCurrenciesScreen_UpdateCurencyRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.ctrlCurrenciesScreen_FindCurency1);
            this.Controls.Add(this.btnUpdateCurrencyRate);
            this.Controls.Add(this.txtNewCurrencyRate);
            this.Controls.Add(this.label10);
            this.Name = "ctrlCurrenciesScreen_UpdateCurencyRate";
            this.Size = new System.Drawing.Size(897, 590);
            this.Load += new System.EventHandler(this.ctrlCurrenciesScreen_UpdateCurencyRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnUpdateCurrencyRate;
        private Guna.UI2.WinForms.Guna2TextBox txtNewCurrencyRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ctrlCurrenciesScreen_FindCurency ctrlCurrenciesScreen_FindCurency1;
    }
}

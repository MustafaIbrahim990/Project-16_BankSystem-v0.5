namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_CurrencyScreen
{
    partial class ctrlCurrenciesScreen_FindCurency
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
            this.cbCurrencyCode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCurrencyTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.lblCurrencyCode = new System.Windows.Forms.Label();
            this.lblCurrencyName = new System.Windows.Forms.Label();
            this.lblCurrencyRate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCurrencyCode
            // 
            this.cbCurrencyCode.Animated = true;
            this.cbCurrencyCode.BackColor = System.Drawing.Color.Transparent;
            this.cbCurrencyCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCurrencyCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCurrencyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrencyCode.FillColor = System.Drawing.Color.Silver;
            this.cbCurrencyCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCurrencyCode.FocusedColor = System.Drawing.Color.Empty;
            this.cbCurrencyCode.FocusedState.Parent = this.cbCurrencyCode;
            this.cbCurrencyCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCurrencyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCurrencyCode.FormattingEnabled = true;
            this.cbCurrencyCode.HoverState.Parent = this.cbCurrencyCode;
            this.cbCurrencyCode.ItemHeight = 30;
            this.cbCurrencyCode.ItemsAppearance.Parent = this.cbCurrencyCode;
            this.cbCurrencyCode.Location = new System.Drawing.Point(17, 74);
            this.cbCurrencyCode.Name = "cbCurrencyCode";
            this.cbCurrencyCode.ShadowDecoration.Parent = this.cbCurrencyCode;
            this.cbCurrencyCode.Size = new System.Drawing.Size(328, 36);
            this.cbCurrencyCode.Sorted = true;
            this.cbCurrencyCode.TabIndex = 0;
            this.cbCurrencyCode.SelectedIndexChanged += new System.EventHandler(this.cbCurrencyCode_SelectedIndexChanged);
            this.cbCurrencyCode.Validating += new System.ComponentModel.CancelEventHandler(this.cbCurrencyCode_Validating);
            // 
            // lblCurrencyTitle
            // 
            this.lblCurrencyTitle.AutoSize = true;
            this.lblCurrencyTitle.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyTitle.Location = new System.Drawing.Point(17, 31);
            this.lblCurrencyTitle.Name = "lblCurrencyTitle";
            this.lblCurrencyTitle.Size = new System.Drawing.Size(175, 25);
            this.lblCurrencyTitle.TabIndex = 13;
            this.lblCurrencyTitle.Text = "Currency Code :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Country Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "Currency Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Currency Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 34);
            this.label4.TabIndex = 17;
            this.label4.Text = "Currency Rate (1$) :";
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryName.ForeColor = System.Drawing.Color.Green;
            this.lblCountryName.Location = new System.Drawing.Point(207, 167);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(60, 24);
            this.lblCountryName.TabIndex = 18;
            this.lblCountryName.Text = "[????]";
            // 
            // lblCurrencyCode
            // 
            this.lblCurrencyCode.AutoSize = true;
            this.lblCurrencyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyCode.ForeColor = System.Drawing.Color.Green;
            this.lblCurrencyCode.Location = new System.Drawing.Point(207, 213);
            this.lblCurrencyCode.Name = "lblCurrencyCode";
            this.lblCurrencyCode.Size = new System.Drawing.Size(60, 24);
            this.lblCurrencyCode.TabIndex = 19;
            this.lblCurrencyCode.Text = "[????]";
            // 
            // lblCurrencyName
            // 
            this.lblCurrencyName.AutoSize = true;
            this.lblCurrencyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyName.ForeColor = System.Drawing.Color.Green;
            this.lblCurrencyName.Location = new System.Drawing.Point(207, 259);
            this.lblCurrencyName.Name = "lblCurrencyName";
            this.lblCurrencyName.Size = new System.Drawing.Size(60, 24);
            this.lblCurrencyName.TabIndex = 20;
            this.lblCurrencyName.Text = "[????]";
            // 
            // lblCurrencyRate
            // 
            this.lblCurrencyRate.AutoSize = true;
            this.lblCurrencyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyRate.ForeColor = System.Drawing.Color.Green;
            this.lblCurrencyRate.Location = new System.Drawing.Point(207, 305);
            this.lblCurrencyRate.Name = "lblCurrencyRate";
            this.lblCurrencyRate.Size = new System.Drawing.Size(60, 24);
            this.lblCurrencyRate.TabIndex = 21;
            this.lblCurrencyRate.Text = "[????]";
            // 
            // ctrlCurrenciesScreen_FindCurency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.lblCurrencyRate);
            this.Controls.Add(this.lblCurrencyName);
            this.Controls.Add(this.lblCurrencyCode);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrencyTitle);
            this.Controls.Add(this.cbCurrencyCode);
            this.Name = "ctrlCurrenciesScreen_FindCurency";
            this.Size = new System.Drawing.Size(414, 353);
            this.Load += new System.EventHandler(this.ctrlCurrenciesScreen_FindCurency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbCurrencyCode;
        private System.Windows.Forms.Label lblCurrencyTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblCurrencyRate;
        private System.Windows.Forms.Label lblCurrencyName;
        private System.Windows.Forms.Label lblCurrencyCode;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

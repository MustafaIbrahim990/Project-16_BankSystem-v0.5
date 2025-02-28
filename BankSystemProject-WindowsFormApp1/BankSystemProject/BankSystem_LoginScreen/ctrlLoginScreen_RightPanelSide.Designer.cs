namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_LoginScreen
{
    partial class ctrlLoginScreen_RightPanelSide
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtPassWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnHideShowPassWord = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Our Bank!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserName :";
            // 
            // txtUserName
            // 
            this.txtUserName.Animated = true;
            this.txtUserName.BorderColor = System.Drawing.Color.Gray;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.Parent = this.txtUserName;
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FillColor = System.Drawing.Color.Silver;
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedState.Parent = this.txtUserName;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.HoverState.Parent = this.txtUserName;
            this.txtUserName.Location = new System.Drawing.Point(20, 226);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.ShadowDecoration.Parent = this.txtUserName;
            this.txtUserName.Size = new System.Drawing.Size(421, 32);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FillColor2 = System.Drawing.Color.Gray;
            this.btnLogin.Font = new System.Drawing.Font("Footlight MT Light", 15F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(20, 468);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(421, 56);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Animated = true;
            this.txtPassWord.BorderColor = System.Drawing.Color.Gray;
            this.txtPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassWord.DefaultText = "";
            this.txtPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.DisabledState.Parent = this.txtPassWord;
            this.txtPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.FillColor = System.Drawing.Color.Silver;
            this.txtPassWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord.FocusedState.Parent = this.txtPassWord;
            this.txtPassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord.HoverState.Parent = this.txtPassWord;
            this.txtPassWord.Location = new System.Drawing.Point(20, 350);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.PlaceholderText = "";
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.ShadowDecoration.Parent = this.txtPassWord;
            this.txtPassWord.Size = new System.Drawing.Size(421, 32);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            this.txtPassWord.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassWord_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "PassWord :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnHideShowPassWord
            // 
            this.btnHideShowPassWord.Animated = true;
            this.btnHideShowPassWord.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnHideShowPassWord.CheckedState.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.ShowPassWord;
            this.btnHideShowPassWord.CheckedState.Parent = this.btnHideShowPassWord;
            this.btnHideShowPassWord.CustomImages.Parent = this.btnHideShowPassWord;
            this.btnHideShowPassWord.FillColor = System.Drawing.Color.Transparent;
            this.btnHideShowPassWord.FillColor2 = System.Drawing.Color.Transparent;
            this.btnHideShowPassWord.Font = new System.Drawing.Font("Footlight MT Light", 15F);
            this.btnHideShowPassWord.ForeColor = System.Drawing.Color.White;
            this.btnHideShowPassWord.HoverState.Parent = this.btnHideShowPassWord;
            this.btnHideShowPassWord.Image = global::BankSystemProject_WindowsFormApp1.Properties.Resources.HidePassWord;
            this.btnHideShowPassWord.ImageSize = new System.Drawing.Size(37, 37);
            this.btnHideShowPassWord.Location = new System.Drawing.Point(467, 344);
            this.btnHideShowPassWord.Name = "btnHideShowPassWord";
            this.btnHideShowPassWord.PressedColor = System.Drawing.Color.Blue;
            this.btnHideShowPassWord.ShadowDecoration.Parent = this.btnHideShowPassWord;
            this.btnHideShowPassWord.Size = new System.Drawing.Size(56, 38);
            this.btnHideShowPassWord.TabIndex = 7;
            this.btnHideShowPassWord.TabStop = false;
            this.btnHideShowPassWord.Click += new System.EventHandler(this.btnHideShowPassWord_Click);
            // 
            // ctrlLoginScreen_RightPanelSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnHideShowPassWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ctrlLoginScreen_RightPanelSide";
            this.Size = new System.Drawing.Size(897, 702);
            this.Load += new System.EventHandler(this.ctrlLoginScreen_RightPanelSide_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassWord;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btnHideShowPassWord;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

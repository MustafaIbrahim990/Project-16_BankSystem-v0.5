using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystem_BusinessLayer;

namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_LoginScreen
{
    public partial class ctrlLoginScreen_RightPanelSide : UserControl
    {
        //Properties :-
        private byte _LoginAttempts { get; set; }


        //Private Methods :-
        private bool _IsEmpty(string Text)
        {
            return (string.IsNullOrWhiteSpace(Text));
        }

        private void _SetErrorProvider(Control control, string ErrorMessage)
        {
            if (_IsEmpty(control.Text))
            {
                errorProvider1.SetError(control, ErrorMessage);
            }
            else
            {
                errorProvider1.SetError(control, "");
            }
        }

        private bool _IsUserNameANDPassWordExists(string UserName, string PassWord)
        {
            return clsUser.IsUserExists(UserName, PassWord);
        }

        private void _DisableControl(Control control)
        {
            control.Enabled = false;
        }

        private void DisableControlAfterLockedAccount()
        {
            _DisableControl(txtUserName);
            _DisableControl(txtPassWord);
            _DisableControl(btnHideShowPassWord);
            _DisableControl(btnLogin);
        }


        //Constructor :-
        public ctrlLoginScreen_RightPanelSide()
        {
            InitializeComponent();
        }

        private void ctrlLoginScreen_RightPanelSide_Load(object sender, EventArgs e)
        {
            _LoginAttempts = 3;
        }


        //UserName :-
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtUserName.Text))
            {
                _SetErrorProvider(txtUserName, "Please Enter UserName!");
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }


        //PassWord :-
        private void txtPassWord_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtPassWord.Text))
            {
                _SetErrorProvider(txtPassWord, "Please Enter PassWord!");
            }
            else
            {
                errorProvider1.SetError(txtPassWord, "");
            }
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {

        }


        //Hide Or Show PassWord :-
        private void btnHideShowPassWord_Click(object sender, EventArgs e)
        {
            if (btnHideShowPassWord.Checked)
                txtPassWord.PasswordChar = '\0';
            else
                txtPassWord.PasswordChar = '*';
        }


        //Login :-
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_IsEmpty(txtUserName.Text) || _IsEmpty(txtPassWord.Text))
            {
                MessageBox.Show("Please Fill All The Information!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_IsUserNameANDPassWordExists(txtUserName.Text, txtPassWord.Text))
            {
                _LoginAttempts--;

                if (_LoginAttempts == 0)
                {
                    DisableControlAfterLockedAccount();
                    MessageBox.Show("Your Account Locked After 3 Failed attempts, Please Try Again Later!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show($"Invalid UserName Or PassWord!\nYou have {_LoginAttempts} attempts before Lock Your Account!");
                return;
            }

            _LoginAttempts = 3;
            frmMainScreen frm = new frmMainScreen(txtUserName.Text, txtPassWord.Text);
            frm.ShowDialog();
        }
    }
}
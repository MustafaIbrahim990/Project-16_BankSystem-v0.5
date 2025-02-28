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

namespace BankSystemProject_WindowsFormApp1
{
    public partial class ctrlManageUsersScreen_AddNewUser : UserControl
    {
        //Enums :-
        enum enPermissions { eManageClients = 1, eManageUsers = 2, eTransactions = 4, eCurrencyExchange = 8, eFullAccess = -1 };


        //Properties :-
        private clsUser _UserInfo;
        private int _Permissions { get; set; }

        private bool _IsUserNameDone { get; set; }
        private bool _IsPassWordDone { get; set; }
        private bool _IsFirstNameDone { get; set; }
        private bool _IsLastNameDone { get; set; }
        private bool _IsPhoneDone { get; set; }
        private bool _IsEmailDone { get; set; }
        private bool _IsPermissionsDone { get; set; }


        //Private Methods :-
        private bool _IsEmpty(string Text)
        {
            return string.IsNullOrWhiteSpace(Text);
        }


        private bool _IsNumber(string Text)
        {
            return int.TryParse(Text, out int result);
        }

        private bool _IsEmailValid(string Text)
        {
            return Text.Contains("@gmail.com");
        }


        private bool _SentErrorProvider(Control control, string ErrorMessage)
        {
            errorProvider1.SetError(control, ErrorMessage);
            return true;
        }


        private void _GetFillObject()
        {
            _UserInfo = new clsUser();

            _UserInfo.FirstName = txtFirstName.Text;
            _UserInfo.LastName = txtLastName.Text;
            _UserInfo.Phone = txtPhone.Text;
            _UserInfo.Email = txtEmail.Text;
            _UserInfo.UserName = txtUserName.Text;
            _UserInfo.PassWord = txtPassWord.Text;
            _UserInfo.Permissions = _GetUserPermissions();
        }


        private void _Save()
        {
            _GetFillObject();

            if (_UserInfo.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Error : Data is Not Saved Successfully.");
            }
        }


        private bool _IsReady()
        {
            return _IsFirstNameDone && _IsLastNameDone && _IsPhoneDone && _IsEmailDone && _IsUserNameDone && _IsPassWordDone;
        }


        private void _ClearFileds()
        {
            txtUserName.Clear();
            txtPassWord.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            rbNo.Checked = true;
            chbManageClients.Checked = false;
            chbManageUsers.Checked = false;
            chbTransactions.Checked = false;
            chbCurrencyExchange.Checked = false;
        }


        private void _MakeChecked(CheckBox chb)
        {
            chb.Checked = true;
        }


        private void _MakeUnChecked(CheckBox chb)
        {
            chb.Checked = false;
        }


        private int _GetUserPermissions()
        {
            if (rbYes.Checked)
            {
                return (int)enPermissions.eFullAccess;
            }

            _Permissions = 0;
            if (chbManageClients.Checked)
            {
                _Permissions += (int)enPermissions.eManageClients;
            }

            if (chbManageUsers.Checked)
            {
                _Permissions += (int)enPermissions.eManageUsers;
            }

            if (chbTransactions.Checked)
            {
                _Permissions += (int)enPermissions.eTransactions;
            }

            if (chbCurrencyExchange.Checked)
            {
                _Permissions += (int)enPermissions.eCurrencyExchange;
            }

            //Full Access is -1 Or 15 :-
            if (_Permissions == 15)
            {
                return -1;
            }
            return _Permissions;
        }


        //Constructor :-
        public ctrlManageUsersScreen_AddNewUser()
        {
            InitializeComponent();
        }

        private void ctrlManageUsersScreen_AddNewUser_Load(object sender, EventArgs e)
        {

        }


        //UserName :-
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtUserName.Text))
            {
                _SentErrorProvider(txtUserName, "Please Enter UserName!");
                _IsUserNameDone = false;
                return;
            }

            if (clsUser.IsUserExists(txtUserName.Text))
            {
                _SentErrorProvider(txtUserName, $"User With UserName [{txtUserName.Text}] is Already Used, Please Enter another One!");
                _IsUserNameDone = false;
                return;
            }

            errorProvider1.SetError(txtUserName, "");
            _IsUserNameDone = true;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }


        //PassWord :-
        private void txtPassWord_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtPassWord.Text))
            {
                _SentErrorProvider(txtPassWord, "Please Enter PassWord!");
                _IsPassWordDone = false;
                return;
            }

            errorProvider1.SetError(txtPassWord, "");
            _IsPassWordDone = true;
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {

        }


        //FirstName :-
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtFirstName.Text))
            {
                _SentErrorProvider(txtFirstName, "Please Enter FirstName!");
                _IsFirstNameDone = false;
                return;
            }

            errorProvider1.SetError(txtFirstName, "");
            _IsFirstNameDone = true;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }


        //LastName :-
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtLastName.Text))
            {
                _SentErrorProvider(txtLastName, "Please Enter LastName!");
                _IsLastNameDone = false;
                return;
            }

            errorProvider1.SetError(txtLastName, "");
            _IsLastNameDone = true;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }


        //Phone :-
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtPhone.Text))
            {
                _SentErrorProvider(txtPhone, "Please Enter Phone Number!");
                _IsPhoneDone = false;
                return;
            }

            if (!_IsNumber(txtPhone.Text))
            {
                _SentErrorProvider(txtPhone, "The Phone Number Must be Consist Of 10 Digits!");
                _IsPhoneDone = false;
                return;
            }
            errorProvider1.SetError(txtPhone, "");
            _IsPhoneDone = true;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }


        //Email :-
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtEmail.Text))
            {
                _SentErrorProvider(txtEmail, "Please Enter Email!");
                _IsEmailDone = false;
                return;
            }

            if (!_IsEmailValid(txtEmail.Text))
            {
                _SentErrorProvider(txtEmail, "Invalid Email, Must be Include an '@gmail.com' in The Email Address.");
                _IsEmailDone = false;
                return;
            }
            errorProvider1.SetError(txtEmail, "");
            _IsEmailDone = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }


        //Permissions :-
        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYes.Checked)
            {
                _MakeChecked(chbManageClients);
                _MakeChecked(chbManageUsers);
                _MakeChecked(chbTransactions);
                _MakeChecked(chbCurrencyExchange);
            }
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            _MakeUnChecked(chbManageClients);
            _MakeUnChecked(chbManageUsers);
            _MakeUnChecked(chbTransactions);
            _MakeUnChecked(chbCurrencyExchange);
        }

        
        //Add New User :-
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (!_IsReady())
            {
                MessageBox.Show("Please Fill All The Information!", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Are Your Sure You Want to Add This User?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                _Save();
                _ClearFileds();
            }
        }
    }
}
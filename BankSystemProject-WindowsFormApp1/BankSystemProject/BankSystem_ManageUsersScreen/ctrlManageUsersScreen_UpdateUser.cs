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

namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_ManageUsersScreen
{
    public partial class ctrlManageUsersScreen_UpdateUser : UserControl
    {
        //Enums :-
        enum enPermissions { eManageClients = 1, eManageUsers = 2, eTransactions = 4, eCurrencyExchange = 8, eFullAccess = -1 };


        //Properties :-
        private clsUser _UserInfo;
        private int _Permissions { get; set; }

        private bool _IsFilterByUserNameDone { get; set; }
        private bool _IsPassWordDone { get; set; }
        private bool _IsFirstNameDone { get; set; }
        private bool _IsLastNameDone { get; set; }
        private bool _IsPhoneDone { get; set; }
        private bool _IsEmailDone { get; set; }
        private bool _IsUserInfoFull { get; set; }
        private bool _IsFoundUser { get; set; }


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


        private void _PrintUserPermissions()
        {
            if (_UserInfo.Permissions == (int)enPermissions.eFullAccess)
            {
                rbYes.Checked = true;
                _MakeChecked(chbManageClients);
                _MakeChecked(chbManageUsers);
                _MakeChecked(chbTransactions);
                _MakeChecked(chbCurrencyExchange);
                return;
            }

            if ((_UserInfo.Permissions & (int)enPermissions.eManageClients) == (int)enPermissions.eManageClients)
            {
                _MakeChecked(chbManageClients);
            }

            if ((_UserInfo.Permissions & (int)enPermissions.eManageUsers) == (int)enPermissions.eManageUsers)
            {
                _MakeChecked(chbManageUsers);
            }

            if ((_UserInfo.Permissions & (int)enPermissions.eTransactions) == (int)enPermissions.eTransactions)
            {
                _MakeChecked(chbTransactions);
            }

            if ((_UserInfo.Permissions & (int)enPermissions.eCurrencyExchange) == (int)enPermissions.eCurrencyExchange)
            {
                _MakeChecked(chbCurrencyExchange);
            }
        }


        private void _PrintUserInfo()
        {
            txtUserName.Text = _UserInfo.UserName;
            txtPassWord.Text = _UserInfo.PassWord;
            txtFirstName.Text = _UserInfo.FirstName;
            txtLastName.Text = _UserInfo.LastName;
            txtPhone.Text = _UserInfo.Phone;
            txtEmail.Text = _UserInfo.Email;
            _PrintUserPermissions();
        }


        private bool _GetUserInfo()
        {
            _UserInfo = clsUser.GetLongDetails(txtFilterByUserName.Text);

            if (_UserInfo == null)
            {
                return false;
            }
            _IsFirstNameDone = true;
            _IsLastNameDone = true;
            _IsPhoneDone = true;
            _IsEmailDone = true;
            _IsPassWordDone = true;
            _IsPassWordDone = true;
            return true;
        }


        private bool _IsReadyToSearch()
        {
            return _IsFilterByUserNameDone;
        }


        private void _GetFillObject()
        {
            _UserInfo.FirstName = txtFirstName.Text;
            _UserInfo.LastName = txtLastName.Text;
            _UserInfo.Phone = txtPhone.Text;
            _UserInfo.Email = txtEmail.Text;
            _UserInfo.PassWord = txtPassWord.Text;
            _UserInfo.Permissions = _GetUserPermissions();
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

            //Full Access is (-1) Or (15) :-
            if (_Permissions == 15)
            {
                return (int)enPermissions.eFullAccess;
            }
            return _Permissions;
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


        private bool _IsReady()
        {
            return _IsFoundUser;
        }


        //Constructor :-
        public ctrlManageUsersScreen_UpdateUser()
        {
            InitializeComponent();
        }

        private void ctrlManageUsersScreen_UpdateUser_Load(object sender, EventArgs e)
        {
            txtUserName.ReadOnly = true;
            txtUserName.ForeColor = Color.Black;
        }


        //Filter User By UserName :-
        private void txtFilterByUserName_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtFilterByUserName.Text))
            {
                _SentErrorProvider(txtFilterByUserName, "Please Enter UserName!");
                _IsFilterByUserNameDone = false;
                return;
            }

            if (!clsUser.IsUserExists(txtFilterByUserName.Text))
            {
                _SentErrorProvider(txtFilterByUserName, $"User With UserName [{txtFilterByUserName.Text}] is Not Found, Please Enter another One!");
                _IsFilterByUserNameDone = false;
                return;
            }

            errorProvider1.SetError(txtFilterByUserName, "");
            _IsFilterByUserNameDone = true;
        }

        private void txtFilterByUserName_TextChanged(object sender, EventArgs e)
        {

        }


        //UserName :-
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            
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


        //Permissions If Yes :-
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


        //Permissions If No :-
        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            _MakeUnChecked(chbManageClients);
            _MakeUnChecked(chbManageUsers);
            _MakeUnChecked(chbTransactions);
            _MakeUnChecked(chbCurrencyExchange);
        }


        //Find User :-
        private void btnFindUser_Click(object sender, EventArgs e)
        {
            if (!_IsReadyToSearch())
            {
                MessageBox.Show("Please Enter UserName!");
                _IsFoundUser = false;
                return;
            }

            if (!_GetUserInfo())
            {
                MessageBox.Show($"User With UserName [{txtFilterByUserName.Text}] don't have Info In The System");
                _IsFoundUser = false;
                return;
            }
            _IsFoundUser = true;
            _PrintUserInfo();
        }


        //Update User :-
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (!_IsReady())
            {
                MessageBox.Show("Please Fill All The Information!", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Are Your Sure You Want to Update This User?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                _Save();
                _ClearFileds();
            }
        }
    }
}
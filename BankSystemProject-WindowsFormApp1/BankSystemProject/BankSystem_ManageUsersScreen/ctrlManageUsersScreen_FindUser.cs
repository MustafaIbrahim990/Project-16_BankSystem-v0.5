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
    public partial class ctrlManageUsersScreen_FindUser : UserControl
    {
        //Enums :-
        enum enPermissions { eManageClients = 1, eManageUsers = 2, eTransactions = 4, eCurrencyExchange = 8, eFullAccess = -1 };

        //Properties :-
        private clsUser _UserInfo;

        private bool _IsUserNameDone { get; set; }
        private bool _IsUserInfoFull { get; set; }
        private bool _IsFoundUser { get; set; }
        private string _UserName { get; set; }

        public string UserName
        {
            get { return _UserName; }
        }
        public bool IsFoundUser
        {
            get { return _IsFoundUser; }
        }


        //Private Methods :-
        private bool _IsEmpty(string Text)
        {
            return string.IsNullOrWhiteSpace(Text);
        }


        private bool _SentErrorProvider(Control control, string ErrorMessage)
        {
            errorProvider1.SetError(control, ErrorMessage);
            return true;
        }


        private string _GetPermissionsName()
        {
            if (_UserInfo.Permissions == (int)enPermissions.eFullAccess)
            {
                return "Full Access";
            }

            string PermissionsName = "";

            if ((_UserInfo.Permissions & (int)enPermissions.eManageClients) == (int)enPermissions.eManageClients)
            {
                PermissionsName += "Manage Clients, ";
            }

            if ((_UserInfo.Permissions & (int)enPermissions.eManageUsers) == (int)enPermissions.eManageUsers) 
            {
                PermissionsName += "Manage Users, ";
            }

            if ((_UserInfo.Permissions & (int)enPermissions.eTransactions) == (int)enPermissions.eTransactions) 
            {
                PermissionsName += "Transactions, ";
            }

            if ((_UserInfo.Permissions & (int)enPermissions.eCurrencyExchange) == (int)enPermissions.eCurrencyExchange) 
            {
                PermissionsName += "Currency Exchange, ";
            }

            if (_IsEmpty(PermissionsName)) 
            {
                return "Have No Permissions.";
            }
            return PermissionsName.Remove(PermissionsName.Length - 2);
        }


        private void _PrintUserInfo()
        {
            lblFullName.Text = _UserInfo.FirstName + " " + _UserInfo.LastName;
            lblPhone.Text = _UserInfo.Phone;
            lblEmail.Text = _UserInfo.Email;
            lblUserName.Text = _UserInfo.UserName;
            lblPassWord.Text = _UserInfo.PassWord;
            lblPermissions.Text = _GetPermissionsName();
        }


        private void _GetUserInfo()
        {
            _UserInfo = clsUser.GetLongDetails(txtFilterByUserName.Text);

            if (_UserInfo == null)
            {
                _IsUserInfoFull = false;
                return;
            }
            _IsUserInfoFull = true;
        }


        private bool _IsReady()
        {
            return _IsUserNameDone && _IsUserInfoFull;
        }


        //Constructor :-
        public ctrlManageUsersScreen_FindUser()
        {
            InitializeComponent();
        }

        private void ctrlManageUsersScreen_FindUser_Load(object sender, EventArgs e)
        {

        }


        //Find User By UserName :-
        private void txtFilterByUserName_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtFilterByUserName.Text))
            {
                _SentErrorProvider(txtFilterByUserName, "Please Enter UserName!");
                _IsUserNameDone = false;
                return;
            }

            if (!clsUser.IsUserExists(txtFilterByUserName.Text))
            {
                _SentErrorProvider(txtFilterByUserName, $"User With UserName [{txtFilterByUserName.Text}] is Not Found, Please Enter another One!");
                _IsUserNameDone = false;
                return;
            }

            errorProvider1.SetError(txtFilterByUserName, "");
            _IsUserNameDone = true;
            _UserName = txtFilterByUserName.Text;
        }

        private void txtFilterByUserName_TextChanged(object sender, EventArgs e)
        {

        }


        //Find User :-
        private void btnFindUser_Click(object sender, EventArgs e)
        {
            _GetUserInfo();
            if (!_IsReady())
            {
                MessageBox.Show("Please Enter UserName!");
                _IsFoundUser = false;
                return;
            }
            _IsFoundUser = true;
            _PrintUserInfo();
        }
    }
}
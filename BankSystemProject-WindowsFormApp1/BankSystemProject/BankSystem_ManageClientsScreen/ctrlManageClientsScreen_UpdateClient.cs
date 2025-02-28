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

namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_ManageClientsScreen
{
    public partial class ctrlManageClientsScreen_UpdateClient : UserControl
    {
        //Properties :-
        private clsClient _ClientInfo;

        private bool _IsFilterByAccountNumberDone { get; set; }
        private bool _IsPINCodeDone { get; set; }
        private bool _IsFirstNameDone { get; set; }
        private bool _IsLastNameDone { get; set; }
        private bool _IsPhoneDone { get; set; }
        private bool _IsEmailDone { get; set; }
        private bool _IsAccountBalanceDone { get; set; }
        private bool _IsClientInfoFull { get; set; }
        private bool _IsFoundClient { get; set; }


        //Private Methods :-
        private bool _IsEmpty(string Text)
        {
            return string.IsNullOrWhiteSpace(Text);
        }


        private bool _IsNumber(string Text)
        {
            return int.TryParse(Text, out int result);
        }


        private bool _IsDecimalNumber(string Text)
        {
            return decimal.TryParse(Text, out decimal result);
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


        private void _PrintClientInfo()
        {
            txtAccountNumber.Text = _ClientInfo.AccountNumber;
            txtPINCode.Text = _ClientInfo.PINCode;
            txtFirstName.Text = _ClientInfo.FirstName;
            txtLastName.Text = _ClientInfo.LastName;
            txtPhone.Text = _ClientInfo.Phone;
            txtEmail.Text = _ClientInfo.Email;
            txtAccountBalance.Text = _ClientInfo.AccountBalance.ToString();
        }


        private void _GetClientInfo()
        {
            _ClientInfo = clsClient.GetLongDetails(txtFilterByAccountNumber.Text);

            if (_ClientInfo == null)
            {
                _IsClientInfoFull = false;
                return;
            }
            _IsClientInfoFull = true;
            _IsFirstNameDone = true;
            _IsLastNameDone = true;
            _IsPhoneDone = true;
            _IsEmailDone = true;
            _IsPINCodeDone = true;
            _IsAccountBalanceDone = true;
        }


        private bool _IsReadyToSearch()
        {
            return _IsFilterByAccountNumberDone && _IsClientInfoFull;
        }


        private void _GetFillObject()
        {
            _ClientInfo.FirstName = txtFirstName.Text;
            _ClientInfo.LastName = txtLastName.Text;
            _ClientInfo.Phone = txtPhone.Text;
            _ClientInfo.Email = txtEmail.Text;
            _ClientInfo.PINCode = txtPINCode.Text;
            _ClientInfo.AccountBalance = Convert.ToDecimal(txtAccountBalance.Text);
        }


        private void _Save()
        {
            _GetFillObject();

            if (_ClientInfo.Save())
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
            txtAccountNumber.Clear();
            txtPINCode.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAccountBalance.Clear();
        }


        private bool _IsReady()
        {
            return _IsFoundClient && _IsFirstNameDone && _IsLastNameDone && _IsPhoneDone && _IsEmailDone && _IsPINCodeDone && _IsAccountBalanceDone;
        }


        //Constructor :-
        public ctrlManageClientsScreen_UpdateClient()
        {
            InitializeComponent();
        }

        private void ctrlManageClientsScreen_UpdateClient_Load(object sender, EventArgs e)
        {
            txtAccountNumber.ReadOnly = true;
            txtAccountNumber.ForeColor = Color.Black;
        }


        //Find Client By AccountNumber :-
        private void txtFilterByAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtFilterByAccountNumber.Text))
            {
                _SentErrorProvider(txtFilterByAccountNumber, "Please Enter AccountNumber!");
                _IsFilterByAccountNumberDone = false;
                return;
            }

            if (!clsClient.IsClientExists(txtFilterByAccountNumber.Text))
            {
                _SentErrorProvider(txtFilterByAccountNumber, $"Client With AccountNumber [{txtFilterByAccountNumber.Text}] is Not Found, Please Enter another One!");
                _IsFilterByAccountNumberDone = false;
                return;
            }

            errorProvider1.SetError(txtFilterByAccountNumber, "");
            _IsFilterByAccountNumberDone = true;
        }

        private void txtFilterByAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }


        //AccountNumber :-
        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }


        //PINCode :-
        private void txtPINCode_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtPINCode.Text))
            {
                _SentErrorProvider(txtPINCode, "Please Enter PINCode!");
                _IsPINCodeDone = false;
                return;
            }

            errorProvider1.SetError(txtPINCode, "");
            _IsPINCodeDone = true;
        }

        private void txtPINCode_TextChanged(object sender, EventArgs e)
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


        //AccountBalance :-
        private void txtAccountBalance_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtAccountBalance.Text))
            {
                _SentErrorProvider(txtAccountBalance, "Please Enter Account Balance!");
                _IsAccountBalanceDone = false;
                return;
            }

            if (!_IsDecimalNumber(txtAccountBalance.Text))
            {
                _SentErrorProvider(txtAccountBalance, "Account Balance Must Be Number!");
                _IsAccountBalanceDone = false;
                return;
            }
            errorProvider1.SetError(txtAccountBalance, "");
            _IsAccountBalanceDone = true;
        }

        private void txtAccountBalance_TextChanged(object sender, EventArgs e)
        {

        }


        //Find Client :-
        private void btnFindClient_Click(object sender, EventArgs e)
        {
            _GetClientInfo();
            if (!_IsReadyToSearch())
            {
                MessageBox.Show("Please Enter Account Number!");
                _IsFoundClient = false;
                return;
            }
            _IsFoundClient = true;
            _PrintClientInfo();
        }


        //Update Client :-
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (!_IsReady())
            {
                MessageBox.Show("Please Fill All The Information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are Your Sure You Want to Update This Client?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                _Save();
                _ClearFileds();
            }
        }
    }
}
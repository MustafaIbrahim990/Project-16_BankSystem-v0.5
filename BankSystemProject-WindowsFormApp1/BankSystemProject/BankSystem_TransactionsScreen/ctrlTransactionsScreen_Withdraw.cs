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

namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_TransactionsScreen
{
    public partial class ctrlTransactionsScreen_Withdraw : UserControl
    {
        //Properties :-
        private clsClient _ClientInfo;

        private bool _IsAccountNumberDone { get; set; }
        private bool _IsWithdrawAmountDone { get; set; }


        //Private Methods :-
        private bool _IsEmpty(string Text)
        {
            return string.IsNullOrWhiteSpace(Text);
        }


        private bool _IsDecimalNumber(string Text)
        {
            return decimal.TryParse(Text, out decimal result);
        }


        private bool _SentErrorProvider(Control control, string ErrorMessage)
        {
            errorProvider1.SetError(control, ErrorMessage);
            return true;
        }


        private bool _IsReadyToDeposit()
        {
            return _IsAccountNumberDone && _IsWithdrawAmountDone;
        }


        private void _GetEmptyObject()
        {
            _ClientInfo = new clsClient();
        }


        private void _ClearCurrentBalance()
        {
            lblCurrentBalance.Text = "[????]";
            lblCurrentBalance.Visible = false;
        }


        private void _ClearFileds()
        {
            _ClientInfo = new clsClient();
            txtAccountNumber.Clear();
            txtWithdrawAmount.Clear();
            _ClearCurrentBalance();
        }


        private void _GetFullObject()
        {
            _ClientInfo = clsClient.GetShortDetails(txtAccountNumber.Text);
        }


        private void _PrintCurrentBalance()
        {
            lblCurrentBalance.Text = _ClientInfo.AccountBalance.ToString() + " $";
            lblCurrentBalance.Visible = true;
        }


        private void _Save()
        {
            if (_ClientInfo.Withdraw(txtAccountNumber.Text, _ClientInfo.AccountBalance, Convert.ToDecimal(txtWithdrawAmount.Text)))
            {
                _ClientInfo = clsClient.GetShortDetails(txtAccountNumber.Text);
                MessageBox.Show($"Amount Withdraw Successfully. New Balance is : {_ClientInfo.AccountBalance} $");
            }
            else
            {
                MessageBox.Show("Withdraw Amount is Failed!");
            }
        }


        //Constructor :-
        public ctrlTransactionsScreen_Withdraw()
        {
            InitializeComponent();
        }

        private void ctrlTransactionsScreen_Withdraw_Load(object sender, EventArgs e)
        {
            _ClearCurrentBalance();
            txtAccountNumber.Focus();
        }


        //AccountNumber :-
        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtAccountNumber.Text))
            {
                _SentErrorProvider(txtAccountNumber, "Please Enter AccountNumber!");
                _IsAccountNumberDone = false;
                _GetEmptyObject();
                _ClearCurrentBalance();
                return;
            }

            if (!clsClient.IsClientExists(txtAccountNumber.Text))
            {
                _SentErrorProvider(txtAccountNumber, $"Client With AccountNumber [{txtAccountNumber.Text}] is Not Found, Please Enter another One!");
                _IsAccountNumberDone = false;
                _GetEmptyObject();
                _ClearCurrentBalance();
                return;
            }

            errorProvider1.SetError(txtAccountNumber, "");
            _IsAccountNumberDone = true;
            _GetFullObject();
            _PrintCurrentBalance();
        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }


        //Withdraw Amount :-
        private void txtWithdrawAmount_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtWithdrawAmount.Text))
            {
                _SentErrorProvider(txtWithdrawAmount, "Please Enter Withdraw Amount!");
                _IsWithdrawAmountDone = false;
                return;
            }

            if (!_IsDecimalNumber(txtWithdrawAmount.Text))
            {
                _SentErrorProvider(txtWithdrawAmount, "Withdraw Amount Must Be Number!");
                _IsWithdrawAmountDone = false;
                return;
            }
            errorProvider1.SetError(txtWithdrawAmount, "");
            _IsWithdrawAmountDone = true;
        }

        private void txtWithdrawAmount_TextChanged(object sender, EventArgs e)
        {

        }


        //Withdraw :-
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (!_IsReadyToDeposit())
            {
                MessageBox.Show("Please Fill All The Information!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_ClientInfo == null)
            {
                MessageBox.Show($"Client With AccountNumber [{txtAccountNumber.Text}] doesn't have Information in The System!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToDecimal(txtWithdrawAmount.Text) > _ClientInfo.AccountBalance)
            {
                MessageBox.Show($"Client With AccountNumber [{txtAccountNumber.Text}] Can't Withdraw an Amount of {txtWithdrawAmount.Text} Because The Amount in Your Account is {_ClientInfo.AccountBalance} is Not Enough!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are Your Sure You Want to Perform This Transactions?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                _Save();
                _ClearFileds();
            }
        }
    }
}
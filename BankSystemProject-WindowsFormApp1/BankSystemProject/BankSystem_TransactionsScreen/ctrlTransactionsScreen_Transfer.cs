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
    public partial class ctrlTransactionsScreen_Transfer : UserControl
    {
        //Properties :-
        private clsClient _FromClientInfo;
        private clsClient _ToClientInfo;

        private int _ByUserID { get; set; }
        private DateTime _datetime { get; set; }
        private decimal _TransferAmount { get; set; }

        private bool _IsFromAccountNumberDone { get; set; }
        private bool _IsToAccountNumberDone { get; set; }
        private bool _IsTransferAmountDone { get; set; }


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


        private void _GetEmptyObject(clsClient ClientInfo)
        {
            ClientInfo = new clsClient();
        }


        private void _ClearFCurrentBalance()
        {
            lblFCurrentBalance.Text = "[????]";
            lblFCurrentBalance.Visible = false;
        }

        private void _ClearTCurrentBalance()
        {
            lblTCurrentBalance.Text = "[????]";
            lblTCurrentBalance.Visible = false;
        }


        private void _ClearFileds()
        {
            _GetEmptyObject(_FromClientInfo);
            _GetEmptyObject(_ToClientInfo);
            txtFromAccountNumber.Clear();
            txtToAccountNumber.Clear();
            txtTransferAmount.Clear();
            _ClearFCurrentBalance();
            _ClearTCurrentBalance();
        }


        private void _GetFullObject(ref clsClient ClientInfo, string AccountNumber)
        {
            ClientInfo = clsClient.GetShortDetails(AccountNumber);
        }


        private void _PrintFCurrentBalance()
        {
            lblFCurrentBalance.Text = _FromClientInfo.AccountBalance.ToString() + " $";
            lblFCurrentBalance.Visible = true;
        }

        private void _PrintTCurrentBalance()
        {
            lblTCurrentBalance.Text = _ToClientInfo.AccountBalance.ToString() + " $";
            lblTCurrentBalance.Visible = true;
        }


        private void _Save()
        {
            _datetime = DateTime.Now;

            if (clsClient.Transfer(_datetime, txtFromAccountNumber.Text, txtToAccountNumber.Text, _TransferAmount, _ByUserID)) 
            {
                MessageBox.Show($"Amount Transfer Successfully.");
            }
            else
            {
                MessageBox.Show("Transfer Amount is Failed!");
            }
        }


        private bool _IsReadyToTransfer()
        {
            return _IsFromAccountNumberDone && _IsToAccountNumberDone && _IsTransferAmountDone;
        }


        //Constructor :-
        public ctrlTransactionsScreen_Transfer(int UserID)
        {
            InitializeComponent();
            _ByUserID = UserID;
        }

        private void ctrlTransactionsScreen_Transfer_Load(object sender, EventArgs e)
        {
            _ClearFCurrentBalance();
            _ClearTCurrentBalance();
            txtFromAccountNumber.Focus();
        }


        //From AccountNumber :-
        private void txtFromAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtFromAccountNumber.Text))
            {
                _SentErrorProvider(txtFromAccountNumber, "Please Enter AccountNumber!");
                _IsFromAccountNumberDone = false;
                _GetEmptyObject(_FromClientInfo);
                _ClearFCurrentBalance();
                return;
            }

            if (!clsClient.IsClientExists(txtFromAccountNumber.Text))
            {
                _SentErrorProvider(txtFromAccountNumber, $"Client With AccountNumber [{txtFromAccountNumber.Text}] is Not Found, Please Enter another One!");
                _IsFromAccountNumberDone = false;
                _GetEmptyObject(_FromClientInfo);
                _ClearFCurrentBalance();
                return;
            }

            if (txtFromAccountNumber.Text.ToUpper() == txtToAccountNumber.Text.ToUpper())
            {
                _SentErrorProvider(txtFromAccountNumber, $"Client With AccountNumber [{txtFromAccountNumber.Text}] you have Used to Transfer The Amount to, Please Enter another One!");
                _IsFromAccountNumberDone = false;
                _GetEmptyObject(_FromClientInfo);
                _ClearFCurrentBalance();
                return;
            }

            errorProvider1.SetError(txtFromAccountNumber, "");
            _IsFromAccountNumberDone = true;
            _GetFullObject(ref _FromClientInfo, txtFromAccountNumber.Text);
            _PrintFCurrentBalance();
        }

        private void txtFromAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }


        //To AccountNumber :-
        private void txtToAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtToAccountNumber.Text))
            {
                _SentErrorProvider(txtToAccountNumber, "Please Enter AccountNumber!");
                _IsToAccountNumberDone = false;
                _GetEmptyObject(_ToClientInfo);
                _ClearTCurrentBalance();
                return;
            }

            if (!clsClient.IsClientExists(txtToAccountNumber.Text))
            {
                _SentErrorProvider(txtToAccountNumber, $"Client With AccountNumber [{txtToAccountNumber.Text}] is Not Found, Please Enter another One!");
                _IsToAccountNumberDone = false;
                _GetEmptyObject(_ToClientInfo);
                _ClearTCurrentBalance();
                return;
            }

            if (txtToAccountNumber.Text.ToUpper() == txtFromAccountNumber.Text.ToUpper())
            {
                _SentErrorProvider(txtToAccountNumber, $"Client With AccountNumber [{txtToAccountNumber.Text}] you have Used it to Transfer The Amount From it, Please Enter another One!");
                _IsToAccountNumberDone = false;
                _GetEmptyObject(_ToClientInfo);
                _ClearTCurrentBalance();
                return;
            }

            errorProvider1.SetError(txtToAccountNumber, "");
            _IsToAccountNumberDone = true;
            _GetFullObject(ref _ToClientInfo, txtToAccountNumber.Text);
            _PrintTCurrentBalance();
        }

        private void txtToAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }


        //Transfer Amount :-
        private void txtTransferAmount_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtTransferAmount.Text))
            {
                _SentErrorProvider(txtTransferAmount, "Please Enter Transfer Amount!");
                _IsTransferAmountDone = false;
                return;
            }

            if (!_IsDecimalNumber(txtTransferAmount.Text))
            {
                _SentErrorProvider(txtTransferAmount, "Transfer Amount Must Be Number!");
                _IsTransferAmountDone = false;
                return;
            }
            errorProvider1.SetError(txtTransferAmount, "");
            _IsTransferAmountDone = true;
        }

        private void txtTransferAmount_TextChanged(object sender, EventArgs e)
        {

        }


        //Transfer :-
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (!_IsReadyToTransfer())
            {
                MessageBox.Show("Please Fill All The Information!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_FromClientInfo == null)
            {
                MessageBox.Show($"Client With AccountNumber [{txtFromAccountNumber.Text}] doesn't have Information in The System!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_ToClientInfo == null)
            {
                MessageBox.Show($"Client With AccountNumber [{txtToAccountNumber.Text}] doesn't have Information in The System!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TransferAmount = Convert.ToDecimal(txtTransferAmount.Text);

            if (_TransferAmount > _FromClientInfo.AccountBalance)
            {
                MessageBox.Show($"Client With AccountNumber [{txtFromAccountNumber.Text}] Can't Transfer an Amount of {_TransferAmount} $ Because The Amount in Your Account is {_FromClientInfo.AccountBalance} $ is Not Enough!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
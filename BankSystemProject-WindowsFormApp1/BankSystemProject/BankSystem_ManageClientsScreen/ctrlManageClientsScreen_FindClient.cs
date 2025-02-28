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
    public partial class ctrlManageClientsScreen_FindClient : UserControl
    {
        //Properties :-
        private clsClient _ClientInfo;

        private bool _IsAccountNumberDone { get; set; }
        private bool _IsClientInfoFull { get; set; }
        private bool _IsFoundClient { get; set; }
        private string _AccountNumber { get; set; }

        public string AccountNumber
        {
            get { return _AccountNumber; }
        }
        public bool IsFoundClient
        {
            get { return _IsFoundClient; }
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


        private void _PrintClientInfo()
        {
            lblFullName.Text = _ClientInfo.FirstName + " " + _ClientInfo.LastName;
            lblPhone.Text = _ClientInfo.Phone;
            lblEmail.Text = _ClientInfo.Email;
            lblAccountNumber.Text = _ClientInfo.AccountNumber;
            lblPINCode.Text = _ClientInfo.PINCode;
            lblAccountBalance.Text = _ClientInfo.AccountBalance.ToString() + " $";
        }


        private void _GetClientInfo()
        {
            _ClientInfo = clsClient.GetLongDetails(txtAccountNumber.Text);

            if (_ClientInfo == null)
            {
                _IsClientInfoFull = false;
                return;
            }
            _IsClientInfoFull = true;
        }


        private bool _IsReady()
        {
            return _IsAccountNumberDone && _IsClientInfoFull;
        }


        //Constructor :-
        public ctrlManageClientsScreen_FindClient()
        {
            InitializeComponent();
        }

        private void ctrlManageClientsScreen_FindClient_Load(object sender, EventArgs e)
        {
            
        }


        //Find Client By AccountNumber :-
        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtAccountNumber.Text))
            {
                _SentErrorProvider(txtAccountNumber, "Please Enter AccountNumber!");
                _IsAccountNumberDone = false;
                return;
            }

            if (!clsClient.IsClientExists(txtAccountNumber.Text))
            {
                _SentErrorProvider(txtAccountNumber, $"Client With AccountNumber [{txtAccountNumber.Text}] is Not Found, Please Enter another One!");
                _IsAccountNumberDone = false;
                return;
            }

            errorProvider1.SetError(txtAccountNumber, "");
            _IsAccountNumberDone = true;
            _AccountNumber = txtAccountNumber.Text;
        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            
        }


        //Find Client :- 
        private void btnFindClient_Click(object sender, EventArgs e)
        {
            _GetClientInfo();
            if (!_IsReady())
            {
                MessageBox.Show("Please Enter Account Number!");
                _IsFoundClient = false;
                return;
            }
            _IsFoundClient = true;
            _PrintClientInfo();
        }
    }
}
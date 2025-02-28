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

namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_CurrencyScreen
{
    public partial class ctrlCurrenciesScreen_UpdateCurencyRate : UserControl
    {
        //Properties :-
        private clsCurrency _CurrencyInfo;

        private bool _IsNewCurrencyRateDone { get; set; }
        private bool _IsCurrencyObjectFull { get; set; }
        private string _CurrencyCode { get; set; }


        //Private Methods :-
        private bool _IsEmpty(string Text)
        {
            return string.IsNullOrWhiteSpace(Text);
        }


        private bool _IsDoubleNumber(string Text)
        {
            return double.TryParse(Text, out double result);
        }


        private bool _SentErrorProvider(Control control, string ErrorMessage)
        {
            errorProvider1.SetError(control, ErrorMessage);
            return true;
        }


        private bool _IsReadyToUpdate()
        {
            return _IsNewCurrencyRateDone && _IsCurrencyObjectFull;
        }


        private void _GetFullObject()
        {
            _CurrencyCode = ctrlCurrenciesScreen_FindCurency1.CurrencyCode;
            _CurrencyInfo = clsCurrency.GetDetails(_CurrencyCode);
        }


        private void _GetNewCurrencyRate()
        {
            _CurrencyInfo.Rate = Convert.ToDouble(txtNewCurrencyRate.Text);
        }


        private void _Save()
        {
            _GetFullObject();
            _GetNewCurrencyRate();

            if (_CurrencyInfo.Save())
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
            txtNewCurrencyRate.Clear();
            ctrlCurrenciesScreen_FindCurency1.ClearFileds();
        }


        //Constructor :-
        public ctrlCurrenciesScreen_UpdateCurencyRate()
        {
            InitializeComponent();
        }

        private void ctrlCurrenciesScreen_UpdateCurencyRate_Load(object sender, EventArgs e)
        {
            
        }


        //New Currency Rate :-
        private void txtNewCurrencyRate_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtNewCurrencyRate.Text))
            {
                _SentErrorProvider(txtNewCurrencyRate, "Please Enter New Currency Rate!");
                _IsNewCurrencyRateDone = false;
                return;
            }

            if (!_IsDoubleNumber(txtNewCurrencyRate.Text))
            {
                _SentErrorProvider(txtNewCurrencyRate, "Currency Rate Must Be Number!");
                _IsNewCurrencyRateDone = false;
                return;
            }
            errorProvider1.SetError(txtNewCurrencyRate, "");
            _IsNewCurrencyRateDone = true;
        }

        private void txtNewCurrencyRate_TextChanged(object sender, EventArgs e)
        {

        }


        //Update Currency Rate :-
        private void btnUpdateCurrencyRate_Click(object sender, EventArgs e)
        {
            _IsCurrencyObjectFull = ctrlCurrenciesScreen_FindCurency1.IsCurrencyOjectFull;
            if (!_IsReadyToUpdate())
            {
                MessageBox.Show("Please Fill All The Information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are Your Sure You Want to Update This Currency Rate?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                _Save();
                _ClearFileds();
            }
        }
    }
}
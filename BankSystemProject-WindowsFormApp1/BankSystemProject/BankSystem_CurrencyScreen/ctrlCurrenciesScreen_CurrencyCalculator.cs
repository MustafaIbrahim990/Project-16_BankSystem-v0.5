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
    public partial class ctrlCurrenciesScreen_CurrencyCalculator : UserControl
    {
        //Properties :-
        private clsCurrency _CurrencyInfo1;
        private clsCurrency _CurrencyInfo2;

        private bool _IsAmountToExchangeDone { get; set; }
        private bool _IsCurrencyObjectFull1 { get; set; }
        private bool _IsCurrencyObjectFull2 { get; set; }
        private double _AmountToExchange { get; set; }
        private double _AmountAfterExchange { get; set; }


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


        private bool _IsReadyToCalculate()
        {
            return _IsAmountToExchangeDone && _IsCurrencyObjectFull1 && _IsCurrencyObjectFull2;
        }


        private void _GetFullObject()
        {
            _CurrencyInfo1 = ctrlCurrenciesScreen_FindCurency1.CurrencyInfo;
            _CurrencyInfo2 = ctrlCurrenciesScreen_FindCurency2.CurrencyInfo;
        }


        private void _GetAmountToExchange()
        {
            _AmountToExchange = Convert.ToDouble(txtAmountToExchange.Text);
        }


        private void CurrencyCalculate()
        {
            _GetFullObject();
            _GetAmountToExchange();
            _AmountAfterExchange = clsCurrency.CurrencyCalculator(_CurrencyInfo1, _CurrencyInfo2, _AmountToExchange);
        }


        private void _ClearFileds()
        {
            txtAmountToExchange.Clear();
            ctrlCurrenciesScreen_FindCurency1.ClearFileds();
            ctrlCurrenciesScreen_FindCurency2.ClearFileds();
        }


        //Constructor :-
        public ctrlCurrenciesScreen_CurrencyCalculator()
        {
            InitializeComponent();
        }

        private void ctrlCurrenciesScreen_CurrencyCalculator_Load(object sender, EventArgs e)
        {
            _ClearFileds();
            ctrlCurrenciesScreen_FindCurency1.CurrencyTitle = "Convert From";
            ctrlCurrenciesScreen_FindCurency2.CurrencyTitle = "Convert To";
        }


        //Amount to Exchange :-
        private void txtAmountToExchange_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(txtAmountToExchange.Text))
            {
                _SentErrorProvider(txtAmountToExchange, "Please Enter Amount To Exchange!");
                _IsAmountToExchangeDone = false;
                return;
            }

            if (!_IsDoubleNumber(txtAmountToExchange.Text))
            {
                _SentErrorProvider(txtAmountToExchange, "Amount To Exchange Must Be Number!");
                _IsAmountToExchangeDone = false;
                return;
            }
            errorProvider1.SetError(txtAmountToExchange, "");
            _IsAmountToExchangeDone = true;
        }

        private void txtAmountToExchange_TextChanged(object sender, EventArgs e)
        {

        }


        //Currency Calculator :-
        private void btnCurrencyCalculator_Click(object sender, EventArgs e)
        {
            _IsCurrencyObjectFull1 = ctrlCurrenciesScreen_FindCurency1.IsCurrencyOjectFull;
            _IsCurrencyObjectFull2 = ctrlCurrenciesScreen_FindCurency2.IsCurrencyOjectFull;
            if (!_IsReadyToCalculate())
            {
                MessageBox.Show("Please Fill All The Information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CurrencyCalculate();

            MessageBox.Show($"{_AmountToExchange} {_CurrencyInfo1.Code} = {_AmountAfterExchange} {_CurrencyInfo2.Code}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
    }
}
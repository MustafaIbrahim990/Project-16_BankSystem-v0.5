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
    public partial class ctrlCurrenciesScreen_FindCurency : UserControl
    {
        //Properties :-
        private clsCurrency _CurrencyInfo;

        private bool _IsCurrencyCodeDone { get; set; }
        private bool _IsCurrencyObjectFull { get; set; }
        private string _CurrencyCode { get; set; }

        public string CurrencyTitle
        {
            set { lblCurrencyTitle.Text = value; }
            get { return lblCurrencyTitle.Text; }
        }

        public string CurrencyCode
        {
            get { return _CurrencyCode; }
        }

        public clsCurrency CurrencyInfo
        {
            get { return _CurrencyInfo; }
        }

        public bool IsCurrencyOjectFull
        {
            get { return _IsCurrencyObjectFull; }
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


        private void _ClearCurrencyInfo()
        {
            lblCountryName.Text = "[????]";
            lblCurrencyName.Text = "[????]";
            lblCurrencyCode.Text = "[????]";
            lblCurrencyRate.Text = "[????]";
            lblCountryName.Visible = false;
            lblCurrencyName.Visible = false;
            lblCurrencyCode.Visible = false;
            lblCurrencyRate.Visible = false;
        }


        public void ClearFileds()
        {
            _CurrencyInfo = new clsCurrency();
            cbCurrencyCode.SelectedIndex = 0;
            _IsCurrencyCodeDone = true;
            _FindCurrencyInfo();
        }


        private void _FillCurrenciesInfoInComboBox()
        {
            DataTable dtCurrencies = clsCurrency.GetAllCurrencyDetails();

            foreach (DataRow row in dtCurrencies.Rows)
            {
                cbCurrencyCode.Items.Add(row["Code"]);
            }
            cbCurrencyCode.SelectedIndex = 0;
        }


        private bool _IsReadyToSearch()
        {
            return _IsCurrencyCodeDone;
        }


        private void _GetCurrencyInfo()
        {
            _CurrencyInfo = clsCurrency.GetLongDetails(cbCurrencyCode.Text);

            if (_CurrencyInfo == null)
            {
                _IsCurrencyObjectFull = false;
                return;
            }
            _IsCurrencyObjectFull = true;
        }


        private void _PrintCurrencyInfo()
        {
            lblCurrencyName.Text = _CurrencyInfo.Name;
            lblCurrencyCode.Text = _CurrencyInfo.Code;
            lblCurrencyRate.Text = _CurrencyInfo.Rate.ToString();
            lblCountryName.Text = _CurrencyInfo.CountryName;
        }


        private void _FindCurrencyInfo()
        {
            if (!_IsReadyToSearch())
            {
                MessageBox.Show("Please Fill All The Information!");
                return;
            }
            _GetCurrencyInfo();
           
            if (!_IsCurrencyObjectFull)
            {
                _SentErrorProvider(cbCurrencyCode, $"Currency With Code [{cbCurrencyCode.Text}] doesn't have Information in The System, Please Enter another One!");
                return;
            }
            _PrintCurrencyInfo();
        }


        //Constructor :-
        public ctrlCurrenciesScreen_FindCurency()
        {
            InitializeComponent();
        }

        private void ctrlCurrenciesScreen_FindCurency_Load(object sender, EventArgs e)
        {
            _FillCurrenciesInfoInComboBox();
            _IsCurrencyCodeDone = true;
            _FindCurrencyInfo();
        }


        //Currency Code :-
        private void cbCurrencyCode_Validating(object sender, CancelEventArgs e)
        {
            if (_IsEmpty(cbCurrencyCode.Text))
            {
                _SentErrorProvider(cbCurrencyCode, "Please Enter Currency Code!");
                _IsCurrencyCodeDone = false;
                ClearFileds();
                return;
            }

            if (!clsCurrency.IsCurrencyExists(cbCurrencyCode.Text))
            {
                _SentErrorProvider(cbCurrencyCode, $"Currency With Code [{cbCurrencyCode.Text}] is Not Found, Please Enter another One!");
                _IsCurrencyCodeDone = false;
                ClearFileds();
                return;
            }

            errorProvider1.SetError(cbCurrencyCode, "");
            _IsCurrencyCodeDone = true;
            _CurrencyCode = cbCurrencyCode.Text;
        }

        private void cbCurrencyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_IsCurrencyCodeDone)
            {
                _FindCurrencyInfo();
            }
        }
    }
}
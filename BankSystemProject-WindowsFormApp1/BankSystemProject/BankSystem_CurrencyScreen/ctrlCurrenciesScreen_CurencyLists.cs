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
    public partial class ctrlCurrenciesScreen_CurencyLists : UserControl
    {
        //Private Methods :-
        private void _RefreshCurrencyLists()
        {
            dgvCurrencyLists.DataSource = clsCountry.GetLongAllCountryDetails();
        }


        //Constructor :-
        public ctrlCurrenciesScreen_CurencyLists()
        {
            InitializeComponent();
        }

        private void ctrlCurrenciesScreen_CurencyLists_Load(object sender, EventArgs e)
        {
            _RefreshCurrencyLists();
        }
    }
}
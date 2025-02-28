using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_CurrencyScreen
{
    public partial class ctrlCurrenciesScreen_CurrencyOptions : UserControl
    {
        //Constructor :-
        public ctrlCurrenciesScreen_CurrencyOptions()
        {
            InitializeComponent();
        }

        private void ctrlCurrenciesScreen_CurrencyOptions_Load(object sender, EventArgs e)
        {
            
        }


        //Currency Lists :-
        private void btnCurrencyLists_Click(object sender, EventArgs e)
        {
            ctrlCurrenciesScreen_CurencyLists ctrl = new ctrlCurrenciesScreen_CurencyLists();
            ctrl.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(ctrl);
            ctrl.BringToFront();
        }


        //Find Currency :-
        private void btnFindCurrency_Click(object sender, EventArgs e)
        {
            ctrlCurrenciesScreen_FindCurency ctrl = new ctrlCurrenciesScreen_FindCurency();
            ctrl.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(ctrl);
            ctrl.BringToFront();
        }


        //Update Currency Rate :-
        private void btnUpdateCurrencyRate_Click(object sender, EventArgs e)
        {
            ctrlCurrenciesScreen_UpdateCurencyRate ctrl = new ctrlCurrenciesScreen_UpdateCurencyRate();
            ctrl.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(ctrl);
            ctrl.BringToFront();
        }


        //Currency Calculator :-
        private void btnCurrencyCalaculator_Click(object sender, EventArgs e)
        {
            ctrlCurrenciesScreen_CurrencyCalculator ctrl = new ctrlCurrenciesScreen_CurrencyCalculator();
            ctrl.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(ctrl);
            ctrl.BringToFront();
        }

        private void ctrlCurrenciesScreen_CurencyLists1_Load(object sender, EventArgs e)
        {

        }
    }
}
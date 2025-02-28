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
    public partial class ctrlTransactionsScreen_TotalBalance : UserControl
    {
        //Private Methods :-
        private void _RefreshClientLists()
        {
            dgvTotalBalance.DataSource = clsClient.GetShortAllClientsInfo();
            lblTotalBalance.Text = clsClient.GetTotalClientsBalance().ToString() + " $";
        }


        //Constructor :-
        public ctrlTransactionsScreen_TotalBalance()
        {
            InitializeComponent();
        }

        private void ctrlTransactionsScreen_TotalBalance_Load(object sender, EventArgs e)
        {
            _RefreshClientLists();
        }
    }
}
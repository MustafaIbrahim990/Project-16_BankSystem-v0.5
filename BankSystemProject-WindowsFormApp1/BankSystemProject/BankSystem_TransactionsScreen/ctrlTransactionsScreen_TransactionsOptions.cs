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
    public partial class ctrlTransactionsScreen_TransactionsOptions : UserControl
    {
        //Properties :-
        private string _UserName { get; set; }
        private string _PassWord { get; set; }

        public string UserName
        {
            set { _UserName = value; }
        }
        public string PassWord
        {
            set { _PassWord = value; }
        }


        //Constructor :-
        public ctrlTransactionsScreen_TransactionsOptions()
        {
            InitializeComponent();
        }

        private void ctrlTransactionsScreen_TransactionsOptions_Load(object sender, EventArgs e)
        {

        }


        //Total Balance :-
        private void btnTotalBalance_Click(object sender, EventArgs e)
        {
            ctrlTransactionsScreen_TotalBalance Ctrl = new ctrlTransactionsScreen_TotalBalance();
            Ctrl.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(Ctrl);
            Ctrl.BringToFront();
        }


        //Deposit :-
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            ctrlTransactionsScreen_Deposit Ctrl = new ctrlTransactionsScreen_Deposit();
            Ctrl.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(Ctrl);
            Ctrl.BringToFront();
        }


        //Withdraw :-
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            ctrlTransactionsScreen_Withdraw Ctrl = new ctrlTransactionsScreen_Withdraw();
            Ctrl.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(Ctrl);
            Ctrl.BringToFront();
        }


        //Transfer :-
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            ctrlTransactionsScreen_Transfer Ctrl = new ctrlTransactionsScreen_Transfer(clsUser.GetShortDetails(_UserName, _PassWord).ID);
            Ctrl.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(Ctrl);
            Ctrl.BringToFront();
        }


        //Transfer Registers :-
        private void btnTransferRegisters_Click(object sender, EventArgs e)
        {
            ctrlTransactionsScreen_TransferRegisters Ctrl = new ctrlTransactionsScreen_TransferRegisters();
            Ctrl.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(Ctrl);
            Ctrl.BringToFront();
        }
    }
}
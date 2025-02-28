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

namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_MainScreen
{
    public partial class ctrlMainScreen_RightPanelSide : UserControl
    {
        //Enums :-
        enum enPermissions { eManageClients = 1, eManageUsers = 2, eTransactions = 4, eCurrencyExchange = 8, eFullAccess = -1 };


        //Properties :-
        private string _UserName { get; set; }
        private string _PassWord { get; set; }
        private clsUser _UserInfo;


        //Public Methods :-
        public void GetUserObject(clsUser UserObject)
        {
            _UserInfo = UserObject;
        }


        //Constructor :-
        public ctrlMainScreen_RightPanelSide()
        {
            InitializeComponent();
        }

        private void ctrlMainScreen_RightPanelSide_Load(object sender, EventArgs e)
        {
            
        }


        //Manage Clients :-
        private void btnManageClients_Click(object sender, EventArgs e)
        {
            if (!((_UserInfo.Permissions & (int)enPermissions.eManageClients) == (int)enPermissions.eManageClients))
            {
                MessageBox.Show("You Don't have Permissions to Access Here, Please Contact With Your Admin!", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmManageClientsScreen frm = new frmManageClientsScreen(_UserInfo.UserName, _UserInfo.PassWord);
            frm.ShowDialog();
        }


        //Manage Users :-
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            if (!((_UserInfo.Permissions & (int)enPermissions.eManageUsers) == (int)enPermissions.eManageUsers))
            {
                MessageBox.Show("You Don't have Permissions to Access Here, Please Contact With Your Admin!", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmManageUsersScreen frm = new frmManageUsersScreen(_UserInfo.UserName, _UserInfo.PassWord);
            frm.ShowDialog();
        }


        //Transactions :-
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            if (!((_UserInfo.Permissions & (int)enPermissions.eTransactions) == (int)enPermissions.eTransactions))
            {
                MessageBox.Show("You Don't have Permissions to Access Here, Please Contact With Your Admin!", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmTransactionsScreen frm = new frmTransactionsScreen(_UserInfo.UserName, _UserInfo.PassWord);
            frm.ShowDialog();
        }


        //Currencies Exchange :-
        private void btnCurrencies_Click(object sender, EventArgs e)
        {
            if (!((_UserInfo.Permissions & (int)enPermissions.eCurrencyExchange) == (int)enPermissions.eCurrencyExchange))
            {
                MessageBox.Show("You Don't have Permissions to Access Here, Please Contact With Your Admin!", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmCurrenciesScreen frm = new frmCurrenciesScreen(_UserInfo.UserName, _UserInfo.PassWord);
            frm.ShowDialog();
        }
    }
}
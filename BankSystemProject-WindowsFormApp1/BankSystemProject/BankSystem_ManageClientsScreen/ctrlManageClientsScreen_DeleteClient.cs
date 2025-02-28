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
    public partial class ctrlManageClientsScreen_DeleteClient : UserControl
    {
        //Properties :-
        private ctrlManageClientsScreen_FindClient _CtrlFindClient;


        //Private Methods :-
        private void _RefreshClientCard()
        {
            _CtrlFindClient = new ctrlManageClientsScreen_FindClient();
            _CtrlFindClient.Dock = DockStyle.Fill;
            ClientCardPanel.Controls.Add(_CtrlFindClient);
            _CtrlFindClient.BringToFront();
        }


        //Constructor :-
        public ctrlManageClientsScreen_DeleteClient()
        {
            InitializeComponent();
        }

        private void ctrlManageClientsScreen_DeleteClient_Load(object sender, EventArgs e)
        {
            _RefreshClientCard();
        }


        //Delete Client :-
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (!_CtrlFindClient.IsFoundClient) 
            {
                MessageBox.Show("Please Enter Account Number!");
                return;
            }

            if (MessageBox.Show("Are Your Sure You Want to Delete This Client?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (clsClient.DeleteClient(_CtrlFindClient.AccountNumber))
                {
                    MessageBox.Show("Client Deleted Successfully.");
                    _RefreshClientCard();
                }
                else
                {
                    MessageBox.Show("Error : Delete Client is Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_ManageClientsScreen
{
    public partial class ctrlManageClientsScreen_ManageClientsScreenOptions : UserControl
    {
        //Constructor :-
        public ctrlManageClientsScreen_ManageClientsScreenOptions()
        {
            InitializeComponent();
        }

        private void ctrlManageClientsScreen_ManageClientsScreenOptions_Load(object sender, EventArgs e)
        {

        }


        //Client Lists :-
        private void btnClientLists_Click(object sender, EventArgs e)
        {
            ctrlManageClientsScreen_ClientLists CtrlClientLists = new ctrlManageClientsScreen_ClientLists();
            CtrlClientLists.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(CtrlClientLists);
            CtrlClientLists.BringToFront();
        }


        //Add New Client :-
        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            ctrlManageClientsScreen_AddNewClient CtrlAddNewClient = new ctrlManageClientsScreen_AddNewClient();
            CtrlAddNewClient.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(CtrlAddNewClient);
            CtrlAddNewClient.BringToFront();
        }


        //Find Client :-
        private void btnFIndClient_Click(object sender, EventArgs e)
        {
            ctrlManageClientsScreen_FindClient CtrlFindClient = new ctrlManageClientsScreen_FindClient();
            CtrlFindClient.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(CtrlFindClient);
            CtrlFindClient.BringToFront();
        }


        //Update Client :-
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            ctrlManageClientsScreen_UpdateClient CtrlUpdateClient = new ctrlManageClientsScreen_UpdateClient();
            CtrlUpdateClient.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(CtrlUpdateClient);
            CtrlUpdateClient.BringToFront();
        }


        //Delete Client :-
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            ctrlManageClientsScreen_DeleteClient CtrlDeleteClient = new ctrlManageClientsScreen_DeleteClient();
            CtrlDeleteClient.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(CtrlDeleteClient);
            CtrlDeleteClient.BringToFront();
        }


        //

        private void DownPanelSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ctrlManageClientsScreen_ClientLists_RightPanelSide1_Load(object sender, EventArgs e)
        {

        }

        private void TopPanelSide_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
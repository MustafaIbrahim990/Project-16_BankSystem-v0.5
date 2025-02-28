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
    public partial class ctrlManageClientsScreen_ClientLists : UserControl
    {
        //Private Methods :-
        private void _RefreshAllClientLists()
        {
            dgvClientLists.DataSource = clsClient.GetLongAllClientsInfo();
        }


        //Constructor :-
        public ctrlManageClientsScreen_ClientLists()
        {
            InitializeComponent();
            _RefreshAllClientLists();
        }

        private void dgvClientLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
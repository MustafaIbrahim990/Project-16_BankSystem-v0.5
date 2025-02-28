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
    public partial class ctrlTransactionsScreen_TransferRegisters : UserControl
    {
        //Private Methods :-
        private void _RefreshTransferRegisters()
        {
            dgvTransferRegisters.DataSource = clsClientTransferRegisters.GetLongAllClientTransferRegistersInfo();
        }


        //Constructor :-
        public ctrlTransactionsScreen_TransferRegisters()
        {
            InitializeComponent();
        }

        private void ctrlTransactionsScreen_TransferRegisters_Load(object sender, EventArgs e)
        {
            _RefreshTransferRegisters();
        }

        private void dgvTransferRegisters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
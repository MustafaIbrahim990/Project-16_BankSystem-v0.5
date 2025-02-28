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

namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_ManageUsersScreen
{
    public partial class ctrlManageUsersScreen_UserLists : UserControl
    {
        //Private Methods :-
        private void _RefreshAllUserLists()
        {
            dgvUserLists.DataSource = clsUser.GetLongAllUsersInfo();
        }


        //Constructor :-
        public ctrlManageUsersScreen_UserLists()
        {
            InitializeComponent();
            _RefreshAllUserLists();
        }

        private void ctrlManageUsersScreen_UserLists_Load(object sender, EventArgs e)
        {

        }
    }
}
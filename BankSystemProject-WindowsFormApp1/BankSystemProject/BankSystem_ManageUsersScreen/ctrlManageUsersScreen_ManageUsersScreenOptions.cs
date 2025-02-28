using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_ManageUsersScreen
{
    public partial class ctrlManageUsersScreen_ManageUsersScreenOptions : UserControl
    {
        //Constructor :-
        public ctrlManageUsersScreen_ManageUsersScreenOptions()
        {
            InitializeComponent();
        }

        private void ctrlManageUsersScreen_ManageUsersScreenOptions_Load(object sender, EventArgs e)
        {

        }


        //User Lists :-
        private void btnUserLists_Click(object sender, EventArgs e)
        {
            ctrlManageUsersScreen_UserLists CtrlUserLists = new ctrlManageUsersScreen_UserLists();
            CtrlUserLists.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(CtrlUserLists);
            CtrlUserLists.BringToFront();
        }


        //Add New User :-
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            ctrlManageUsersScreen_AddNewUser CtrlAddNewUser = new ctrlManageUsersScreen_AddNewUser();
            CtrlAddNewUser.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(CtrlAddNewUser);
            CtrlAddNewUser.BringToFront();
        }


        //Find User :-
        private void btnFindUser_Click(object sender, EventArgs e)
        {
            ctrlManageUsersScreen_FindUser CtrlFindUser = new ctrlManageUsersScreen_FindUser();
            CtrlFindUser.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(CtrlFindUser);
            CtrlFindUser.BringToFront();
        }


        //Update User :-
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            ctrlManageUsersScreen_UpdateUser CtrlUpdateUser = new ctrlManageUsersScreen_UpdateUser();
            CtrlUpdateUser.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(CtrlUpdateUser);
            CtrlUpdateUser.BringToFront();
        }


        //Delete User :-
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            ctrlManageUsersScreen_DeleteUser CtrlDeleteUser = new ctrlManageUsersScreen_DeleteUser();
            CtrlDeleteUser.Dock = DockStyle.Fill;
            DownPanelSide.Controls.Add(CtrlDeleteUser);
            CtrlDeleteUser.BringToFront();
        }
    }
}
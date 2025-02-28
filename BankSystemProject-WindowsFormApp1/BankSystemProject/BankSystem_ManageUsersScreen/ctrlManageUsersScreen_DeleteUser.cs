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
    public partial class ctrlManageUsersScreen_DeleteUser : UserControl
    {
        //Properties :-
        private ctrlManageUsersScreen_FindUser _CtrlFindUser;


        //Private Methods :-
        private void _RefreshUserCard()
        {
            _CtrlFindUser = new ctrlManageUsersScreen_FindUser();
            _CtrlFindUser.Dock = DockStyle.Fill;
            UserCardPanel.Controls.Add(_CtrlFindUser);
            _CtrlFindUser.BringToFront();
        }


        //Constructor :-
        public ctrlManageUsersScreen_DeleteUser()
        {
            InitializeComponent();
        }

        private void ctrlManageUsersScreen_DeleteUser_Load(object sender, EventArgs e)
        {
            _RefreshUserCard();
        }


        //Delete User :-
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (!_CtrlFindUser.IsFoundUser)
            {
                MessageBox.Show("Please Enter UserName!");
                return;
            }

            if (MessageBox.Show("Are Your Sure You Want to Delete This User?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (clsUser.DeleteUser(_CtrlFindUser.UserName))
                {
                    MessageBox.Show("User Deleted Successfully.");
                    _RefreshUserCard();
                }
                else
                {
                    MessageBox.Show("Error : Delete User is Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
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

namespace BankSystemProject_WindowsFormApp1
{
    public partial class frmMainScreen : Form
    {
        //Private Methods :-
        private void _SendUserObjectToCtrlManageUsersScreen()
        {
            clsUser UserObject = clsUser.GetShortDetails(_UserName, _PassWord);
            ctrlMainScreen_RightPanelSide1.GetUserObject(UserObject);
        }


        //Properties :-
        private string _UserName { get; set; }
        private string _PassWord { get; set; }


        //Constructor :-
        public frmMainScreen(string UserName, string PassWord)
        {
            InitializeComponent();

            _UserName = UserName;
            _PassWord = PassWord;
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            ctrlLoginScreen_TopPanelSide1.UserName = _UserName;
            ctrlLoginScreen_TopPanelSide1.Date = DateTime.UtcNow.ToLongDateString();
            _SendUserObjectToCtrlManageUsersScreen();
        }

        private void ctrlMainScreen_RightPanelSide1_Load(object sender, EventArgs e)
        {

        }
    }
}
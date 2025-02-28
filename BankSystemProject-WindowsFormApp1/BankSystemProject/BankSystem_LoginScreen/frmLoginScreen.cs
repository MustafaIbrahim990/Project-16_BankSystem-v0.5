using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemProject_WindowsFormApp1
{
    public partial class frmLoginScreen : Form
    {
        //Private Methods :-
        private void _GetUserNameANDDate()
        {
            ctrlLoginScreen_TopPanelSide1.UserName = "[????]";
            ctrlLoginScreen_TopPanelSide1.Date = DateTime.UtcNow.ToLongDateString();
        }


        //Constructor :-
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            _GetUserNameANDDate();
        }

        private void ctrlLoginScreen_RightPanelSide1_Load(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class frmCurrenciesScreen : Form
    {
        //Private Methods :-
        private void _PrintUserNameANDDate()
        {
            ctrlLoginScreen_TopPanelSide1.UserName = _UserName;
            ctrlLoginScreen_TopPanelSide1.Date = DateTime.UtcNow.ToLongDateString();
        }


        //Properties :-
        private string _UserName { get; set; }
        private string _PassWord { get; set; }


        //Constructor :-
        public frmCurrenciesScreen(string UserName, string PassWord)
        {
            InitializeComponent();

            _UserName = UserName;
            _PassWord = PassWord;
        }

        private void frmCurrenciesScreen_Load(object sender, EventArgs e)
        {
            _PrintUserNameANDDate();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemProject_WindowsFormApp1.BankSystemProject.BankSystem_LoginScreen
{
    public partial class ctrlLoginScreen_TopPanelSide : UserControl
    {
        //Properties :-
        public string UserName
        {
            set { lblUserName.Text = value; }
        }
        public string Date
        {
            set { lblDate.Text = value; }
        }


        //Constructor :-
        public ctrlLoginScreen_TopPanelSide()
        {
            InitializeComponent();
        }

        private void ctrlLoginScreen_TopPanelSide_Load(object sender, EventArgs e)
        {
           
        }


        //Close Application :-
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            //Application.Exit();

            Form ParentForm = this.FindForm();

            if (ParentForm != null)
            {
                ParentForm.Close();
            }
        }
    }
}
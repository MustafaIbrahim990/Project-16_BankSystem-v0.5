using System;
using System.Data;
using BankSystem_DataAccessLayer;

namespace BankSystem_BusinessLayer
{
    public class clsUserLoginRegisters
    {
        //Enums :-
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;


        //Properties :-
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int Permissions { get; set; }


        //Constructor :-
        public clsUserLoginRegisters()
        {
            _Mode = enMode.AddNew;
            this.ID = -1;
            this.DateTime = DateTime.MinValue;
            this.UserID = -1;
            this.UserName = "";
            this.PassWord = "";
            this.Permissions = 0;
        }
        public clsUserLoginRegisters(int ID, DateTime DateTime, int UserID)
        {
            _Mode = enMode.Update;
            this.ID = ID;
            this.DateTime = DateTime;
            this.UserID = UserID;
        }
        private clsUserLoginRegisters(int ID, DateTime DateTime, int UserID, string UserName, string PassWord, int Permissions)
        {
            _Mode = enMode.Update;
            this.ID = ID;
            this.DateTime = DateTime;
            this.UserID = UserID;
            this.UserName = UserName;
            this.PassWord = PassWord;
            this.Permissions = Permissions;
        }


        //Get Short All User Login Registers Details :-
        public static DataTable GetShortAllUserLoginRegistersDetails()
        {
            return clsUserLoginRegistersData.GetShortAllUserLoginRegistersDetails();
        }


        //Get Long All User Login Registers Details :-
        public static DataTable GetLongAllUserLoginRegistersDetails()
        {
            return clsUserLoginRegistersData.GetLongAllUserLoginRegistersDetails();
        }


        //Add New User Login Registers :-
        private bool _AddNewUserLoginRegisters()
        {
            this.ID = clsUserLoginRegistersData.AddNewUserLoginRegisters(this.DateTime, this.UserID);
            return (ID != -1);
        }


        //Save Mode in (Add New && Update ) :-
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewUserLoginRegisters())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.Update:
                    {
                        return false;
                        //return _UpdateClient();
                    }
                default:
                    {
                        return false;
                    }
            }
        }
    }
}
using System;
using System.Data;
using BankSystem_DataAccessLayer;

namespace BankSystem_BusinessLayer
{
    public class clsClientTransferRegisters
    {
        //Enums :-
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;


        //Properties :-
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public int sClientID { get; set; }
        public int dClientID { get; set; }
        public decimal Amount { get; set; }
        public decimal sBalance { get; set; }
        public decimal dBalance { get; set; }
        public int ByUserID { get; set; }


        //Constructor :-
        public clsClientTransferRegisters()
        {
            _Mode = enMode.AddNew;
            ID = -1;
            DateTime = DateTime.MinValue;
            sClientID = -1;
            dClientID = -1;
            Amount = -1;
            sBalance = -1;
            dBalance = -1;
            ByUserID = -1;
        }
        private clsClientTransferRegisters(int ID, DateTime DateTime, int sClientID, int dClientID, decimal Amount, decimal sBalance, decimal dBalance, int ByUserID)
        {
            _Mode = enMode.Update;
            this.ID = ID;
            this.DateTime = DateTime;
            this.sClientID = sClientID;
            this.dClientID = dClientID;
            this.Amount = Amount;
            this.sBalance = sBalance;
            this.dBalance = dBalance;
            this.ByUserID = ByUserID;
        }


        //Get Short All Client Transfer Registers Details :-
        public static DataTable GetShortAllClientTransferRegistersInfo()
        {
            return clsClientTransferRegistersData.GetShortAllClientTransferRegistersDetails();
        }


        //Get All Client Transfer Registers Details :-
        public static DataTable GetLongAllClientTransferRegistersInfo()
        {
            return clsClientTransferRegistersData.GetLongAllClientTransferRegistersDetails();
        }


        //Add New Client Transfer Registers :-
        private bool _AddNewClientTransferRegisters()
        {
            this.ID = clsClientTransferRegistersData.AddNewClientTransferRegisters(this.DateTime, this.sClientID, this.dClientID, this.Amount, this.sBalance, this.dBalance, this.ByUserID);
            return (this.ID != -1);
        }


        //Save Mode in (Add New && Update ) :-
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewClientTransferRegisters())
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


        //Add Client Transfer Register :- 
        public static bool AddClientTransferRegister(DateTime DateTime, int sClientID, int dClientID, decimal TransferAmount, decimal sBalance, decimal dBalance, int ByUserID)
        {
            int ID = -1;
            ID = clsClientTransferRegistersData.AddNewClientTransferRegisters(DateTime, sClientID, dClientID, TransferAmount, sBalance, dBalance, ByUserID);
            return (ID != -1);
        }
    }
}
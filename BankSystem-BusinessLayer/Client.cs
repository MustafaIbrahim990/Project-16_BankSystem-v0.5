using System;
using System.Data;
using BankSystem_DataAccessLayer;

namespace BankSystem_BusinessLayer
{
    public class clsClient
    {
        //Enums :-
        private enum enOperationType { Add = 1, Subtract = 2 };
        private enOperationType _OpType;

        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;


        //Properties :-
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string AccountNumber { get; set; }
        public string PINCode { get; set; }
        public decimal AccountBalance { get; set; }
        public int PersonID { get; set; }

        //Constructor :-
        public clsClient()
        {
            _Mode = enMode.AddNew;
            ID = -1;
            FirstName = "";
            LastName = "";
            Phone = "";
            Email = "";
            AccountNumber = "";
            PINCode = "";
            AccountBalance = -1;
            PersonID = -1;
        }
        private clsClient(int ID, string AccountNumber, string PINCode, decimal AccountBalance, int PersonID)
        {
            _Mode = enMode.Update;
            this.ID = ID;
            this.AccountNumber = AccountNumber;
            this.PINCode = PINCode;
            this.AccountBalance = AccountBalance;
            this.PersonID = PersonID;
        }
        private clsClient(int ID, string FirstName, string LastName, string Phone, string Email, string AccountNumber, string PINCode, decimal AccountBalance)
        {
            _Mode = enMode.Update;
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
            this.AccountNumber = AccountNumber;
            this.PINCode = PINCode;
            this.AccountBalance = AccountBalance;
        }

        //Get Short All Clients Info :-
        public static DataTable GetShortAllClientsInfo()
        {
            return clsClientData.GetShortAllClientsDetails();
        }


        //Get Long All Clients Info :-
        public static DataTable GetLongAllClientsInfo()
        {
            return clsClientData.GetLongAllClientsDetails();
        }


        //Get Total Clients Balance Details :-
        public static decimal GetTotalClientsBalance()
        {
            return clsClientData.GetTotalClientsBalance();
        }


        //Is Client Exist By ID :-
        public static bool IsClientExists(int ID)
        {
            return clsClientData.IsClientExists(ID);
        }


        //Is Client Exist By AccountNumber :-
        public static bool IsClientExists(string AccountNumber)
        {
            return clsClientData.IsClientExists(AccountNumber);
        }


        //Get Short Client Details By ID :-
        public static clsClient GetShortDetails(int ID)
        {
            string AccountNumber = "", PINCode = "";
            decimal AccountBalance = -1;
            int PersonID = -1;

            if (clsClientData.GetShortClientDetails(ID, ref AccountNumber, ref PINCode, ref AccountBalance, ref PersonID))
            {
                return new clsClient(ID, AccountNumber, PINCode, AccountBalance, PersonID);
            }
            else
            {
                return null;
            }
        }


        //Get Short Client Details By AccountNumber :-
        public static clsClient GetShortDetails(string AccountNumber)
        {
            string PINCode = "";
            decimal AccountBalance = -1;
            int ID = -1, PersonID = -1;

            if (clsClientData.GetShortClientDetails(AccountNumber, ref ID, ref PINCode, ref AccountBalance, ref PersonID))
            {
                return new clsClient(ID, AccountNumber, PINCode, AccountBalance, PersonID);
            }
            else
            {
                return null;
            }
        }


        //Get Long Client Details By ID :-
        public static clsClient GetLongDetails(int ID)
        {
            string FirstName = "", LastName = "", Phone = "", Email = "", AccountNumber = "", PINCode = "";
            decimal AccountBalance = -1;

            if (clsClientData.GetLongClientDetails(ID, ref FirstName, ref LastName, ref Phone, ref Email, ref AccountNumber, ref PINCode, ref AccountBalance)) 
            {
                return new clsClient(ID, FirstName, LastName, Phone, Email, AccountNumber, PINCode, AccountBalance);
            }
            else
            {
                return null;
            }
        }


        //Get Long Client Details By AccountNumber :-
        public static clsClient GetLongDetails(string AccountNumber)
        {
            int ID = -1;
            string FirstName = "", LastName = "", Phone = "", Email = "", PINCode = "";
            decimal AccountBalance = -1;

            if (clsClientData.GetLongClientDetails(AccountNumber, ref ID, ref FirstName, ref LastName, ref Phone, ref Email, ref PINCode, ref AccountBalance)) 
            {
                return new clsClient(ID, FirstName, LastName, Phone, Email, AccountNumber, PINCode, AccountBalance);
            }
            else
            {
                return null;
            }
        }


        //Add New Client :-
        private bool _AddNewClient()
        {
            this.ID = clsClientData.AddNewClient(this.FirstName, this.LastName, this.Phone, this.Email, this.AccountNumber, this.PINCode, this.AccountBalance);
            return (ID != -1);
        }


        //Update Client :-
        private bool _UpdateClient()
        {
            return clsClientData.UpdateClient(this.ID, this.FirstName, this.LastName, this.Phone, this.Email, this.PINCode, this.AccountBalance);
        }


        //Save Mode in (Add New Client && Update Client) :-
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewClient())
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
                        return _UpdateClient();
                    }
                default:
                    {
                        return false;
                    }
            }
        }


        //Delete Client By ID :-
        public static bool DeleteClient(int ID)
        {
            return clsClientData.DeleteClient(ID);
        }


        //Delete Client By AccountNumber :-
        public static bool DeleteClient(string AccountNumber)
        {
            return clsClientData.DeleteClient(AccountNumber);
        }


        //Calculator :-
        public decimal Calculator(decimal Number1, decimal Number2)
        {
            switch (_OpType)
            {
                case enOperationType.Add:
                    return Number1 + Number2;
                case enOperationType.Subtract:
                    return Number1 - Number2;
                default:
                    return Number1 + Number2;
            }
        }


        //Deposit By ID :-
        public bool Deposit(int ID, decimal ClientBalance, decimal DepositAmount)
        {
            _OpType = enOperationType.Add;
            return clsClientData.DepositWithdraw(ID, Calculator(ClientBalance, DepositAmount));
        }


        //Deposit By AccountNumber :-
        public bool Deposit(string AccountNumber, decimal ClientBalance, decimal DepositAmount)
        {
            _OpType = enOperationType.Add;
            return clsClientData.DepositWithdraw(AccountNumber, Calculator(ClientBalance, DepositAmount));
        }


        //Withdraw By ID :-
        public bool Withdraw(int ID, decimal ClientBalance, decimal WithdrawAmount)
        {
            _OpType = enOperationType.Subtract;
            return clsClientData.DepositWithdraw(ID, Calculator(ClientBalance, WithdrawAmount));
        }


        //Withdraw By AccountNumber :-
        public bool Withdraw(string AccountNumber, decimal ClientBalance, decimal WithdrawAmount)
        {
            _OpType = enOperationType.Subtract;
            return clsClientData.DepositWithdraw(AccountNumber, Calculator(ClientBalance, WithdrawAmount));
        }


        //Transfer By ID :-     FromClientID ---> sClientID  &&  ToClientID ---> dClientID
        public static bool Transfer(DateTime dateTime, int sClientID, int dClientID, decimal TransferAmount, int ByUserID)
        {
            clsClient sClientInfo = GetShortDetails(sClientID);
            clsClient dClientInfo = GetShortDetails(dClientID);

            if (sClientInfo == null || dClientInfo == null)
            {
                return false;
            }

            sClientInfo.AccountBalance -= TransferAmount;
            dClientInfo.AccountBalance += TransferAmount;

            if (!clsClientData.Transfer(sClientInfo.ID, dClientInfo.ID, sClientInfo.AccountBalance, dClientInfo.AccountBalance))
            {
                return false;
            }
            sClientInfo = GetShortDetails(sClientID);
            dClientInfo = GetShortDetails(dClientID);
            clsClientTransferRegisters.AddClientTransferRegister(dateTime, sClientInfo.ID, dClientInfo.ID, TransferAmount, sClientInfo.AccountBalance, dClientInfo.AccountBalance, ByUserID);
            return true;
        }


        //Transfer By AccountNumber :-
        public static bool Transfer(DateTime dateTime, string sAccountNumber, string dAccountNumber, decimal TransferAmount, int ByUserID)
        {
            clsClient sClientInfo = GetShortDetails(sAccountNumber);
            clsClient dClientInfo = GetShortDetails(dAccountNumber);

            if (sClientInfo == null || dClientInfo == null)
            {
                return false;
            }

            sClientInfo.AccountBalance -= TransferAmount;
            dClientInfo.AccountBalance += TransferAmount;

            if (!clsClientData.Transfer(sClientInfo.ID, dClientInfo.ID, sClientInfo.AccountBalance, dClientInfo.AccountBalance))
            {
                return false;
            }
            sClientInfo = GetShortDetails(sAccountNumber);
            dClientInfo = GetShortDetails(dAccountNumber);
            clsClientTransferRegisters.AddClientTransferRegister(dateTime, sClientInfo.ID, dClientInfo.ID, TransferAmount, sClientInfo.AccountBalance, dClientInfo.AccountBalance, ByUserID);
            return true;
        }
    }
}
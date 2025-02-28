using System;
using System.Data;
using BankSystem_BusinessLayer;

namespace BankSystemProject_ConsoleApp
{
    internal class ConsoleApp
    {
        public static class Person
        {
            //Persons :-
            public static void GetAllPersons()
            {
                DataTable dtPersons = clsPerson.GetAllPersons();

                if (dtPersons == null)
                {
                    Console.WriteLine("There Are Not Person in The System.");
                    return;
                }

                foreach (DataRow row in dtPersons.Rows)
                {
                    Console.WriteLine($"ID        : {row["ID"]}");
                    Console.WriteLine($"FirstName : {row["FirstName"]}");
                    Console.WriteLine($"LastName  : {row["LastName"]}");
                    Console.WriteLine($"Phone     : {row["Phone"]}");
                    Console.WriteLine($"Email     : {row["Email"]}");

                    Console.WriteLine("\n\n");
                }
            }

            public static void IsPersonExists(int ID)
            {
                if (clsPerson.IsPersonExists(ID))
                {
                    Console.WriteLine($"Person With ID [{ID}] is Exists.");
                }
                else
                {
                    Console.WriteLine($"Person With ID [{ID}] is Not Exists.");
                }
            }

            public static void GetPersonInfo(int ID)
            {
                clsPerson PersonInfo = clsPerson.Find(ID);

                if (PersonInfo == null)
                {
                    Console.WriteLine($"Person With ID [{ID}] is Not Exists.");
                    return;
                }

                Console.WriteLine($"ID        : {PersonInfo.ID}");
                Console.WriteLine($"FirstName : {PersonInfo.FirstName}");
                Console.WriteLine($"LastName  : {PersonInfo.LastName}");
                Console.WriteLine($"Phone     : {PersonInfo.Phone}");
                Console.WriteLine($"Email     : {PersonInfo.Email}");
            }

            public static void AddNewPerson()
            {
                clsPerson NewPerson = new clsPerson();

                NewPerson.FirstName = "Mohammed";
                NewPerson.LastName = "Khaled";
                NewPerson.Phone = "0775264384";
                NewPerson.Email = "MohammedKhaled@gmail.com";

                if (NewPerson.Save())
                {
                    Console.WriteLine($"Person Added Successfully.");
                }
                else
                {
                    Console.WriteLine($"Add Person is Failed.");
                }
            }

            public static void UpdatePerson(int ID)
            {
                clsPerson PersonInfo = clsPerson.Find(ID);

                if (PersonInfo == null)
                {
                    Console.WriteLine($"Person With ID [{ID}] is Not Exists.");
                    return;
                }

                PersonInfo.FirstName = "Sarah";
                PersonInfo.LastName = "Khaled";
                PersonInfo.Phone = "07507352832";
                PersonInfo.Email = "SarahAhmed@gmail.com";

                if (PersonInfo.Save())
                {
                    Console.WriteLine($"Person Updated Successfully.");
                }
                else
                {
                    Console.WriteLine($"Update Person is Failed.");
                }
            }

            public static void DeletePerson(int ID)
            {
                if (!clsPerson.IsPersonExists(ID))
                {
                    Console.WriteLine($"Person With ID [{ID}] is Not Exists.");
                    return;
                }

                if (clsPerson.DeletePerson(ID))
                {
                    Console.WriteLine($"Person Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine($"Delete Person is Failed.");
                }
            }
        }

        public static class Client
        {
            //Clients :-
            public static void PrintShortClientCard(DataTable dt)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"ID                   : {row["ID"]}");
                    Console.WriteLine($"Account Number       : {row["AccountNumber"]}");
                    Console.WriteLine($"PIN Code             : {row["PINCode"]}");
                    Console.WriteLine($"Account Balance      : {row["AccountBalance"]}");
                    Console.WriteLine($"PersonID             : {row["PersonID"]}");

                    Console.WriteLine("\n\n");
                }
            }

            public static void PrintLongClientCard(DataTable dt)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"ID                   : {row["ID"]}");
                    Console.WriteLine($"FirstName            : {row["FirstName"]}");
                    Console.WriteLine($"LastName             : {row["LastName"]}");
                    Console.WriteLine($"Phone                : {row["Phone"]}");
                    Console.WriteLine($"Email                : {row["Email"]}");
                    Console.WriteLine($"Account Number       : {row["AccountNumber"]}");
                    Console.WriteLine($"PIN Code             : {row["PINCode"]}");
                    Console.WriteLine($"Account Balance      : {row["AccountBalance"]}");

                    Console.WriteLine("\n\n");
                }
            }

            public static void PrintShortClientCard(clsClient ClientInfo)
            {
                Console.WriteLine($"ID                 : {ClientInfo.ID}");
                Console.WriteLine($"AccountNumber      : {ClientInfo.AccountNumber}");
                Console.WriteLine($"PINCode            : {ClientInfo.PINCode}");
                Console.WriteLine($"AccountBalance     : {ClientInfo.AccountBalance}");
                Console.WriteLine($"PersonID           : {ClientInfo.PersonID}");
            }

            public static void PrintLongClientCard(clsClient ClientInfo)
            {
                Console.WriteLine($"ID                 : {ClientInfo.ID}");
                Console.WriteLine($"FirstName          : {ClientInfo.FirstName}");
                Console.WriteLine($"LastName           : {ClientInfo.LastName}");
                Console.WriteLine($"Phone              : {ClientInfo.Phone}");
                Console.WriteLine($"Email              : {ClientInfo.Email}");
                Console.WriteLine($"AccountNumber      : {ClientInfo.AccountNumber}");
                Console.WriteLine($"PINCode            : {ClientInfo.PINCode}");
                Console.WriteLine($"AccountBalance     : {ClientInfo.AccountBalance}");
            }

            //

            public static void GetShortAllClientsInfo()
            {
                DataTable dtClients = clsClient.GetShortAllClientsInfo();

                if (dtClients == null)
                {
                    Console.WriteLine("There Are Not Clients in The System.");
                    return;
                }

                PrintShortClientCard(dtClients);
            }

            public static void GetLongAllClientsInfo()
            {
                DataTable dtClients = clsClient.GetLongAllClientsInfo();

                if (dtClients == null)
                {
                    Console.WriteLine("There Are Not Clients in The System.");
                    return;
                }

                PrintLongClientCard(dtClients);
            }

            public static void IsClientExists(int ID)
            {
                if (clsClient.IsClientExists(ID))
                {
                    Console.WriteLine($"Client With ID [{ID}] is Exists.");
                }
                else
                {
                    Console.WriteLine($"Client With ID [{ID}] is Not Exists.");
                }
            }

            public static void IsClientExists(string AccountNumber)
            {
                if (clsClient.IsClientExists(AccountNumber))
                {
                    Console.WriteLine($"Client With AccountNumber [{AccountNumber}] is Exists.");
                }
                else
                {
                    Console.WriteLine($"Client With AccountNumber [{AccountNumber}] is Not Exists.");
                }
            }

            public static void GetShortClientInfo(int ID)
            {
                clsClient ClientInfo = clsClient.GetShortDetails(ID);

                if (ClientInfo == null)
                {
                    Console.WriteLine($"Client With ID [{ID}] is Not Exists.");
                    return;
                }
                PrintShortClientCard(ClientInfo);
            }

            public static void GetShortClientInfo(string AccountNumber)
            {
                clsClient ClientInfo = clsClient.GetShortDetails(AccountNumber);

                if (ClientInfo == null)
                {
                    Console.WriteLine($"Client With AccountNumber [{AccountNumber}] is Not Exists.");
                    return;
                }
                PrintShortClientCard(ClientInfo);
            }

            public static void GetLongClientInfo(int ID)
            {
                clsClient ClientInfo = clsClient.GetLongDetails(ID);

                if (ClientInfo == null)
                {
                    Console.WriteLine($"Client With ID [{ID}] is Not Exists.");
                    return;
                }
                PrintLongClientCard(ClientInfo);
            }

            public static void GetLongClientInfo(string AccountNumber)
            {
                clsClient ClientInfo = clsClient.GetLongDetails(AccountNumber);

                if (ClientInfo == null)
                {
                    Console.WriteLine($"Client With AccountNumber [{AccountNumber}] is Not Exists.");
                    return;
                }
                PrintLongClientCard(ClientInfo);
            }

            public static void AddNewClient()
            {
                clsClient NewClient = new clsClient();

                NewClient.FirstName = "Fadi";
                NewClient.LastName = "Saqr";
                NewClient.Phone = "0781264384";
                NewClient.Email = "FadiSaqr@gmail.com";
                NewClient.PINCode = "1234";
                NewClient.AccountBalance = 2000;
                NewClient.AccountNumber = "A152";

                if (clsClient.IsClientExists(NewClient.AccountNumber))
                {
                    Console.WriteLine($"Client With AccountNumber [{NewClient.AccountNumber}] is Already Used, Enter another One!");
                    return;
                }

                if (NewClient.Save())
                {
                    Console.WriteLine($"Client Added Successfully.");
                }
                else
                {
                    Console.WriteLine($"Add Client is Failed.");
                }
            }

            public static void UpdateClient(int ID)
            {
                clsClient ClientInfo = clsClient.GetLongDetails(ID);

                if (ClientInfo == null)
                {
                    Console.WriteLine($"Client With ID [{ID}] is Not Exists.");
                    return;
                }

                ClientInfo.FirstName = "Sarah";
                ClientInfo.LastName = "Khaled";
                ClientInfo.Phone = "07707352832";
                ClientInfo.Email = "SarahAhmed@gmail.com";
                ClientInfo.PINCode = "1234";
                ClientInfo.AccountBalance = 2000;

                if (ClientInfo.Save())
                {
                    Console.WriteLine($"Client Updated Successfully.");
                }
                else
                {
                    Console.WriteLine($"Update Client is Failed.");
                }
            }

            public static void UpdateClient(string AccountNumber)
            {
                clsClient ClientInfo = clsClient.GetLongDetails(AccountNumber);

                if (ClientInfo == null)
                {
                    Console.WriteLine($"Client With AccountNumber [{AccountNumber}] is Not Exists.");
                    return;
                }

                ClientInfo.FirstName = "Sarah";
                ClientInfo.LastName = "Khaled";
                ClientInfo.Phone = "07707352832";
                ClientInfo.Email = "SarahAhmed@gmail.com";
                ClientInfo.PINCode = "1234";
                ClientInfo.AccountBalance = 3000;

                if (ClientInfo.Save())
                {
                    Console.WriteLine($"Client Updated Successfully.");
                }
                else
                {
                    Console.WriteLine($"Update Client is Failed.");
                }
            }

            public static void DeleteClient(int ID)
            {
                if (!clsClient.IsClientExists(ID))
                {
                    Console.WriteLine($"Client With ID [{ID}] is Not Exists.");
                    return;
                }

                if (clsClient.DeleteClient(ID))
                {
                    Console.WriteLine($"Client Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine($"Delete Client is Failed.");
                }
            }

            public static void DeleteClient(string AccountNumber)
            {
                if (!clsClient.IsClientExists(AccountNumber))
                {
                    Console.WriteLine($"Client With AccountNumber [{AccountNumber}] is Not Exists.");
                    return;
                }

                if (clsClient.DeleteClient(AccountNumber))
                {
                    Console.WriteLine($"Client Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine($"Delete Client is Failed.");
                }
            }

            public static void Deposit(int ID, decimal DepositAmount)
            {
                clsClient ClientInfo = clsClient.GetLongDetails(ID);

                if (ClientInfo == null)
                {
                    Console.WriteLine($"Client With ID [{ID}] is Not Found, Enter another One!");
                    return;
                }

                if (ClientInfo.Deposit(ID, ClientInfo.AccountBalance, DepositAmount))
                {
                    Console.WriteLine($"Amount Deposited Successfully.");
                }
                else
                {
                    Console.WriteLine($"Amount Deposited Failed.");
                }
            }

            public static void Deposit(string AccountNumber, decimal DepositAmount)
            {
                clsClient ClientInfo = clsClient.GetLongDetails(AccountNumber);

                if (ClientInfo == null)
                {
                    Console.WriteLine($"Client With AccountNumber [{AccountNumber}] is Not Found, Enter another One!");
                    return;
                }

                if (ClientInfo.Deposit(AccountNumber, ClientInfo.AccountBalance, DepositAmount))
                {
                    Console.WriteLine($"Amount Deposited Successfully.");
                }
                else
                {
                    Console.WriteLine($"Amount Deposited Failed.");
                }
            }

            public static void Withdraw(int ID, decimal WithdrawAmount)
            {
                clsClient ClientInfo = clsClient.GetLongDetails(ID);

                if (ClientInfo == null)
                {
                    Console.WriteLine($"Client With ID [{ID}] is Not Found, Enter another One!");
                    return;
                }

                if (WithdrawAmount > ClientInfo.AccountBalance)
                {
                    Console.WriteLine($"Can't Withdraw, InSufficient Balance!");
                    return;
                }

                if (ClientInfo.Withdraw(ID, ClientInfo.AccountBalance, WithdrawAmount))
                {
                    Console.WriteLine($"Amount Withdraw Successfully.");
                }
                else
                {
                    Console.WriteLine($"Amount Withdraw Failed.");
                }
            }

            public static void Withdraw(string AccountNumber, decimal WithdrawAmount)
            {
                clsClient ClientInfo = clsClient.GetLongDetails(AccountNumber);

                if (ClientInfo == null)
                {
                    Console.WriteLine($"Client With AccountNumber [{AccountNumber}] is Not Found, Enter another One!");
                    return;
                }

                if (WithdrawAmount > ClientInfo.AccountBalance)
                {
                    Console.WriteLine($"Can't Withdraw, InSufficient Balance!");
                    return;
                }

                if (ClientInfo.Withdraw(AccountNumber, ClientInfo.AccountBalance, WithdrawAmount))
                {
                    Console.WriteLine($"Amount Withdraw Successfully.");
                }
                else
                {
                    Console.WriteLine($"Amount Withdraw Failed.");
                }
            }

            public static void Transfer(int FromClientID, int ToClientID, decimal TransferAmount, int ByUserID)
            {
                if (!clsClient.IsClientExists(FromClientID))
                {
                    Console.WriteLine($"Client With ID [{FromClientID}] is Not Found, Enter another One!");
                    return;
                }

                if (!clsClient.IsClientExists(ToClientID))
                {
                    Console.WriteLine($"Client With ID [{ToClientID}] is Not Found, Enter another One!");
                    return;
                }

                clsClient FromClient = clsClient.GetShortDetails(FromClientID);

                if (TransferAmount > FromClient.AccountBalance)
                {
                    Console.WriteLine("Amount Exceeds The Available, Enter another Amount!");
                    return;
                }

                if (!clsClient.Transfer(DateTime.Now, FromClientID, ToClientID, TransferAmount, ByUserID))  
                {
                    Console.WriteLine("The Transfer Process is Failed, Try Again Later!");
                    return;
                }

                Console.WriteLine("Transfer Done Successfully");
            }

            public static void Transfer(string FromAccountNumber, string ToAccountNumber, decimal TransferAmount, int ByUserID)
            {
                if (!clsClient.IsClientExists(FromAccountNumber))
                {
                    Console.WriteLine($"Client With AccountNumber [{FromAccountNumber}] is Not Found, Enter another One!");
                    return;
                }

                if (!clsClient.IsClientExists(ToAccountNumber))
                {
                    Console.WriteLine($"Client With AccountNumber [{ToAccountNumber}] is Not Found, Enter another One!");
                    return;
                }

                clsClient FromClient = clsClient.GetShortDetails(FromAccountNumber);

                if (TransferAmount > FromClient.AccountBalance)
                {
                    Console.WriteLine("Amount Exceeds The Available, Enter another Amount!");
                    return;
                }

                if (!clsClient.Transfer(DateTime.Now, FromAccountNumber, ToAccountNumber, TransferAmount, ByUserID))
                {
                    Console.WriteLine("The Transfer Process is Failed, Try Again Later!");
                    return;
                }

                Console.WriteLine("Transfer Done Successfully");
            }
        }

        public static class User
        {
            //Users :-

            public static void PrintShortUserCard(DataTable dt)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"ID                  : {row["ID"]}");
                    Console.WriteLine($"UserName            : {row["UserName"]}");
                    Console.WriteLine($"PassWord            : {row["PassWord"]}");
                    Console.WriteLine($"Permissions         : {row["Permissions"]}");
                    Console.WriteLine($"PersonID            : {row["PersonID"]}");

                    Console.WriteLine("\n\n");
                }
            }

            public static void PrintLongUserCard(DataTable dt)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"ID                  : {row["ID"]}");
                    Console.WriteLine($"FirstName           : {row["FirstName"]}");
                    Console.WriteLine($"LastName            : {row["LastName"]}");
                    Console.WriteLine($"Phone               : {row["Phone"]}");
                    Console.WriteLine($"Email               : {row["Email"]}");
                    Console.WriteLine($"UserName            : {row["UserName"]}");
                    Console.WriteLine($"PassWord            : {row["PassWord"]}");
                    Console.WriteLine($"Permissions         : {row["Permissions"]}");

                    Console.WriteLine("\n\n");
                }
            }

            public static void PrintShortUserCard(clsUser UserInfo)
            {
                Console.WriteLine($"ID             : {UserInfo.ID}");
                Console.WriteLine($"UserName       : {UserInfo.UserName}");
                Console.WriteLine($"PassWord       : {UserInfo.PassWord}");
                Console.WriteLine($"Permissions    : {UserInfo.Permissions}");
                Console.WriteLine($"PersonID       : {UserInfo.PersonID}");
            }

            public static void PrintLongUserCard(clsUser UserInfo)
            {
                Console.WriteLine($"ID                 : {UserInfo.ID}");
                Console.WriteLine($"FirstName          : {UserInfo.FirstName}");
                Console.WriteLine($"LastName           : {UserInfo.LastName}");
                Console.WriteLine($"Phone              : {UserInfo.Phone}");
                Console.WriteLine($"Email              : {UserInfo.Email}");
                Console.WriteLine($"UserName           : {UserInfo.UserName}");
                Console.WriteLine($"PassWord           : {UserInfo.PassWord}");
                Console.WriteLine($"Permissions        : {UserInfo.Permissions}");
            }

            public static void GetShortAllUsersInfo()
            {
                DataTable dtUsers = clsUser.GetShortAllUsersInfo();

                if (dtUsers == null)
                {
                    Console.WriteLine("There Are Not Users in The System.");
                    return;
                }
                PrintShortUserCard(dtUsers);
            }

            public static void GetLongAllUsersInfo()
            {
                DataTable dtUsers = clsUser.GetLongAllUsersInfo();

                if (dtUsers == null)
                {
                    Console.WriteLine("There Are Not Users in The System.");
                    return;
                }
                PrintLongUserCard(dtUsers);
            }

            public static void IsUserExists(int ID)
            {
                if (clsUser.IsUserExists(ID))
                {
                    Console.WriteLine($"User With ID [{ID}] is Exists.");
                }
                else
                {
                    Console.WriteLine($"User With ID [{ID}] is Not Exists.");
                }
            }

            public static void IsUserExists(string UserName)
            {
                if (clsUser.IsUserExists(UserName))
                {
                    Console.WriteLine($"User With UserName [{UserName}] is Exists.");
                }
                else
                {
                    Console.WriteLine($"User With UserName [{UserName}] is Not Exists.");
                }
            }

            public static void IsUserExists(string UserName, string PassWord)
            {
                if (clsUser.IsUserExists(UserName, PassWord))
                {
                    Console.WriteLine($"User With UserName [{UserName}] and PassWord [{PassWord}] is Exists.");
                }
                else
                {
                    Console.WriteLine($"User With UserName [{UserName}] and PassWord [{PassWord}] is Not Exists.");
                }
            }

            public static void GetShortUserInfo(int ID)
            {
                clsUser UserInfo = clsUser.GetShortDetails(ID);

                if (UserInfo == null)
                {
                    Console.WriteLine($"User With ID [{ID}] is Not Exists.");
                    return;
                }
                PrintShortUserCard(UserInfo);
            }

            public static void GetShortUserInfo(string UserName)
            {
                clsUser UserInfo = clsUser.GetShortDetails(UserName);

                if (UserInfo == null)
                {
                    Console.WriteLine($"User With UserName [{UserName}] is Not Exists.");
                    return;
                }
                PrintShortUserCard(UserInfo);
            }

            public static void GetShortUserInfo(string UserName, string PassWord)
            {
                clsUser UserInfo = clsUser.GetShortDetails(UserName, PassWord);

                if (UserInfo == null)
                {
                    Console.WriteLine($"User With UserName [{UserName}] and PassWord [{PassWord}] is Not Exists.");
                    return;
                }
                PrintShortUserCard(UserInfo);
            }

            public static void GetLongUserInfo(int ID)
            {
                clsUser UserInfo = clsUser.GetLongDetails(ID);

                if (UserInfo == null)
                {
                    Console.WriteLine($"User With ID [{ID}] is Not Exists.");
                    return;
                }
                PrintLongUserCard(UserInfo);
            }

            public static void GetLongUserInfo(string UserName)
            {
                clsUser UserInfo = clsUser.GetLongDetails(UserName);

                if (UserInfo == null)
                {
                    Console.WriteLine($"User With UserName [{UserName}] is Not Exists.");
                    return;
                }
                PrintLongUserCard(UserInfo);
            }

            public static void GetLongUserInfo(string UserName, string PassWord)
            {
                clsUser UserInfo = clsUser.GetLongDetails(UserName, PassWord);

                if (UserInfo == null)
                {
                    Console.WriteLine($"User With UserName [{UserName}] and PassWord [{PassWord}] is Not Exists.");
                    return;
                }
                PrintLongUserCard(UserInfo);
            }

            public static void AddNewUser()
            {
                clsUser UserInfo = new clsUser();

                UserInfo.FirstName = "Fadi";
                UserInfo.LastName = "Saqr";
                UserInfo.Phone = "0781264384";
                UserInfo.Email = "FadiSaqr@gmail.com";
                UserInfo.UserName = "User5";
                UserInfo.PassWord = "1234";
                UserInfo.Permissions = 7;

                if (clsUser.IsUserExists(UserInfo.UserName))
                {
                    Console.WriteLine($"User With UserName [{UserInfo.UserName}] is Already Used, Enter another One!");
                    return;
                }

                if (UserInfo.Save())
                {
                    Console.WriteLine($"User Added Successfully.");
                }
                else
                {
                    Console.WriteLine($"Add User is Failed.");
                }
            }

            public static void UpdateUser(int ID)
            {
                clsUser UserInfo = clsUser.GetLongDetails(ID);

                if (UserInfo == null)
                {
                    Console.WriteLine($"User With ID [{ID}] is Not Exists.");
                    return;
                }

                UserInfo.FirstName = "Sarah";
                UserInfo.LastName = "Khaled";
                UserInfo.Phone = "07707352832";
                UserInfo.Email = "SarahAhmed@gmail.com";
                UserInfo.UserName = "User3";
                UserInfo.PassWord = "1234";
                UserInfo.Permissions = 15;

                if (clsClient.IsClientExists(UserInfo.UserName))
                {
                    Console.WriteLine($"User With UserName [{UserInfo.UserName}] is Already Used, Enter another One!");
                    return;
                }

                if (UserInfo.Save())
                {
                    Console.WriteLine($"User Updated Successfully.");
                }
                else
                {
                    Console.WriteLine($"Update User is Failed.");
                }
            }

            public static void UpdateUser(string UserName)
            {
                clsUser UserInfo = clsUser.GetLongDetails(UserName);

                if (UserInfo == null)
                {
                    Console.WriteLine($"User With UserName [{UserName}] is Not Found.");
                    return;
                }

                UserInfo.FirstName = "Shadi";
                UserInfo.LastName = "Khaled";
                UserInfo.Phone = "07707352832";
                UserInfo.Email = "ShadiAhmed@gmail.com";
                UserInfo.UserName = "User3";
                UserInfo.PassWord = "1234";
                UserInfo.Permissions = 15;

                if (clsClient.IsClientExists(UserInfo.UserName))
                {
                    Console.WriteLine($"User With UserName [{UserInfo.UserName}] is Already Used, Enter another One!");
                    return;
                }

                if (UserInfo.Save())
                {
                    Console.WriteLine($"User Updated Successfully.");
                }
                else
                {
                    Console.WriteLine($"Update User is Failed.");
                }
            }

            public static void UpdateUser(string UserName, string PassWord)
            {
                clsUser UserInfo = clsUser.GetLongDetails(UserName, PassWord);

                if (UserInfo == null)
                {
                    Console.WriteLine($"User With UserName [{UserName}] and PassWord [{PassWord}] is Not Found!");
                    return;
                }

                UserInfo.FirstName = "Shadi";
                UserInfo.LastName = "Khaled";
                UserInfo.Phone = "07707352832";
                UserInfo.Email = "ShadiAhmed@gmail.com";
                UserInfo.UserName = "User3";
                UserInfo.PassWord = "1234";
                UserInfo.Permissions = 15;

                if (clsClient.IsClientExists(UserInfo.UserName))
                {
                    Console.WriteLine($"User With UserName [{UserInfo.UserName}] is Already Used, Enter another One!");
                    return;
                }

                if (UserInfo.Save())
                {
                    Console.WriteLine($"User Updated Successfully.");
                }
                else
                {
                    Console.WriteLine($"Update User is Failed.");
                }
            }

            public static void DeleteUser(int ID)
            {
                if (!clsUser.IsUserExists(ID))
                {
                    Console.WriteLine($"User With ID [{ID}] is Not Exists.");
                    return;
                }

                if (clsUser.DeleteUser(ID))
                {
                    Console.WriteLine($"User Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine($"Delete User is Failed.");
                }
            }

            public static void DeleteUser(string UserName)
            {
                if (!clsUser.IsUserExists(UserName))
                {
                    Console.WriteLine($"User With UserName [{UserName}] is Not Exists.");
                    return;
                }

                if (clsUser.DeleteUser(UserName))
                {
                    Console.WriteLine($"User Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine($"Delete User is Failed.");
                }
            }

            public static void DeleteUser(string UserName, string PassWord)
            {
                if (!clsUser.IsUserExists(UserName, PassWord))
                {
                    Console.WriteLine($"User With UserName [{UserName}] and PassWord [{PassWord}] is Not Exists.");
                    return;
                }

                if (clsUser.DeleteUser(UserName, PassWord))
                {
                    Console.WriteLine($"User Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine($"Delete User is Failed.");
                }
            }
        }

        public static class ClientTransferRegisters
        {
            //Client Transfer Registers :-
            public static void PrintShortClientTransferRegisters(DataTable dt)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"ID                  : {row["ID"]}");
                    Console.WriteLine($"DateTime            : {row["DateTime"]}");
                    Console.WriteLine($"FromClientID        : {row["FromClientID"]}");
                    Console.WriteLine($"Amount              : {row["Amount"]}");
                    Console.WriteLine($"ToClientID          : {row["ToClientID"]}");
                    Console.WriteLine($"ByUserID            : {row["ByUserID"]}");

                    Console.WriteLine("\n\n");
                }
            }

            public static void PrintLongClientTransferRegisters(DataTable dt)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"ID                     : {row["ID"]}");
                    Console.WriteLine($"DateTime               : {row["DateTime"]}");
                    Console.WriteLine($"s.AccountNumber        : {row["sAccountNumber"]}");
                    Console.WriteLine($"d.AccountNumber        : {row["dAccountNumber"]}");
                    Console.WriteLine($"Amount                 : {row["Amount"]}");
                    Console.WriteLine($"s.Balance              : {row["sBalance"]}");
                    Console.WriteLine($"d.Balance              : {row["dBalance"]}");
                    Console.WriteLine($"ByUser                 : {row["ByUser"]}");

                    Console.WriteLine("\n\n");
                }
            }

            public static void GetShortClientTransferRegistersInfo()
            {
                DataTable dtClientTransferRegisters = clsClientTransferRegisters.GetShortAllClientTransferRegistersInfo();

                if (dtClientTransferRegisters == null)
                {
                    Console.WriteLine("There Are Not Client Transfer Registers in The System.");
                    return;
                }
                PrintShortClientTransferRegisters(dtClientTransferRegisters);
            }

            public static void GetLongClientTransferRegistersInfo()
            {
                DataTable dtClientTransferRegisters = clsClientTransferRegisters.GetLongAllClientTransferRegistersInfo();

                if (dtClientTransferRegisters == null)
                {
                    Console.WriteLine("There Are Not Client Transfer Registers in The System.");
                    return;
                }
                PrintLongClientTransferRegisters(dtClientTransferRegisters);
            }

            public static void AddNewClientTransferRegisters()
            {
                clsClientTransferRegisters dt = new clsClientTransferRegisters();

                dt.DateTime = DateTime.Now;
                dt.sClientID = 1;
                dt.dClientID = 2;
                dt.Amount = 1000;
                dt.sBalance = 2000;
                dt.dBalance = 1000;
                dt.ByUserID = 1;

                if (dt.Save())
                {
                    Console.WriteLine($"Data Added Successfully.");
                }
                else
                {
                    Console.WriteLine($"Add Data is Failed.");
                }
            }
        }

        public static class UserLoginRegisters
        {
            //User Login Registers :-
            public static void GetShortAllUserLoginRegistersInfo()
            {
                DataTable dtUserLoginRegisters = clsUserLoginRegisters.GetShortAllUserLoginRegistersDetails();

                if (dtUserLoginRegisters == null)
                {
                    Console.WriteLine("There Are Not User Login Registers in The System.");
                    return;
                }

                foreach (DataRow row in dtUserLoginRegisters.Rows)
                {
                    Console.WriteLine($"ID                  : {row["ID"]}");
                    Console.WriteLine($"DateTime            : {row["DateTime"]}");
                    Console.WriteLine($"UserID              : {row["UserID"]}");

                    Console.WriteLine("\n\n");
                }
            }

            public static void GetLongAllUserLoginRegistersInfo()
            {
                DataTable dtUserLoginRegisters = clsUserLoginRegisters.GetLongAllUserLoginRegistersDetails();

                if (dtUserLoginRegisters == null)
                {
                    Console.WriteLine("There Are Not User Login Registers in The System.");
                    return;
                }

                foreach (DataRow row in dtUserLoginRegisters.Rows)
                {
                    Console.WriteLine($"ID                     : {row["ID"]}");
                    Console.WriteLine($"DateTime               : {row["DateTime"]}");
                    Console.WriteLine($"UserName               : {row["UserName"]}");
                    Console.WriteLine($"PassWord               : {row["PassWord"]}");
                    Console.WriteLine($"Permissions            : {row["Permissions"]}");

                    Console.WriteLine("\n\n");
                }
            }

            public static void AddNewUserLoginRegisters()
            {
                clsUserLoginRegisters dt = new clsUserLoginRegisters();

                dt.DateTime = DateTime.Now;
                dt.UserID = 1;

                if (dt.Save())
                {
                    Console.WriteLine($"Data Added Successfully.");
                }
                else
                {
                    Console.WriteLine($"Add Data is Failed.");
                }
            }
        }
        
        public static class Country
        {
            //Countries :-

            public static void GetShortAllCountryInfo()
            {
                DataTable dt = clsCountry.GetShortAllCountryDetails();

                if (dt == null)
                {
                    Console.WriteLine("There Are Not Countries Info in The System.");
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"ID                  : {row["ID"]}");
                    Console.WriteLine($"Name                : {row["Name"]}");
                    Console.WriteLine($"CurrencyID          : {row["CurrencyID"]}");

                    Console.WriteLine("\n\n");
                }
            }

            public static void GetLongAllCountryInfo()
            {
                DataTable dt = clsCountry.GetLongAllCountryDetails();

                if (dt == null)
                {
                    Console.WriteLine("There Are Not Countries Info in The System.");
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"ID                    : {row["ID"]}");
                    Console.WriteLine($"CountryName           : {row["CountryName"]}");
                    Console.WriteLine($"CurrencyName          : {row["CurrencyName"]}");
                    Console.WriteLine($"CurrencyCode          : {row["CurrencyCode"]}");
                    Console.WriteLine($"Rate                  : {row["Rate"]}");

                    Console.WriteLine("\n\n");
                }
            }

            public static void IsCountryExists(int ID)
            {
                if (clsCountry.IsCountryExists(ID))
                {
                    Console.WriteLine($"Country With ID [{ID}] is Exists.");
                }
                else
                {
                    Console.WriteLine($"Country With ID [{ID}] is Not Exists.");
                }
            }

            public static void IsCountryExists(string Name)
            {
                if (clsCountry.IsCountryExists(Name))
                {
                    Console.WriteLine($"Country With Name [{Name}] is Exists.");
                }
                else
                {
                    Console.WriteLine($"Country With Name [{Name}] is Not Exists.");
                }
            }

            public static void GetShortCountryInfo(int ID)
            {
                clsCountry CountryInfo = clsCountry.GetShortDetails(ID);

                if (CountryInfo == null)
                {
                    Console.WriteLine($"Country With ID [{ID}] is Not Exists.");
                    return;
                }

                Console.WriteLine($"ID                 : {CountryInfo.ID}");
                Console.WriteLine($"Name               : {CountryInfo.Name}");
                Console.WriteLine($"CurrencyID         : {CountryInfo.CurrencyID}");
            }

            public static void GetShortCountryInfo(string Name)
            {
                clsCountry CountryInfo = clsCountry.GetShortDetails(Name);

                if (CountryInfo == null)
                {
                    Console.WriteLine($"Country With Name [{Name}] is Not Exists.");
                    return;
                }

                Console.WriteLine($"ID                 : {CountryInfo.ID}");
                Console.WriteLine($"Name               : {CountryInfo.Name}");
                Console.WriteLine($"CurrencyID         : {CountryInfo.CurrencyID}");
            }

            public static void GetLongCountryInfo(int ID)
            {
                clsCountry CountryInfo = clsCountry.GetLongDetails(ID);

                if (CountryInfo == null)
                {
                    Console.WriteLine($"Country With ID [{ID}] is Not Exists.");
                    return;
                }

                Console.WriteLine($"ID                    : {CountryInfo.ID}");
                Console.WriteLine($"Name                  : {CountryInfo.Name}");
                Console.WriteLine($"CurrencyName          : {CountryInfo.CurrencyName}");
                Console.WriteLine($"CurrencyCode          : {CountryInfo.CurrencyCode}");
                Console.WriteLine($"Rate                  : {CountryInfo.Rate}");
            }

            public static void GetLongCountryInfo(string Name)
            {
                clsCountry CountryInfo = clsCountry.GetLongDetails(Name);

                if (CountryInfo == null)
                {
                    Console.WriteLine($"Country With Name [{Name}] is Not Exists.");
                    return;
                }

                Console.WriteLine($"ID                    : {CountryInfo.ID}");
                Console.WriteLine($"Name                  : {CountryInfo.Name}");
                Console.WriteLine($"CurrencyName          : {CountryInfo.CurrencyName}");
                Console.WriteLine($"CurrencyCode          : {CountryInfo.CurrencyCode}");
                Console.WriteLine($"Rate                  : {CountryInfo.Rate}");
            }

            public static void AddNewCountry()
            {
                clsCountry CountryInfo = new clsCountry();

                CountryInfo.Name = "";
                CountryInfo.CurrencyID = 1;

                if (clsCountry.IsCountryExists(CountryInfo.Name))
                {
                    Console.WriteLine($"Country With Name [{CountryInfo.Name}] is Already Used, Please Try to Use another One!");
                    return;
                }

                // CountryInfo.CurrencyID 
                //if (clsCountry.IsCountryExists(CountryInfo.Name))
                //{
                //    Console.WriteLine($"Country With Name [{CountryInfo.Name}] is Already Used, Please Try to Use another One!");
                //    return;
                //}

                if (CountryInfo.Save())
                {
                    Console.WriteLine($"Country Added Successfully.");
                }
                else
                {
                    Console.WriteLine($"Add Country is Failed.");
                }
            }

            public static void UpdateCountry(int ID)
            {
                clsCountry CountryInfo = clsCountry.GetLongDetails(ID);

                if (CountryInfo == null)
                {
                    Console.WriteLine($"Country With ID [{ID}] is Not Exists.");
                    return;
                }

                CountryInfo.Name = "";
                CountryInfo.CurrencyID = 1;

                if (clsCountry.IsCountryExists(CountryInfo.Name))
                {
                    Console.WriteLine($"Country With Name [{CountryInfo.Name}] is Already Used, Please Try to Use another One!");
                    return;
                }

                if (CountryInfo.Save())
                {
                    Console.WriteLine($"Country Updated Successfully.");
                }
                else
                {
                    Console.WriteLine($"Update Country is Failed.");
                }
            }

            public static void UpdateCountry(string Name)//////////////////////////
            {
                clsCountry CountryInfo = clsCountry.GetLongDetails(Name);

                if (CountryInfo == null)
                {
                    Console.WriteLine($"Country With Name [{Name}] is Not Exists.");
                    return;
                }

                CountryInfo.CurrencyID = 1;
                // CountryInfo.CurrencyID 

                if (CountryInfo.Save())
                {
                    Console.WriteLine($"Country Updated Successfully.");
                }
                else
                {
                    Console.WriteLine($"Update Country is Failed.");
                }
            }

            public static void DeleteCountry(int ID)
            {
                if (!clsCountry.IsCountryExists(ID))
                {
                    Console.WriteLine($"Country With ID [{ID}] is Not Exists.");
                    return;
                }

                if (clsCountry.DeleteCountry(ID))
                {
                    Console.WriteLine($"Country Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine($"Delete Country is Failed.");
                }
            }

            public static void DeleteCountry(string Name)
            {
                if (!clsCountry.IsCountryExists(Name))
                {
                    Console.WriteLine($"Country With Name [{Name}] is Not Exists.");
                    return;
                }

                if (clsCountry.DeleteCountry(Name))
                {
                    Console.WriteLine($"Country Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine($"Delete Country is Failed.");
                }
            }
        }
        
        public static class Currency
        {
            //Curriencies :-
            public static void PrintCurrencyCard(DataTable dt)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"ID          : {row["ID"]}");
                    Console.WriteLine($"Name        : {row["Name"]}");
                    Console.WriteLine($"Code        : {row["Code"]}");
                    Console.WriteLine($"Rate        : {row["Rate"]}");

                    Console.WriteLine("\n\n");
                }
            }

            public static void PrintCurrencyCard(clsCurrency CurrencyInfo)
            {
                Console.WriteLine($"ID          : {CurrencyInfo.ID}");
                Console.WriteLine($"Name        : {CurrencyInfo.Name}");
                Console.WriteLine($"Code        : {CurrencyInfo.Code}");
                Console.WriteLine($"Rate        : {CurrencyInfo.Rate}");
            }

            public static void GetAllCurrencyInfo()
            {
                DataTable dt = clsCurrency.GetAllCurrencyDetails();

                if (dt == null)
                {
                    Console.WriteLine("There Are Not Currency Info in The System.");
                    return;
                }
                PrintCurrencyCard(dt);
            }

            public static void IsCurrencyExists(int ID)
            {
                if (clsCurrency.IsCurrencyExists(ID))
                {
                    Console.WriteLine($"Currency With ID [{ID}] is Exists.");
                }
                else
                {
                    Console.WriteLine($"Currency With ID [{ID}] is Not Exists.");
                }
            }

            public static void IsCurrencyExists(string Code)
            {
                if (clsCurrency.IsCurrencyExists(Code))
                {
                    Console.WriteLine($"Currency With Code [{Code}] is Exists.");
                }
                else
                {
                    Console.WriteLine($"Currency With Code [{Code}] is Not Exists.");
                }
            }

            public static void GetCurrencyInfo(int ID)
            {
                clsCurrency CurrencyInfo = clsCurrency.GetDetails(ID);

                if (CurrencyInfo == null)
                {
                    Console.WriteLine($"Currency With ID [{ID}] is Not Exists.");
                    return;
                }
                PrintCurrencyCard(CurrencyInfo);
            }

            public static void GetCurrencyInfo(string Code)
            {
                clsCurrency CurrencyInfo = clsCurrency.GetDetails(Code);

                if (CurrencyInfo == null)
                {
                    Console.WriteLine($"Currency With Code [{Code}] is Not Exists.");
                    return;
                }
                PrintCurrencyCard(CurrencyInfo);
            }

            public static void AddNewCurrency()
            {
                clsCurrency CurrencyInfo = new clsCurrency();

                CurrencyInfo.Name = "Syria";
                CurrencyInfo.Code = "SYR";
                CurrencyInfo.Rate = 1500;

                if (clsCurrency.IsCurrencyExists(CurrencyInfo.Code))
                {
                    Console.WriteLine($"Currency With Code [{CurrencyInfo.Code}] is Already Exist, Please Try to Use another One!");
                    return;
                }

                if (CurrencyInfo.Save())
                {
                    Console.WriteLine($"Currency Added Successfully.");
                }
                else
                {
                    Console.WriteLine($"Add Currency is Failed.");
                }
            }

            public static void UpdateCurrency(int ID, double Rate)
            {
                clsCurrency CurrencyInfo = clsCurrency.GetDetails(ID);

                if (CurrencyInfo == null)
                {
                    Console.WriteLine($"Currency With ID [{ID}] is Not Exists.");
                    return;
                }

                CurrencyInfo.Rate = Rate;

                if (CurrencyInfo.Save())
                {
                    Console.WriteLine($"Currency Updated Successfully.\n\n");
                    Console.WriteLine($"CountryName            : {clsCountry.GetShortDetailsByCurrencyID(CurrencyInfo.ID).Name}");
                    Console.WriteLine($"CurrencyName           : {CurrencyInfo.Name}");
                    Console.WriteLine($"CurrencyCode           : {CurrencyInfo.Code}");
                    Console.WriteLine($"Rate                   : {CurrencyInfo.Rate}");
                }
                else
                {
                    Console.WriteLine($"Update Currency is Failed.");
                }
            }

            public static void UpdateCurrency(string Code, double Rate)
            {
                clsCurrency CurrencyInfo = clsCurrency.GetDetails(Code);

                if (CurrencyInfo == null)
                {
                    Console.WriteLine($"Currency With Code [{Code}] is Not Exists.");
                    return;
                }

                CurrencyInfo.Rate = Rate;

                if (CurrencyInfo.Save())
                {
                    Console.WriteLine($"Currency Updated Successfully.\n\n");
                    Console.WriteLine($"CountryName            : {clsCountry.GetShortDetailsByCurrencyID(CurrencyInfo.ID).Name}");
                    Console.WriteLine($"CurrencyName           : {CurrencyInfo.Name}");
                    Console.WriteLine($"CurrencyCode           : {CurrencyInfo.Code}");
                    Console.WriteLine($"Rate                   : {CurrencyInfo.Rate}");
                }
                else
                {
                    Console.WriteLine($"Update Currency is Failed.");
                }
            }

            public static void DeleteCurrency(int ID)
            {
                if (!clsCurrency.IsCurrencyExists(ID))
                {
                    Console.WriteLine($"Currency With ID [{ID}] is Not Exists.");
                    return;
                }

                if (clsCurrency.DeleteCurrency(ID))
                {
                    Console.WriteLine($"Currency Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine($"Delete Currency is Failed.");
                }
            }

            public static void DeleteCurrency(string Code)
            {
                if (!clsCurrency.IsCurrencyExists(Code))
                {
                    Console.WriteLine($"Currency With Code [{Code}] is Not Exists.");
                    return;
                }

                if (clsCurrency.DeleteCurrency(Code))
                {
                    Console.WriteLine($"Currency Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine($"Delete Currency is Failed.");
                }
            }
        }

        static void Main(string[] args)
        {
            //User.UpdateUser("User3","1234");
            //User.GetLongUserInfo(7);
            //Country.GetLongCountryInfo(1);
            //Currency.GetAllCurrencyInfo();
            Currency.UpdateCurrency("SYR", 1450);
            Console.ReadKey();
        }
    }
}
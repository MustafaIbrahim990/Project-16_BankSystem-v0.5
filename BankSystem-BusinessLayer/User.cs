using System;
using System.Data;
using BankSystem_DataAccessLayer;

namespace BankSystem_BusinessLayer
{
    public class clsUser
    {
        //Enums :-
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;


        //Properties :-
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int Permissions { get; set; }
        public int PersonID { get; set; }

        //Constructor :-
        public clsUser()
        {
            _Mode = enMode.AddNew;
            ID = -1;
            FirstName = "";
            LastName = "";
            Phone = "";
            Email = "";
            UserName = "";
            PassWord = "";
            Permissions = -1;
            PersonID = -1;
        }
        private clsUser(int ID, string UserName, string PassWord, int Permissions, int PersonID)
        {
            _Mode = enMode.Update;
            this.ID = ID;
            this.UserName = UserName;
            this.PassWord = PassWord;
            this.Permissions = Permissions;
            this.PersonID = PersonID;
        }
        private clsUser(int ID, string FirstName, string LastName, string Phone, string Email, string UserName, string PassWord, int Permissions)
        {
            _Mode = enMode.Update;
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
            this.UserName = UserName;
            this.PassWord = PassWord;
            this.Permissions = Permissions;
        }

        //Get Short All Users Info :-
        public static DataTable GetShortAllUsersInfo()
        {
            return clsUserData.GetShortAllUsersDetails();
        }


        //Get All Users Info :-
        public static DataTable GetLongAllUsersInfo()
        {
            return clsUserData.GetLongAllUsersDetails();
        }

        //Is User Exist By ID :-
        public static bool IsUserExists(int ID)
        {
            return clsUserData.IsUserExists(ID);
        }


        //Is User Exist By UserName :-
        public static bool IsUserExists(string UserName)
        {
            return clsUserData.IsUserExists(UserName);
        }


        //Is User Exist By UserName and PassWord :-
        public static bool IsUserExists(string UserName, string PassWord)
        {
            return clsUserData.IsUserExists(UserName, PassWord);
        }


        //Get Short User Details By ID :-
        public static clsUser GetShortDetails(int ID)
        {
            string UserName = "", PassWord = "";
            int Permissions = -1, PersonID = -1;

            if (clsUserData.GetShortUserDetails(ID, ref UserName, ref PassWord, ref Permissions, ref PersonID))
            {
                return new clsUser(ID, UserName, PassWord, Permissions, PersonID);
            }
            else
            {
                return null;
            }
        }


        //Get Short User Details By UserName :-
        public static clsUser GetShortDetails(string UserName)
        {
            int ID = -1;
            string PassWord = "";
            int Permissions = -1, PersonID = -1;

            if (clsUserData.GetShortUserDetails(UserName, ref ID, ref PassWord, ref Permissions, ref PersonID))
            {
                return new clsUser(ID, UserName, PassWord, Permissions, PersonID);
            }
            else
            {
                return null;
            }
        }


        //Get Short User Details By UserName and PassWord :-
        public static clsUser GetShortDetails(string UserName, string PassWord)
        {
            int ID = -1;
            int Permissions = -1, PersonID = -1;

            if (clsUserData.GetShortUserDetails(UserName, PassWord, ref ID, ref Permissions, ref PersonID)) 
            {
                return new clsUser(ID, UserName, PassWord, Permissions, PersonID);
            }
            else
            {
                return null;
            }
        }


        //Get Long User Details By ID :-
        public static clsUser GetLongDetails(int ID)
        {
            string FirstName = "", LastName = "", Phone = "", Email = "", UserName = "", PassWord = "";
            int Permissions = -1;

            if (clsUserData.GetLongUserDetails(ID, ref FirstName, ref LastName, ref Phone, ref Email, ref UserName, ref PassWord, ref Permissions))
            {
                return new clsUser(ID, FirstName, LastName, Phone, Email, UserName, PassWord, Permissions);
            }
            else
            {
                return null;
            }
        }


        //Get Long User Details By UserName :-
        public static clsUser GetLongDetails(string UserName)
        {
            int ID = -1;
            string FirstName = "", LastName = "", Phone = "", Email = "", PassWord = "";
            int Permissions = -1;

            if (clsUserData.GetLongUserDetails(UserName, ref ID, ref FirstName, ref LastName, ref Phone, ref Email, ref PassWord, ref Permissions))
            {
                return new clsUser(ID, FirstName, LastName, Phone, Email, UserName, PassWord, Permissions);
            }
            else
            {
                return null;
            }
        }


        //Get Long User Details By UserName and PassWord :-
        public static clsUser GetLongDetails(string UserName, string PassWord)
        {
            int ID = -1;
            string FirstName = "", LastName = "", Phone = "", Email = "";
            int Permissions = -1;

            if (clsUserData.GetLongUserDetails(UserName, PassWord, ref ID, ref FirstName, ref LastName, ref Phone, ref Email, ref Permissions)) 
            {
                return new clsUser(ID, FirstName, LastName, Phone, Email, UserName, PassWord, Permissions);
            }
            else
            {
                return null;
            }
        }


        //Add New User :-
        private bool _AddNewUser()
        {
            this.ID = clsUserData.AddNewUser(this.FirstName, this.LastName, this.Phone, this.Email, this.UserName, this.PassWord, this.Permissions);
            return (this.ID != -1);
        }


        //Update User By ID :-
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.ID, this.FirstName, this.LastName, this.Phone, this.Email, this.UserName, this.PassWord, this.Permissions);
        }


        //Save Mode in (Add New User && Update User) :-
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewUser())
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
                        return _UpdateUser();
                    }
                default:
                    {
                        return false;
                    }
            }
        }


        //Delete User By ID :-
        public static bool DeleteUser(int ID)
        {
            return clsUserData.DeleteUser(ID);
        }


        //Delete User By UserName :-
        public static bool DeleteUser(string UserName)
        {
            return clsUserData.DeleteUser(UserName);
        }


        //Delete User By UserName and PassWord :-
        public static bool DeleteUser(string UserName, string PassWord)
        {
            return clsUserData.DeleteUser(UserName, PassWord);
        }
    }
}
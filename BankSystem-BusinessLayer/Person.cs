using System;
using System.Data;
using BankSystem_DataAccessLayer;

namespace BankSystem_BusinessLayer
{
    public class clsPerson
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


        //Constructor :-
        public clsPerson()
        {
            _Mode = enMode.AddNew;
            ID = -1;
            FirstName = "";
            LastName = "";
            Phone = "";
            Email = "";
        }
        private clsPerson(int ID, string FirstName, string LastName, string Phone, string Email)
        {
            _Mode = enMode.Update;
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
        }


        //Get All Persons :-
        public static DataTable GetAllPersons()
        {
            return clsPersonData.GetAllPersons();
        }


        //Is Person Exist By ID :-
        public static bool IsPersonExists(int ID)
        {
            return clsPersonData.IsPersonExists(ID);
        }


        //Get Person Info By ID :-
        public static clsPerson Find(int ID)
        {
            string FirstName = "", LastName = "", Phone = "", Email = "";

            if (clsPersonData.GetPersonInfo(ID, ref FirstName, ref LastName, ref Phone, ref Email))
            {
                return new clsPerson(ID, FirstName, LastName, Phone, Email);
            }
            else
            {
                return null;
            }
        }


        //Add New Person :-
        private bool _AddNewPerson()
        {
            this.ID = clsPersonData.AddNewPerson(this.FirstName, this.LastName, this.Phone, this.Email);
            return (ID != -1);
        }


        //Update Person :-
        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.ID, this.FirstName, this.LastName, this.Phone, this.Email);
        }


        //Save Mode in (Add New Person && Update Person) :-
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewPerson())
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
                        return _UpdatePerson();
                    }
                default:
                    {
                        return false;
                    }
            }
        }


        //Delete Person :-
        public static bool DeletePerson(int ID)
        {
            return clsPersonData.DeletePerson(ID);
        }
    }
}
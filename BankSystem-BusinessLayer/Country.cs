using System;
using System.Data;
using BankSystem_DataAccessLayer;

namespace BankSystem_BusinessLayer
{
    public class clsCountry
    {
        //Enums :-
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;


        //Properties :-
        public int ID { get; set; }
        public string Name { get; set; }
        public int CurrencyID { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public double Rate { get; set; }

        //Constructor :-
        public clsCountry()
        {
            _Mode = enMode.AddNew;
            ID = -1;
            Name = "";
            CurrencyID = -1;
            CurrencyName = "";
            CurrencyCode = "";
            Rate = -1;
        }
        private clsCountry(int ID, string Name, int CurrencyID)
        {
            _Mode = enMode.Update;
            this.ID = ID;
            this.Name = Name;
            this.CurrencyID = CurrencyID;
        }
        private clsCountry(int ID, string Name, string CurrencyName, string CurrencyCode, double Rate)
        {
            _Mode = enMode.Update;
            this.ID = ID;
            this.Name = Name;
            this.CurrencyName = CurrencyName;
            this.CurrencyCode = CurrencyCode;
            this.Rate = Rate;
        }

        //Get Short All Country Details :-
        public static DataTable GetShortAllCountryDetails()
        {
            return clsCountryData.GetShortAllCountryDetails();
        }


        //Get Long All Country Details :-
        public static DataTable GetLongAllCountryDetails()
        {
            return clsCountryData.GetLongAllCountryDetails();
        }


        //Is Country Exist By ID :-
        public static bool IsCountryExists(int ID)
        {
            return clsCountryData.IsCountryExists(ID);
        }


        //Is Country Exist By Name :-
        public static bool IsCountryExists(string Name)
        {
            return clsCountryData.IsCountryExists(Name);
        }


        //Get Short Country Details By ID :-
        public static clsCountry GetShortDetails(int ID)
        {
            string Name = "";
            int CurrencyID = -1;

            if (clsCountryData.GetShortCountryDetails(ID, ref Name, ref CurrencyID)) 
            {
                return new clsCountry(ID, Name, CurrencyID);
            }
            else
            {
                return null;
            }
        }


        //Get Short Country Details By Name :-
        public static clsCountry GetShortDetails(string Name)
        {
            int ID = -1, CurrencyID = -1;

            if (clsCountryData.GetShortCountryDetails(Name, ref ID, ref CurrencyID)) 
            {
                return new clsCountry(ID, Name, CurrencyID);
            }
            else
            {
                return null;
            }
        }


        //Get Short Details By CurrencyID :-
        public static clsCountry GetShortDetailsByCurrencyID(int CurrencyID)
        {
            int ID = -1;
            string Name = "";

            if (clsCountryData.GetShortCountryDetails(CurrencyID, ref ID, ref Name))
            {
                return new clsCountry(ID, Name, CurrencyID);
            }
            else
            {
                return null;
            }
        }


        //Get Long Country Details By ID :-
        public static clsCountry GetLongDetails(int ID)
        {
            string Name = "", CurrencyName = "", CurrencyCode = "";
            double Rate = -1;

            if (clsCountryData.GetLongCountryDetails(ID, ref Name, ref CurrencyName, ref CurrencyCode, ref Rate)) 
            {
                return new clsCountry(ID, Name, CurrencyName, CurrencyCode, Rate);
            }
            else
            {
                return null;
            }
        }


        //Get Long Country Details By Name :-
        public static clsCountry GetLongDetails(string Name)
        {
            int ID = -1;
            string CurrencyName = "", CurrencyCode = "";
            double Rate = -1;

            if (clsCountryData.GetLongCountryDetails(Name, ref ID, ref CurrencyName, ref CurrencyCode, ref Rate))
            {
                return new clsCountry(ID, Name, CurrencyName, CurrencyCode, Rate);
            }
            else
            {
                return null;
            }
        }


        //Add New Country :-
        private bool _AddNewCountry()
        {
            this.ID = clsCountryData.AddNewCountry(this.Name, this.CurrencyName, this.CurrencyCode, this.Rate);
            return (ID != -1);
        }


        //Update Country :-
        private bool _UpdateCountry()
        {
            return clsCountryData.UpdateCountry(this.ID, this.Name, this.CurrencyID);
        }


        //Save Mode in (Add New Country && Update Country) :-
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewCountry())
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
                        return _UpdateCountry();
                    }
                default:
                    {
                        return false;
                    }
            }
        }


        //Delete Country By ID :-
        public static bool DeleteCountry(int ID)
        {
            return clsCountryData.DeleteCountry(ID);
        }


        //Delete Country By Name :-
        public static bool DeleteCountry(string Name)
        {
            return clsCountryData.DeleteCountry(Name);
        }
    }
}
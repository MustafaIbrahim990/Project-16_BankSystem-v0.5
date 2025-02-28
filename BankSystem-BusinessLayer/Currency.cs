using System;
using System.Data;
using BankSystem_DataAccessLayer;

namespace BankSystem_BusinessLayer
{
    public class clsCurrency
    {
        //Enums :-
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;


        //Properties :-
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double Rate { get; set; }
        public string CountryName { get; set; }

        //Constructor :-
        public clsCurrency()
        {
            _Mode = enMode.AddNew;
            ID = -1;
            Name = "";
            Code = "";
            Rate = -1;
        }
        private clsCurrency(int ID, string Name, string Code, double Rate)
        {
            _Mode = enMode.Update;
            this.ID = ID;
            this.Name = Name;
            this.Code = Code;
            this.Rate = Rate;
        }
        private clsCurrency(int CurrencyID, string CurrencyName, string CurrencyCode, double CurrencyRate, string CountryName)
        {
            _Mode = enMode.Update;
            this.ID = CurrencyID;
            this.Name = CurrencyName;
            this.Code = CurrencyCode;
            this.Rate = CurrencyRate;
            this.CountryName = CountryName;
        }


        //Get All Currency Details :-
        public static DataTable GetAllCurrencyDetails()
        {
            return clsCurrencyData.GetAllCurrencyDetails();
        }


        //Is Currency Exist By ID :-
        public static bool IsCurrencyExists(int ID)
        {
            return clsCurrencyData.IsCurrencyExists(ID);
        }


        //Is Currency Exist By Name :-
        public static bool IsCurrencyExists(string Code)
        {
            return clsCurrencyData.IsCurrencyExists(Code);
        }


        //Get Currency Details By ID :-
        public static clsCurrency GetDetails(int ID)
        {
            string Name = "", Code = "";
            double Rate = -1;

            if (clsCurrencyData.GetCurrencyDetails(ID, ref Name, ref Code, ref Rate)) 
            {
                return new clsCurrency(ID, Name, Code, Rate);
            }
            else
            {
                return null;
            }
        }


        //Get Currency Details By Code :-
        public static clsCurrency GetDetails(string Code)
        {
            int ID = -1;
            string Name = "";
            double Rate = -1;

            if (clsCurrencyData.GetCurrencyDetails(Code, ref ID, ref Name, ref Rate))
            {
                return new clsCurrency(ID, Name, Code, Rate);
            }
            else
            {
                return null;
            }
        }


        //Get Long Currency Details By ID :-
        public static clsCurrency GetLongDetails(int ID)
        {
            string CurrencyName = "", CurrencyCode = "", CountryName = "";
            double Rate = -1;

            if (clsCurrencyData.GetLongCurrencyDetails(ID, ref CurrencyName, ref CurrencyCode, ref Rate, ref CountryName)) 
            {
                return new clsCurrency(ID, CurrencyName, CurrencyCode, Rate, CountryName);
            }
            else
            {
                return null;
            }
        }


        //Get Long Currency Details By Code :-
        public static clsCurrency GetLongDetails(string Code)
        {
            int ID = -1;
            string CurrencyName = "", CountryName = "";
            double Rate = -1;

            if (clsCurrencyData.GetLongCurrencyDetails(Code, ref ID, ref CurrencyName, ref Rate, ref CountryName)) 
            {
                return new clsCurrency(ID, CurrencyName, Code, Rate, CountryName);
            }
            else
            {
                return null;
            }
        }


        //Add New Currency :-
        private bool _AddNewCurrency()
        {
            this.ID = clsCurrencyData.AddNewCurrency(this.Name, this.Code, this.Rate);
            return (ID != -1);
        }


        //Update Currency :-
        private bool _UpdateCurrency()
        {
            return clsCurrencyData.UpdateCurrency(this.ID, this.Rate);
        }


        //Save Mode in (Add New Currency && Update Currency) :-
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewCurrency())
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
                        return _UpdateCurrency();
                    }
                default:
                    {
                        return false;
                    }
            }
        }


        //Delete Currency By ID :-
        public static bool DeleteCurrency(int ID)
        {
            return clsCurrencyData.DeleteCurrency(ID);
        }


        //Delete Currency By Code :-
        public static bool DeleteCurrency(string Code)
        {
            return clsCurrencyData.DeleteCurrency(Code);
        }


        //Convert Other Currency to USD :-
        private static double _ConvertToUSD(double AmountToExchsnge, double Rate)
        {
            return (double)(AmountToExchsnge / Rate);
        }


        //Convert to Other Currency :-
        private static double _ConvertToOtherCurrency(clsCurrency CurrencyObjectConvertFrom, clsCurrency CurrencyObjectConvertTo, double AmountToExchange)
        {
            double AmountInUSD = _ConvertToUSD(AmountToExchange, CurrencyObjectConvertFrom.Rate);

            if (CurrencyObjectConvertTo.Code.ToUpper() == "USD")
            {
                return AmountInUSD;
            }
            return AmountInUSD * CurrencyObjectConvertTo.Rate;
        }


        //Currency Calculator :-
        public static double CurrencyCalculator(clsCurrency CurrencyObjectConvertFrom, clsCurrency CurrencyObjectConvertTo, double AmountToExchange)
        {
            return _ConvertToOtherCurrency(CurrencyObjectConvertFrom, CurrencyObjectConvertTo, AmountToExchange);
        }
    }
}
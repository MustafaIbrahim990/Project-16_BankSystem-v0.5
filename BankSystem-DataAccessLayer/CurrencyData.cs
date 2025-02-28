using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSystem_DataAccessLayer
{
    public static class clsCurrencyData
    {
        //Get All Currency Details :-
        public static DataTable GetAllCurrencyDetails()
        {
            DataTable dtCurrencies = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM Currencies;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtCurrencies.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dtCurrencies;
        }


        //Is Currency Exists By ID :-
        public static bool IsCurrencyExists(int ID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Result = 'Yes' FROM Currencies
                           WHERE Currencies.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Is Currency Exists By ID :-
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                Object Result = command.ExecuteScalar();

                if (Result != null)
                {
                    isExist = true;
                }
                else
                {
                    isExist = false;
                }
            }
            catch (Exception ex)
            {
                isExist = false;
            }
            finally
            {
                connection.Close();
            }
            return isExist;
        }


        //Is Currency Exists By Code :-
        public static bool IsCurrencyExists(string Code)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Result = 'Yes' FROM Currencies
                           WHERE Currencies.Code = @Code;";

            SqlCommand command = new SqlCommand(query, connection);

            //Is Currency Exists By Code :-
            command.Parameters.AddWithValue("@Code", Code);

            try
            {
                connection.Open();
                Object Result = command.ExecuteScalar();

                if (Result != null)
                {
                    isExist = true;
                }
                else
                {
                    isExist = false;
                }
            }
            catch (Exception ex)
            {
                isExist = false;
            }
            finally
            {
                connection.Close();
            }
            return isExist;
        }


        //Ge Currency Details By ID :-
        public static bool GetCurrencyDetails(int ID, ref string Name, ref string Code, ref double Rate)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM Currencies
                           WHERE Currencies.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Currency Details By ID :-
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Name = (string)reader["Name"];
                    Code = (string)reader["Code"];
                    Rate = Convert.ToDouble(reader["Rate"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }


        //Get Currency Details By Code :-
        public static bool GetCurrencyDetails(string Code, ref int ID, ref string Name, ref double Rate)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM Currencies
                           WHERE Currencies.Code = @Code;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Currency Details By Code :-
            command.Parameters.AddWithValue("@Code", Code);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ID"];
                    Name = (string)reader["Name"];
                    Rate = Convert.ToDouble(reader["Rate"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }


        //Get Long Currency Details By ID :-
        public static bool GetLongCurrencyDetails(int ID, ref string Name, ref string Code, ref double Rate, ref string CountryName)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Countries.Name AS CountryName, Currencies.Name AS CurrencyName, Currencies.Code AS CurrencyCode, Currencies.Rate
                           FROM Currencies INNER JOIN Countries
                           ON Currencies.ID = Countries.CurrencyID
                           WHERE Countries.CurrencyID = @CurrencyID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Long Currency Details By ID :-
            command.Parameters.AddWithValue("@CurrencyID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Name = (string)reader["CurrencyName"];
                    Code = (string)reader["CurrencyCode"];
                    Rate = Convert.ToDouble(reader["Rate"]);
                    CountryName = (string)reader["CountryName"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }



        //Get Long Currency Details By Code :-
        public static bool GetLongCurrencyDetails(string Code, ref int ID, ref string Name, ref double Rate, ref string CountryName)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Currencies.ID, Currencies.Name AS CurrencyName, Currencies.Rate, Countries.Name AS CountryName
                           FROM Currencies INNER JOIN Countries
                           ON Currencies.ID = Countries.CurrencyID
                           WHERE Countries.CurrencyID = 
                           (
                           SELECT Currencies.ID FROM Currencies
                           WHERE Currencies.Code = @Code
                           );";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Long Currency Details By Code :-
            command.Parameters.AddWithValue("@Code", Code);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ID"];
                    Name = (string)reader["CurrencyName"];
                    Rate = Convert.ToDouble(reader["Rate"]);
                    CountryName = (string)reader["CountryName"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        

        //Add New Currency :-
        public static int AddNewCurrency(string Name, string Code, double Rate)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"INSERT INTO Currencies
                           (Name , Code , Rate)
                           VALUES
                           (@Name , @Code , @Rate)
                           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@Rate", Rate);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    ID = InsertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return ID;
        }


        //Update Currency By ID :-
        public static bool UpdateCurrency(int ID, double Rate)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"UPDATE Currencies
                           SET Rate = @Rate
                           Where Currencies.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Rate", Rate);

            //Update Currency By ID :-
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }


        //Delete Currency By ID :-
        public static bool DeleteCurrency(int ID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"DELETE FROM Currencies
                           WHERE Currencies.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Delete Currency By ID :-
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }


        //Delete Currency By Name :-
        public static bool DeleteCurrency(string Code)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"DELETE FROM Currencies
                           WHERE Currencies.Code = @Code;";

            SqlCommand command = new SqlCommand(query, connection);

            //Delete Currency By Code :-
            command.Parameters.AddWithValue("@Code", Code);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }
    }
}
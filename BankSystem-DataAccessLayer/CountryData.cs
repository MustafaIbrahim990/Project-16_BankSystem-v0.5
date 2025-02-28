using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSystem_DataAccessLayer
{
    public static class clsCountryData
    {
        //Get Short All Country Details :-
        public static DataTable GetShortAllCountryDetails()
        {
            DataTable dtCountries = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM Countries;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtCountries.Load(reader);
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
            return dtCountries;
        }


        //Get Long All Country Details :-
        public static DataTable GetLongAllCountryDetails()
        {
            DataTable dtCountries = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Countries.ID, Countries.Name AS CountryName, Currencies.Name AS CurrencyName, Currencies.Code AS CurrencyCode, Currencies.Rate
                           FROM Countries INNER JOIN Currencies
                           ON Countries.CurrencyID = Currencies.ID";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtCountries.Load(reader);
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
            return dtCountries;
        }


        //Is Country Exists By ID :-
        public static bool IsCountryExists(int ID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Result = 'Yes' FROM Countries
                           WHERE Countries.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Is Country Exists By ID :-
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


        //Is Country Exists By Name :-
        public static bool IsCountryExists(string Name)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Result = 'Yes' FROM Countries
                           WHERE Countries.Name = @Name;";

            SqlCommand command = new SqlCommand(query, connection);

            //Is Country Exists By Name :-
            command.Parameters.AddWithValue("@Name", Name);

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


        //Get Short Country Details By ID :-
        public static bool GetShortCountryDetails(int ID, ref string Name, ref int CurrencyID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM Countries
                           WHERE Countries.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Short Country Details By ID :-
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Name = (string)reader["Name"];
                    CurrencyID = (int)reader["CurrencyID"];
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


        //Get Short Country Details By Name :-
        public static bool GetShortCountryDetails(string Name, ref int ID, ref int CurrencyID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM Countries
                           WHERE Countries.Name = @Name;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Short Country Details By Name :-
            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ID"];
                    CurrencyID = (int)reader["CurrencyID"];
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


        //Get Short Country Details By CurrencyID :-
        public static bool GetShortCountryDetails(int CurrencyID, ref int ID, ref string Name)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Countries.ID, Countries.Name FROM Countries
                           WHERE Countries.CurrencyID = @CurrencyID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Short Country Details By CurrencyID :-
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["ID"];
                    Name = (string)reader["Name"];
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


        //Get Long Country Details By ID :-
        public static bool GetLongCountryDetails(int ID, ref string Name, ref string CurrencyName, ref string CurrencyCode, ref double Rate)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Countries.Name AS CountryName, Currencies.Name AS CurrencyName, Currencies.Code AS CurrencyCode, Currencies.Rate
                           FROM Countries INNER JOIN Currencies
                           ON Countries.CurrencyID = Currencies.ID
                           WHERE Countries.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Long Country Details By ID :-
            command.Parameters.AddWithValue("@ID", ID);
            
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Name = (string)reader["CountryName"];
                    CurrencyName = (string)reader["CurrencyName"];
                    CurrencyCode = (string)reader["CurrencyCode"];
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


        //Get Long Country Details By Name :-
        public static bool GetLongCountryDetails(string Name, ref int ID, ref string CurrencyName, ref string CurrencyCode, ref double Rate)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Countries.ID, Currencies.Name AS CurrencyName, Currencies.Code AS CurrencyCode, Currencies.Rate
                           FROM Countries INNER JOIN Currencies
                           ON Countries.CurrencyID = Currencies.ID
                           WHERE Countries.Name = @Name;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Long Country Details By Name :-
            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ID"];
                    CurrencyName = (string)reader["CurrencyName"];
                    CurrencyCode = (string)reader["CurrencyCode"];
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


        //Add New Country :-
        public static int AddNewCountry(string Name, string CurrencyName, string CurrencyCode, double Rate)
        {
            int CountryID = -1, CurrencyID = -1;

            CurrencyID = clsCurrencyData.AddNewCurrency(CurrencyName, CurrencyCode, Rate);

            if (CurrencyID == -1)
            {
                return CountryID;
            }

            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"INSERT INTO Countries
                           (Name , CurrencyID)
                           VALUES
                           (@Name , @CurrencyID)
                           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

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


        //Update Country By ID :-
        public static bool UpdateCountry(int ID, string Name, int CurrencyID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"UPDATE Countries
                           SET Name = @Name , CurrencyID = @CurrencyID
                           Where Countries.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

            //Update Country By ID :-
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


        //Delete Country By ID :-
        public static bool DeleteCountry(int ID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"DELETE FROM Countries
                           WHERE Countries.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Delete Country By ID :-
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


        //Delete Country By Name :-
        public static bool DeleteCountry(string Name)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"DELETE FROM Countries
                           WHERE Countries.Name = @Name;";

            SqlCommand command = new SqlCommand(query, connection);

            //Delete Country By Name :-
            command.Parameters.AddWithValue("@Name", Name);

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
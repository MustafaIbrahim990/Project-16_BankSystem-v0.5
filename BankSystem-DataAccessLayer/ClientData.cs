using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSystem_DataAccessLayer
{
    public static class clsClientData
    {
        //Get Short All Clients Details :-
        public static DataTable GetShortAllClientsDetails()
        {
            DataTable dtClients = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Clients.ID, Persons.FirstName + ' ' + Persons.LastName AS FullName, Clients.AccountNumber, Clients.AccountBalance
                           FROM Clients INNER JOIN Persons
                           ON Clients.PersonID = Persons.ID;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtClients.Load(reader);
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
            return dtClients;
        }


        //Get Long All Clients Details :-
        public static DataTable GetLongAllClientsDetails()
        {
            DataTable dtClients = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Clients.ID, Persons.FirstName, Persons.LastName, Persons.Phone, Persons.Email,
                           Clients.AccountNumber, Clients.PINCode, Clients.AccountBalance
                           FROM Persons INNER JOIN Clients
                           ON Clients.PersonID = Persons.ID";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtClients.Load(reader);
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
            return dtClients;
        }


        //Get Total Clients Balance Details :-
        public static decimal GetTotalClientsBalance()
        {
            decimal TotalBalance = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT SUM(Clients.AccountBalance) AS TotalBalance From Clients;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();

                if (result != null)
                {
                    TotalBalance = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return TotalBalance;
        }


        //Is Client Exists By ID :-
        public static bool IsClientExists(int ID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Result = 'Yes' FROM Clients
                           WHERE Clients.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Is Client Exist By ID :-
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


        //Is Client Exists By AccountNumber :-
        public static bool IsClientExists(string AccountNumber)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Result = 'Yes' FROM Clients
                           WHERE Clients.AccountNumber = @AccountNumber;";

            SqlCommand command = new SqlCommand(query, connection);

            //Is Client Exist By AccountNumber :-
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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


        //Get PersonID By ClientID :-
        public static bool GetPersonID(int ClientID, ref int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT PersonID FROM Clients
                           WHERE Clients.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get PersonID By ClientID :-
            command.Parameters.AddWithValue("@ID", ClientID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
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


        //Get PersonID By AccountNumber :-
        public static bool GetPersonID(string AccountNumber, ref int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT PersonID FROM Clients
                           WHERE Clients.AccountNumber = @AccountNumber;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get PersonID By AccountNumber :-
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
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


        //Get Short Client Details By ID :-
        public static bool GetShortClientDetails(int ID, ref string AccountNumber, ref string PINCode, ref decimal AccountBalance, ref int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM Clients
                           WHERE Clients.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Short Client Details By ID :-
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    AccountNumber = (string)reader["AccountNumber"];
                    PINCode = (string)reader["PINCode"];
                    AccountBalance = (decimal)reader["AccountBalance"];
                    PersonID = (int)reader["PersonID"];
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


        //Get Short Client Details By AccountNumber :-
        public static bool GetShortClientDetails(string AccountNumber, ref int ID, ref string PINCode, ref decimal AccountBalance, ref int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM Clients
                           WHERE Clients.AccountNumber = @AccountNumber;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Short Client Details By AccountNumber :-
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ID"];
                    PINCode = (string)reader["PINCode"];
                    AccountBalance = (decimal)reader["AccountBalance"];
                    PersonID = (int)reader["PersonID"];
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


        //Get Long Client Details By ID :-
        public static bool GetLongClientDetails(int ID, ref string FirstName, ref string LastName, ref string Phone, ref string Email, ref string AccountNumber, ref string PINCode, ref decimal AccountBalance)
        {
            bool isFound = false; 
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Clients.AccountNumber, Clients.PINCode, Clients.AccountBalance, Persons.FirstName,
                           Persons.LastName, Persons.Phone, Persons.Email
                           FROM Persons INNER JOIN Clients
                           ON Persons.ID = Clients.PersonID
                           Where Clients.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Long Client Details By ID :-
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    AccountNumber = (string)reader["AccountNumber"];
                    PINCode = (string)reader["PINCode"];
                    AccountBalance = (decimal)reader["AccountBalance"];
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


        //Get Long Client Details By AccountNumber :-
        public static bool GetLongClientDetails(string AccountNumber, ref int ID, ref string FirstName, ref string LastName, ref string Phone, ref string Email, ref string PINCode, ref decimal AccountBalance)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Clients.ID, Clients.PINCode, Clients.AccountBalance, Persons.FirstName,
                           Persons.LastName, Persons.Phone, Persons.Email
                           FROM Persons INNER JOIN Clients
                           ON Persons.ID = Clients.PersonID
                           Where Clients.AccountNumber = @AccountNumber;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Long Client Details By AccountNumber :-
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    PINCode = (string)reader["PINCode"];
                    AccountBalance = (decimal)reader["AccountBalance"];
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


        //Add New Client :-
        public static int AddNewClient(string FirstName, string LastName, string Phone, string Email, string AccountNumber, string PINCode, decimal AccountBalance)
        {
            int ClientID = -1, PersonID = -1;

            PersonID = clsPersonData.AddNewPerson(FirstName, LastName, Phone, Email);

            if (PersonID == -1) 
            {
                return ClientID;
            }

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"INSERT INTO Clients
                           (AccountNumber , PINCode , AccountBalance , PersonID)
                           VALUES
                           (@AccountNumber , @PINCode , @AccountBalance , @PersonID);
                           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PINCode", PINCode);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    ClientID = InsertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return ClientID;
        }


        //Update Client By ID (It Used) :-
        public static bool UpdateClient(int ID, string FirstName, string LastName, string Phone, string Email, string PINCode, decimal AccountBalance)
        {
            int PersonID = -1;

            if (GetPersonID(ID, ref PersonID)) 
            {
                if (!clsPersonData.UpdatePerson(PersonID, FirstName, LastName, Phone, Email)) 
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"UPDATE Clients
                           SET PINCode = @PINCode , AccountBalance = @AccountBalance
                           Where Clients.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PINCode", PINCode);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

            //Update Client By ID :-
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


        //Delete Client By ID :-
        public static bool DeleteClient(int ID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"DELETE FROM Clients
                           WHERE Clients.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Delete Client By ID :-
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


        //Delete Client By AccountNumber :-
        public static bool DeleteClient(string AccountNumber)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"DELETE FROM Clients
                           WHERE Clients.AccountNumber = @AccountNumber;";

            SqlCommand command = new SqlCommand(query, connection);

            //Delete Client By AccountNumber :-
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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


        //Deposit By ID :-
        public static bool DepositWithdraw(int ID, decimal NewBalance)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"UPDATE Clients
                           SET AccountBalance = @AccountBalance
                           Where Clients.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountBalance", NewBalance);

            //Update Client By ID :-
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


        //Deposit By AccountNumber :-
        public static bool DepositWithdraw(string AccountNumber, decimal NewBalance)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"UPDATE Clients
                           SET AccountBalance = @AccountBalance
                           Where Clients.AccountNumber = @AccountNumber;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountBalance", NewBalance);

            //Update Client By AccountNumber :-
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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


        //Transfer By ID :-
        public static bool Transfer(int sClientID, int dClientID, decimal sBalance, decimal dBalance)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query1 = @"UPDATE Clients
                            SET AccountBalance = @sBalance
                            Where Clients.ID = @sClientID;";

            string query2 = @"UPDATE Clients
                            SET AccountBalance = @dBalance
                            Where Clients.ID = @dClientID;";

            SqlCommand command1 = new SqlCommand(query1, connection);
            SqlCommand command2 = new SqlCommand(query2, connection);

            command1.Parameters.AddWithValue("@sBalance", sBalance);
            command2.Parameters.AddWithValue("@dBalance", dBalance);

            //Update Client By ID :-
            command1.Parameters.AddWithValue("@sClientID", sClientID);
            command2.Parameters.AddWithValue("@dClientID", dClientID);

            try
            {
                connection.Open();
                rowsAffected = command1.ExecuteNonQuery();
                rowsAffected += command2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 1);
        }


        //Transfer By AccountNumber :-
        public static bool Transfer(string sAccountNumber, string dAccountNumber, decimal sBalance, decimal dBalance)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query1 = @"UPDATE Clients
                            SET AccountBalance = @sBalance
                            Where Clients.AccountNumber = @sAccountNumber;";

            string query2 = @"UPDATE Clients
                            SET AccountBalance = @dBalance
                            Where Clients.AccountNumber = @dAccountNumber;";

            SqlCommand command1 = new SqlCommand(query1, connection);
            SqlCommand command2 = new SqlCommand(query2, connection);

            command1.Parameters.AddWithValue("@sBalance", sBalance);
            command2.Parameters.AddWithValue("@dBalance", dBalance);

            //Update Client By ID :-
            command1.Parameters.AddWithValue("@sAccountNumber", sAccountNumber);
            command2.Parameters.AddWithValue("@dAccountNumber", dAccountNumber);

            try
            {
                connection.Open();
                rowsAffected = command1.ExecuteNonQuery();
                rowsAffected += command2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 1);
        }

    }
}
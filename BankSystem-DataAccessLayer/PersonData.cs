using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSystem_DataAccessLayer
{
    public static class clsPersonData
    {
        //Get All Persons :-
        public static DataTable GetAllPersons()
        {
            DataTable dtPersons = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM Persons;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPersons.Load(reader);
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
            return dtPersons;
        }


        //Is Person Exists By ID :-
        public static bool IsPersonExists(int ID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Result = 'Yes' FROM Persons
                           WHERE Persons.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Is Person Exist By ID :-
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


        //Get Person Info By ID :-
        public static bool GetPersonInfo(int ID, ref string FirstName, ref string LastName, ref string Phone, ref string Email)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM Persons
                           WHERE Persons.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Person Info By ID :-
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


        //Add New Person :-
        public static int AddNewPerson(string FirstName, string LastName, string Phone, string Email)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"INSERT INTO Persons
                           (FirstName , LastName , Phone , Email)
                           VALUES
                           (@FirstName , @LastName , @Phone , @Email);
                           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
           
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


        //Update Person By ID :-
        public static bool UpdatePerson(int ID, string FirstName, string LastName, string Phone, string Email)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"UPDATE Persons
                           SET FirstName = @FirstName , LastName = @LastName , Phone = @Phone , Email = @Email
                           Where Persons.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);

            //Update Person By ID :-
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


        //Delete Person By ID :-
        public static bool DeletePerson(int ID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"DELETE FROM Persons
                           WHERE Persons.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Delete Person By ID :-
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
    }
}
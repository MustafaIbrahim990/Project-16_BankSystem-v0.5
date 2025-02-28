using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSystem_DataAccessLayer
{
    public static class clsUserLoginRegistersData
    {
        //Get Short All User Login Registers Details :-
        public static DataTable GetShortAllUserLoginRegistersDetails()
        {
            DataTable dtUserLoginRegisters = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM UserLoginRegisters;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtUserLoginRegisters.Load(reader);
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
            return dtUserLoginRegisters;
        }


        //Get Long All User Login Registers Details :-
        public static DataTable GetLongAllUserLoginRegistersDetails()
        {
            DataTable dtUserLoginRegisters = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT UserLoginRegisters.ID, UserLoginRegisters.DateTime, Users.UserName, Users.PassWord, Users.Permissions
                            FROM UserLoginRegisters INNER JOIN Users
                            ON UserLoginRegisters.UserID = Users.ID";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtUserLoginRegisters.Load(reader);
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
            return dtUserLoginRegisters;
        }


        //Add New User Login Registers :-
        public static int AddNewUserLoginRegisters(DateTime DateTime, int UserID)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"INSERT INTO UserLoginRegisters
                           (DateTime , UserID)
                           VALUES
                           (@DateTime , @UserID)
                           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DateTime", DateTime);
            command.Parameters.AddWithValue("@UserID", UserID);
            
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
    }
}
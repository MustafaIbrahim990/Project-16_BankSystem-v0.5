using System;
using System.Data;
using System.Data.SqlClient;


namespace BankSystem_DataAccessLayer
{
    public static class clsClientTransferRegistersData
    {
        //Get Short All Client Transfer Registers Details :-
        public static DataTable GetShortAllClientTransferRegistersDetails()
        {
            DataTable dtClientTransferRegisters = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM ClientTransferRegisters;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtClientTransferRegisters.Load(reader);
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
            return dtClientTransferRegisters;
        }


        //Get Long All Client Transfer Registers Details :-
        public static DataTable GetLongAllClientTransferRegistersDetails()
        {
            DataTable dtClientTransferRegisters = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT ClientTransferRegisters.ID, ClientTransferRegisters.DateTime, sClients.AccountNumber AS sAccountNumber, dClients.AccountNumber AS dAccountNumber,
                           ClientTransferRegisters.Amount, ClientTransferRegisters.sBalance, ClientTransferRegisters.dBalance, Users.UserName AS ByUser
                           FROM ClientTransferRegisters INNER JOIN Clients AS sClients
                           ON ClientTransferRegisters.sClientID = sClients.ID 
                           INNER JOIN Clients AS dClients 
                           ON ClientTransferRegisters.dClientID = dClients.ID 
                           INNER JOIN Users
                           ON ClientTransferRegisters.ByUserID = Users.ID";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtClientTransferRegisters.Load(reader);
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
            return dtClientTransferRegisters;
        }


        //Add New Client Transfer Registers By ID :-
        public static int AddNewClientTransferRegisters(DateTime DateTime, int sClientID, int dClientID, decimal Amount, decimal sBalance, decimal dBalance, int ByUserID)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"INSERT INTO ClientTransferRegisters
                           (DateTime , sClientID , dClientID , Amount , sBalance , dBalance , ByUserID)
                           VALUES
                           (@DateTime , @sClientID , @dClientID , @Amount , @sBalance , @dBalance , @ByUserID)
                           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DateTime", DateTime);
            command.Parameters.AddWithValue("@sClientID", sClientID);
            command.Parameters.AddWithValue("@dClientID", dClientID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@sBalance", sBalance);
            command.Parameters.AddWithValue("@dBalance", dBalance);
            command.Parameters.AddWithValue("@ByUserID", ByUserID);

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
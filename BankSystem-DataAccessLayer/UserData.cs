using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSystem_DataAccessLayer
{
    public static class clsUserData
    {
        //Get Short All Users Details :-
        public static DataTable GetShortAllUsersDetails()
        {
            DataTable dtUsers = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM Users;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtUsers.Load(reader);
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
            return dtUsers;
        }


        //Get Long All Users Details :-
        public static DataTable GetLongAllUsersDetails()
        {
            DataTable dtUsers = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Users.ID, Persons.FirstName, Persons.LastName, Persons.Phone, Persons.Email,
                           Users.UserName, Users.PassWord, Users.Permissions
                           FROM Persons INNER JOIN Users
                           ON Users.PersonID = Persons.ID";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtUsers.Load(reader);
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
            return dtUsers;
        }


        //Is User Exists By ID :-
        public static bool IsUserExists(int ID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Result = 'Yes' FROM Users
                           WHERE Users.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Is User Exists By ID :-
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


        //Is User Exists By UserName :-
        public static bool IsUserExists(string UserName)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Result = 'Yes' FROM Users
                           WHERE Users.UserName = @UserName;";

            SqlCommand command = new SqlCommand(query, connection);

            //Is User Exist By UserName :-
            command.Parameters.AddWithValue("@UserName", UserName);

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


        //Is User Exists By UserName and PassWord :-
        public static bool IsUserExists(string UserName, string PassWord)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Result = 'Yes' FROM Users
                           WHERE Users.UserName = @UserName AND Users.PassWord = @PassWord;";

            SqlCommand command = new SqlCommand(query, connection);

            //Is User Exist By UserName and PassWord :-
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@PassWord", PassWord);

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


        //Get PersonID By UserID :-
        public static bool GetPersonID(int UserID, ref int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT PersonID FROM Users
                           WHERE Users.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get PersonID By UserID :-
            command.Parameters.AddWithValue("@ID", UserID);

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


        //Get PersonID By UserName :-
        public static bool GetPersonID(string UserName, ref int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT PersonID FROM Users
                           WHERE Users.UserName = @UserName;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get PersonID By UserName :-
            command.Parameters.AddWithValue("@UserName", UserName);

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


        //Get PersonID By UserName and PassWord :-
        public static bool GetPersonID(string UserName, string PassWord, ref int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT PersonID FROM Users
                           WHERE Users.UserName = @UserName AND Users.PassWord = @PassWord;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get PersonID By UserName and PassWord :-
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@PassWord", PassWord);

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


        //Get Short User Details By ID :-
        public static bool GetShortUserDetails(int ID, ref string UserName, ref string PassWord, ref int Permissions, ref int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM Users
                           WHERE Users.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Short User Details By ID :-
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserName = (string)reader["UserName"];
                    PassWord = (string)reader["PassWord"];
                    Permissions = (int)reader["Permissions"];
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


        //Get Short User Details By UserName :-
        public static bool GetShortUserDetails(string UserName, ref int ID, ref string PassWord, ref int Permissions, ref int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM Users
                           WHERE Users.UserName = @UserName;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Short User Details By UserName :-
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ID"];
                    PassWord = (string)reader["PassWord"];
                    Permissions = (int)reader["Permissions"];
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


        //Get Short User Details By UserName and PassWord :-
        public static bool GetShortUserDetails(string UserName, string PassWord, ref int ID, ref int Permissions, ref int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT * FROM Users
                           WHERE Users.UserName = @UserName AND Users.PassWord = @PassWord;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Short User Details By UserName and PassWord :-
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@PassWord", PassWord);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ID"];
                    Permissions = (int)reader["Permissions"];
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


        //Get Long User Details By ID :-
        public static bool GetLongUserDetails(int ID, ref string FirstName, ref string LastName, ref string Phone, ref string Email, ref string UserName, ref string PassWord, ref int Permissions)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Users.UserName, Users.PassWord, Users.Permissions, Persons.FirstName,
                           Persons.LastName, Persons.Phone, Persons.Email
                           FROM Persons INNER JOIN Users
                           ON Persons.ID = Users.PersonID
                           Where Users.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Long User Details By ID :-
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
                    UserName = (string)reader["UserName"];
                    PassWord = (string)reader["PassWord"];
                    Permissions = (int)reader["Permissions"];
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


        //Get Long User Details By UserName :-
        public static bool GetLongUserDetails(string UserName, ref int ID, ref string FirstName, ref string LastName, ref string Phone, ref string Email, ref string PassWord, ref int Permissions)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Users.ID, Users.PassWord, Users.Permissions, Persons.FirstName,
                           Persons.LastName, Persons.Phone, Persons.Email
                           FROM Persons INNER JOIN Users
                           ON Persons.ID = Users.PersonID
                           Where Users.UserName = @UserName;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Long User Details By UserName :-
            command.Parameters.AddWithValue("@UserName", UserName);

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
                    PassWord = (string)reader["PassWord"];
                    Permissions = (int)reader["Permissions"];
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


        //Get Long User Details By UserName and PassWord :-
        public static bool GetLongUserDetails(string UserName, string PassWord, ref int ID, ref string FirstName, ref string LastName, ref string Phone, ref string Email, ref int Permissions)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"SELECT Users.ID, Users.Permissions, Persons.FirstName,
                           Persons.LastName, Persons.Phone, Persons.Email
                           FROM Persons INNER JOIN Users
                           ON Persons.ID = Users.PersonID
                           Where Users.UserName = @UserName AND Users.PassWord = @PassWord;";

            SqlCommand command = new SqlCommand(query, connection);

            //Get Long User Details By UserName and PassWord :-
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@PassWord", PassWord);

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
                    Permissions = (int)reader["Permissions"];
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


        //Add New User :-
        public static int AddNewUser(string FirstName, string LastName, string Phone, string Email, string UserName, string PassWord, int Permissions)
        {
            int UserID = -1, PersonID = -1;

            PersonID = clsPersonData.AddNewPerson(FirstName, LastName, Phone, Email);

            if (PersonID == -1)
            {
                return UserID;
            }

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"INSERT INTO Users
                           (UserName , PassWord , Permissions , PersonID)
                           VALUES
                           (@UserName , @PassWord , @Permissions , @PersonID);
                           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@PassWord", PassWord);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    UserID = InsertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return UserID;
        }


        //Update User By ID :-
        public static bool UpdateUser(int ID, string FirstName, string LastName, string Phone, string Email, string UserName, string PassWord, int Permissions)
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

            string query = @"UPDATE Users
                           SET UserName = @UserName , PassWord = @PassWord , Permissions = @Permissions
                           Where Users.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@PassWord", PassWord);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            //Update User By ID :-
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


        //Delete User By ID :-
        public static bool DeleteUser(int ID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"DELETE FROM Users
                           WHERE Users.ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            //Delete User By ID :-
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


        //Delete User By UserName :-
        public static bool DeleteUser(string UserName)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"DELETE FROM Users
                           WHERE Users.UserName = @UserName;";

            SqlCommand command = new SqlCommand(query, connection);

            //Delete User By UserName :-
            command.Parameters.AddWithValue("@UserName", UserName);

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


        //Delete User By UserName and PassWord :-
        public static bool DeleteUser(string UserName, string PassWord)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"DELETE FROM Users
                           WHERE Users.UserName = @UserName AND PassWord = @PassWord;";

            SqlCommand command = new SqlCommand(query, connection);

            //Delete User By UserName and PassWord :-
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@PassWord", PassWord);

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
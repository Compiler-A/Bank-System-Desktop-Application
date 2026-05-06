using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsDataUsers
    {
        static public bool CheckedDataUser(string UserName, string Password)
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "select Found = 1 from Users where" +
                " UserName = @UserName and Password = @Password ;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);

            try
            {
                Connection.Open();
                object Reader = Command.ExecuteScalar();
                if (Reader != null)
                {
                    Found = true;
                }

            }
            catch
            {
                Found = false;
            }
            finally
            {
                Connection.Close();
            }
            return Found;
        }
        static public bool AddLoginRegister(string UserName)
        {
            bool Completed = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "insert into LoginRegister (UserName, DateTime) \n" +
                "values (@UserName, GetDate()) ";

            SqlCommand Command = new SqlCommand(Query,Connection);

            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                Connection.Open();
                object Count = Command.ExecuteScalar();

                if (Count != null)
                {
                    Completed = true;
                }
            }
            catch (Exception ex) 
            {
                Completed = false;
               
            }
            finally
            {
                Connection.Close();
            }
            return Completed;
        }
        static public DataTable GetAllLoginRegister()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "select * from LoginRegister";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
               
                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch
            {
                
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        static public bool FindUserByUserName(ref int UserID, string US, ref string FirstName,
            ref string LastName, ref string Email, ref int Phone, ref string Password, ref int Permission)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);
            string Query = "select UserID, UserName ,FirstName, LastName, Email, Phone, Password, Permission " +
                "from Persons inner join Users on Persons.PersonID = Users.PersonID " +
                "  where UserName = @UserID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", US);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isFound = true;
                    UserID = (int)Reader["UserID"];
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Email = (string)Reader["Email"];
                    Phone = (int)Reader["Phone"];
                    Password = (string)Reader["Password"];
                    Permission = Convert.ToInt32(Reader["Permission"]);

                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                US = (string)ex.Message;
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

        static public bool FindUserByID(int UserID, ref string US, ref string FirstName,
            ref string LastName, ref string Email, ref int Phone, ref string Password, ref int Permission)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);
            string Query = "select UserID, UserName ,FirstName, LastName, Email, Phone, Password, Permission " +
                "from Persons inner join Users on Persons.PersonID = Users.PersonID " +
                "  where UserID = @UserID ;";
            SqlCommand Command = new SqlCommand(Query,Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isFound = true;
                    US = (string)Reader["UserName"];
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Email = (string)Reader["Email"];
                    Phone = (int)Reader["Phone"];
                    Password = (string)Reader["Password"];
                    Permission = Convert.ToInt32(Reader["Permission"]);

                }
                Reader.Close();
            }
            catch (Exception ex) 
            {
                isFound = false;
                US = (string)ex.Message;
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

        static public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "select UserID, UserName ,FirstName, LastName, Email, Phone, Password, Permission " +
                " from Persons inner join Users on Persons.PersonID = Users.PersonID;";
            
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
            }
            catch
            {
                Connection.Close();
            }
            finally
            { Connection.Close(); }

            return dt;
        }

        static public bool CheckedUser(int UserID)
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "select Found = 1 from Users where UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query,Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Found = true;
                }
                Reader.Close();
            }
            catch { Found = false; }
            finally { Connection.Close(); }

            return Found;
        }

        static public bool DeleteUser(int UserID)
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "delete from Users where UserID = @UserID ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);


            int PersonID = GetPersonID(UserID);
            try
            {
                Connection.Open();
                int Count = Command.ExecuteNonQuery();
                if (Count > 0)
                {
                    Found = true;
                }
                if (!clsDataPersons.DeletePerson(PersonID))
                {
                    Found =  false;
                }
            }
            catch
            {
                Found = false;
            }
             finally{ Connection.Close(); }

            return Found;
        }


        static public int GetPersonID(int UserID)
        {
            
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);
            string Query = "select PersonID from Users where UserID = @UserID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            object Count = null;
            try
            {
                Connection.Open();
                Count = Command.ExecuteScalar();
            }
            catch { }
            finally { Connection.Close(); }
            return Convert.ToInt32(Count);
        }

        static public bool UpdateUser(int UserID,  string UserName,  string FirstName,
             string LastName,  string Email,  int Phone,  string Password,  int Permission)
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = @"Update  Users  
                            set UserName = @UserName,
                                Password = @Password,
                                Permission = @Permission
                                where UserID = @UserID";

            
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@Permission", Permission);
            Command.Parameters.AddWithValue("@UserID", UserID);

            if (!clsDataPersons.UpdatePerson(GetPersonID(UserID),FirstName, LastName, Email, Phone))
            {
                return false;
            }

            try
            {
                Connection.Open();
                SqlDataReader Count = Command.ExecuteReader();
                if (Count != null)
                {
                    Found = true;
                }
            }
            catch { }
            finally { Connection.Close(); }

            return Found;

        }

        static public bool AddNewUser( string UserName, string FirstName,
             string LastName, string Email, int Phone, string Password, int Permission)
        {
            bool Found = false;

            int PersonID = clsDataPersons.AddNewPerson(FirstName, LastName, Email, Phone);

            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = @"insert  Users  (UserName, Password, Permission, PersonID)
                            values  (@UserName, @Password, @Permission, @PersonID);";
            
            
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@Permission", Permission);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

           

            try
            {
                Connection.Open();
                SqlDataReader Count = Command.ExecuteReader();
                if (Count != null)
                {
                    Found = true;
                }
            }
            catch { }
            finally { Connection.Close(); }

            return Found;
        }

        static public bool NotUniqueUser(string UserName, int ID)
        {

            

                bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "select distinct Found =1 " +
                " from ( select UserName from Users where not UserID = @ID ) R1 " +
                "  where R1.UserName = @UN ;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CN", UserName);
            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    Found = true;
                }
            }
            catch { }
            finally { Connection.Close(); }

            return Found;
        }
    }
}

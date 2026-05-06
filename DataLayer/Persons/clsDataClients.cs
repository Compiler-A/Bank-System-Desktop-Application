using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsDataClients
    {
        static public float GetTotalBallance()
        {
            float TBallance = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "select Sum(Ballance) as B from Clients";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    TBallance = Convert.ToSingle(Reader["B"]);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }

            return TBallance;
        }

        static public DataTable GetAllClients()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "select CLientID, ClientName, FirstName, LastName, Email, Phone, Pincode, Ballance " +
                "from Clients inner join Persons on Persons.PersonID = Clients.PersonID;";
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
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        public static bool FindClientByClientName(ref int ID, string clientName, ref string FirstName,
            ref string LastName, ref string Email, ref int Phone, ref string PinCode, ref float Ballance)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);
            string Query = "select ClientID, ClientName ,FirstName, LastName, Email, Phone, PinCode, Ballance " +
                "from Persons inner join Clients on Persons.PersonID = Clients.PersonID " +
                "  where ClientName = @UserID ;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", clientName);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isFound = true;
                    ID = (int)Reader["ClientID"];
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Email = (string)Reader["Email"];
                    Phone = (int)Reader["Phone"];
                    PinCode = (string)Reader["PinCode"];
                    Ballance = Convert.ToInt64(Reader["Ballance"]);

                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                clientName = (string)ex.Message;
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }
        public static bool FindClient(int ID, ref string clientName, ref string FirstName,
            ref string LastName, ref string Email, ref int Phone, ref string PinCode,ref float Ballance)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);
            string Query = "select ClientID, ClientName ,FirstName, LastName, Email, Phone, PinCode, Ballance " +
                "from Persons inner join Clients on Persons.PersonID = Clients.PersonID " +
                "  where ClientID = @UserID ;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    isFound = true;
                    clientName = (string)Reader["ClientName"];
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Email = (string)Reader["Email"];
                    Phone = (int)Reader["Phone"];
                    PinCode = (string)Reader["PinCode"];
                    Ballance = Convert.ToInt64(Reader["Ballance"]);

                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                clientName = (string)ex.Message;
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }
        static public int GetPersonID(int UserID)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);
            string Query = "select PersonID from Clients where ClientID = @UserID";
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

        static public bool DeleteCLient(int ClientID)
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "delete from Clients where ClientID = @UserID ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", ClientID);


            int PersonsID = GetPersonID(ClientID);
            try
            {
                Connection.Open();
                int Count = Command.ExecuteNonQuery();
                if (Count > 0)
                {
                    Found = true;
                }
                if (!clsDataPersons.DeletePerson(PersonsID))
                {
                    return false;
                }
            }
            catch
            {
                Found = false;
            }
            finally { Connection.Close(); }

            return Found;
        }

        static public bool AddNewClient(string ClientName, string FirstName,string LastName,
                string Email, int Phone, string PinCode, float Ballance)
        {
            bool Found = false;
            int PersonID = clsDataPersons.AddNewPerson(FirstName, LastName, Email, Phone);
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = @"insert  Clients  (ClientName, PinCode, Ballance, PersonID)
                            values  (@UserName, @Password, @Permission, @PersonID);";


            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", ClientName);
            Command.Parameters.AddWithValue("@Password", PinCode);
            Command.Parameters.AddWithValue("@Permission", Ballance);
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

        static public bool UpdateClient(int ClientID, string ClientName, string FirstName, string LastName,
                string Email, int Phone, string PinCode, float Ballance)
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = @"Update  Clients  
                            set ClientName = @UserName,
                                PinCode = @Password,
                                Ballance = @Permission
                                where ClientID = @UserID";


            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", ClientName);
            Command.Parameters.AddWithValue("@Password", PinCode);
            Command.Parameters.AddWithValue("@Permission", Ballance);
            Command.Parameters.AddWithValue("@UserID", ClientID);

            if (!clsDataPersons.UpdatePerson(GetPersonID(ClientID), FirstName, LastName, Email, Phone))
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
        static public bool CheckedUser(int UserID)
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "select Found = 1 from Clients where ClientID = @UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
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

        static public bool ChangedBallance(string ClientName, float Ballance)
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "Update  Clients " +
                " set Ballance += @Ballance " +
                " where ClientName = @CN";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CN", ClientName);
            Command.Parameters.AddWithValue("@Ballance", Ballance);

            try
            {
                Connection.Open();
                int Reader = Command.ExecuteNonQuery();
                if (Reader > 0)
                {
                    Found = true;
                }
            }
            catch { }
            finally { Connection.Close(); }

            return Found;
        }

        static public bool NotUniqueClient(string ClientName, int Id)
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "select distinct * from " +
                "( select ClientName from Clients where ClientID != @ID ) R1" +
                " where R1.ClientName = @CN";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CN", ClientName);
            Command.Parameters.AddWithValue("@ID", Id);

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

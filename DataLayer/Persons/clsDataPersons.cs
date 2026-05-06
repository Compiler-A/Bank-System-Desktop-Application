using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsDataPersons
    {

        

        static public bool DeletePerson(int ID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "delete from Persons where PersonID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);

            int count = 0;
            try
            {
                Connection.Open();
                count = Command.ExecuteNonQuery();
            }
            catch { }
            finally { Connection.Close(); }
            return count > 0;
        }

        static public int AddNewPerson(string FirstName, string LastName,
            string Email,int Phone)
        {
            int PersonID = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);
            string Query = "insert Persons (FirstName, LastName, Email, Phone) " +
                            " values (@FN, @LN, @EL, @PE); " +
                            " SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FN", FirstName);
            Command.Parameters.AddWithValue("@LN", LastName);
            Command.Parameters.AddWithValue("@EL", Email);
            Command.Parameters.AddWithValue("@PE", Phone);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }
            catch { }
            finally { Connection.Close(); }

            return PersonID;

        }

        static public bool UpdatePerson(int ID, string FirstName, string LastName,
            string Email, int Phone )
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = @"Update  Persons 
                            set FirstName = @FirstName,
                                LastName = @LastName,
                                Email = @Email,
                                Phone = @Phone
                                where PersonID = @ID";


            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@ID", ID);


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
    }
}

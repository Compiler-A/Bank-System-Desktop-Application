using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataLayer
{
    public class clsDataCurrencies
    {
        static public DataTable GetAllCurrencies()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "select * from Currencies;";

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
            catch { }
            finally
            {
                Connection.Close();
            }

            return dt;
        }

        static public bool UpdateRateByCode(double newRate , string Code)
        {
            int Count = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "Update  Currencies set Rate1Dollar = @RD where Code = @Cd;";
            
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@RD", newRate);
            Command.Parameters.AddWithValue("@Cd", Code);

            try
            {
                Connection.Open();
                Count = Command.ExecuteNonQuery();
            }
            catch { }
            finally { Connection.Close(); }
            return Count > 0;
        }

        static public bool ExistCurrencyByCode(string Code)
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "select Found = 1 from Currencies where Code = @Cd;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Cd", Code);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Found = true;
                    
                }
                Reader.Close();
            }
            catch { }
            finally
            {
                Connection.Close();
            }
            return Found;
        }

        static public bool FindCurrencybyCountryName(string Country, ref string Code, 
            ref string Name,ref double rate)
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "select * from Currencies where Country = @Ct;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Ct", Country);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                { 
                    Found = true;
                    Name = (string)Reader["Name"];
                    Code = (string)Reader["Code"];
                    rate = (double)Reader["Rate1Dollar"];
                }
                Reader.Close();
            }
            catch { }
            finally
            {
                Connection.Close();
            }
            return Found;
        }
        static public bool FindCurrencybyCode(string Code, ref string CountryName,
            ref string Name, ref double rate)
        {
            bool Found = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "select * from Currencies where Code = @Ct;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Ct", Code);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Found = true;
                    CountryName = (string)Reader["Country"];
                    Name = (string)Reader["Name"];
                    rate = Convert.ToDouble(Reader["Rate1Dollar"]);
                }
                Reader.Close();
            }
            catch {}
            finally
            {
                Connection.Close();
            }
            return Found;
        }

        static public int GetTotalCurrencies()
        {
            int TCurrencies = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "select Count(Code) as B from Currencies";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    TCurrencies = Convert.ToInt32(Reader["B"]);
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

            return TCurrencies;
        }
    }

}

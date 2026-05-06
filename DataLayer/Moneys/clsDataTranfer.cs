using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace DataLayer
{
    public class clsDataTranfer
    {
        public static bool AddTransferData(string sClient, string dClient, float Amount,
                float sBallance, float dBallance, string UserName)
        {
            bool Found = false;

            SqlConnection Connection  = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "insert into TranferLog (Date,sAcct, dAcct, Amount, sBallance, dBallance, [User]) " +
                " values (GetDate() ,@s , @d , @Amount , @sBallance , @dBallance , @User); ";
            
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@s", sClient);
            Command.Parameters.AddWithValue("@d", dClient);
            Command.Parameters.AddWithValue("@Amount", Amount);
            Command.Parameters.AddWithValue("@sBallance", sBallance);
            Command.Parameters.AddWithValue("@dBallance", dBallance);
            Command.Parameters.AddWithValue("@User", UserName);

            
            {
                Connection.Open();
                int Count = Command.ExecuteNonQuery();
                if (Count > 0)
                {
                    Found = true;
                }
            }
             { }
             { Connection.Close(); }
            return Found;
        }

        static public DataTable GetAllTransfer()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessLayer.ConnectionString);

            string Query = "select * from TranferLog";
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
    }
}

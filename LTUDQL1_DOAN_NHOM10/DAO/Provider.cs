using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Provider
    {

        string ConnectionString = @"Data Source=DESKTOP-3EVUCF6\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";

        SqlConnection Connection;

        public void Connect()
        {
            try
            {
                if (Connection == null)
                    Connection = new SqlConnection(ConnectionString);
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();

                Connection.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DisConnect()
        {
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
        }

        public int ExecuteNonQuery(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand cmd = Connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.CommandType = cmdType;
                if (parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                int nRow = cmd.ExecuteNonQuery();

                return nRow;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable Select(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand cmd = Connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.CommandType = cmdType;
                if (parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void AdapterUpdate(string strSql, DataTable dt)
        {
            try
            {
                SqlDataAdapter adapterUpdate = new SqlDataAdapter(strSql, Connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapterUpdate);
                adapterUpdate.Update(dt);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

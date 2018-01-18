using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    public class Provider
    {
        string cnstr = "";
        SqlConnection cn;
        public Provider()
        {
            cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cn = new SqlConnection(cnstr);
        }
        private void Connect()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                    cn.Open();
            }
            catch(SqlException p)
            {

                throw p;
            }
        }
        private void Disconnect()
        {
            if (cn != null && cn.State == ConnectionState.Open)
                cn.Close();
        }
        public SqlDataReader View(string sql)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                return cmd.ExecuteReader();
            }
            catch(SqlException p)
            {
                throw p;
            }
            finally
            {
                //Disconnect();
            }
        }
        public int ExecNonQuery(string sql, CommandType type, List<SqlParameter> paras)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                if (paras != null)
                {
                    foreach (SqlParameter para in paras)
                    {
                        cmd.Parameters.Add(para);
                    }
                }
                cmd.CommandType = type;
                //cmd.CommandText = "";
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException p)
            {
                throw p;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}

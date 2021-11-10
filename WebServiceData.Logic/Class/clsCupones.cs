using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WebServiceData.Logic.Class
{
    public class clsCupones
    {
        SqlCommand cmd = null;
        SqlConnection con = null;
        SqlParameter sqlparameter = null;
        SqlDataAdapter adapat = null;

        string stConexion;
        public clsCupones()
        {
            clsConexion obcclsConexion = new clsConexion();
            stConexion = obcclsConexion.getConexion();

        }

        public string UpdateCupon(string sCupon)
        {
            try
            {
                con = new SqlConnection(stConexion);
                con.Open();
                cmd = new SqlCommand("sp_ConsumirCupon", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Cupon", sCupon));

                sqlparameter = new SqlParameter();
                sqlparameter.ParameterName = "@sMensaje";
                sqlparameter.SqlDbType = SqlDbType.VarChar;
                sqlparameter.Size = 50;
                sqlparameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(sqlparameter);
                cmd.ExecuteNonQuery();

                return sqlparameter.Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { con.Close(); }
        }
    }
}

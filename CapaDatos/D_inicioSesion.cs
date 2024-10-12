using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



using CapaEntidades;
namespace CapaDatos
{
    public class D_inicioSesion
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        SqlDataReader dataReader;

        public bool InicioSesion(string nombre, string pass)
        {
            SqlCommand SqlCmd = new SqlCommand("spiniciarsesiontg", conectar)
            {
             CommandType = CommandType.StoredProcedure
            };
            
            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@usuario", nombre);
            SqlCmd.Parameters.AddWithValue("@pass",pass);
            dataReader = SqlCmd.ExecuteReader();
            if(dataReader != null)
            {
                while (dataReader.Read())
                {
                    E_inicioSesion.IdUsuarios = dataReader.GetInt32(0);
                    E_inicioSesion.nombre = dataReader.GetString(1);
                    E_inicioSesion.password= dataReader.GetString(2);


                }
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

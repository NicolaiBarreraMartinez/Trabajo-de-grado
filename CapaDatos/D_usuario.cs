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
    public class D_usuario
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);


        public DataTable MostrarUsuarios()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("spmostrar_usuariosTG", conectar)
            {

                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);
            return DtResultado;

        }
        public string verificarConexion()
        {
            conectar.Open();
            return conectar.Database.ToString();
        }
    }
}
